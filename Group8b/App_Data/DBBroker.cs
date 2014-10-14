using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Group8b.App_Data;

namespace Group8b.App_Data
{
    class DBBroker
    {
    }

    class MemberBroker
    {
        group8bEntities ctx = new group8bEntities();

        public List<Member> GetMembers()
        {
            var mem = (from x in ctx.Members select x).ToList();
            return mem;
        }
    }

    class SportBroker
    {
        group8bEntities ctx = new group8bEntities();

        public List<Sport> GetAll()
        {
            var sport = (from x in ctx.Sports select x).ToList();
            return sport;
        }

        public Sport GetSport(string name)
        {
            var sname = (Sport)ctx.Sports.First(x => x.Name == name);
            return sname;
        }
    }

    class FacilityBroker
    {
        group8bEntities ctx = new group8bEntities();

        public Facility GetFacility(string courtname)
        {
            var fcourtname = (Facility)ctx.Facilities.First(x => x.CourtName == courtname);
            return fcourtname;
        }

        public List<Facility> GetFacilities(int SportID)
        {
            var fsport = (from x in ctx.Facilities where x.SportID == SportID select x).ToList();
            return fsport;
        }
    }

    class SlotBroker
    {
        group8bEntities ctx = new group8bEntities();

        public List<Slot> GetSlots(int facilityid)
        {
            var sslot = (from x in ctx.Slots where x.FacilityID == facilityid select x).ToList();
            return sslot;
        }
    }

    class BookTransBroker
    {
        group8bEntities ctx = new group8bEntities();
        BookingInfo bi;
        SqlConnection con;
        SqlCommand cmdselectbyp;
        SqlCommand cmdselectava;
        string cons = "data source=(local); initial catalog=group8b; integrated security=True";

        public BookTransBroker()
        {
            con = new SqlConnection(cons);
            cmdselectbyp = new SqlCommand();
            cmdselectbyp.CommandText = "select sportid, slotid, facilityid, courtname, date, time,case when status is null then 'Available'"+
                " else status end as status from (select * from (select s.id as sportid, sl.id as slotid, fac.id as facilityid,"+
                " fac.courtname as courtname, bi.dateissue as date, Concat(datepart(hour,TimeFrom),':00',' to ', datepart(hour,TimeTo),':00')"+
            " as Time, bi.status from slots sl left join facility fac on fac.id=sl.FacilityID left join Sports s on s.id=fac.SportID left join"+
            " BookingInfo bi on bi.SlotID=sl.id and bi.FacilityID=fac.ID)a where facilityid not in (select facilityid from BookingInfo"+
            " where date=@date) and slotid not in(select slotid from BookingInfo where date=@date)"+ 
            " union select * from (select s.id as sportid, sl.id as slotid, fac.id as facilityid, fac.courtname as courtname, bi.dateissue as date,"+
            " Concat(datepart(hour,TimeFrom),':00',' to ', datepart(hour,TimeTo),':00') as Time, bi.status from slots sl left join facility fac"+
            " on fac.id=sl.FacilityID left join Sports s on s.id=fac.SportID left join BookingInfo bi on bi.SlotID=sl.id and bi.FacilityID=fac.ID)a"+ 
            " where status is not null)a where facilityid=@facid";
            cmdselectbyp.Connection = con;

            cmdselectava = new SqlCommand();
            cmdselectava.CommandText = "select facilityid, courtname, count(facilityid) as Available from" +
                    " (select s.id as sportid, sl.id as slotid, fac.id as facilityid, fac.courtname as courtname, bi.dateissue as date," +
                    " Concat(datepart(hour,TimeFrom),':00',' to ', datepart(hour,TimeTo),':00') as Time, bi.status" +
                    " from slots sl left join facility fac on fac.id=sl.FacilityID left join Sports s on s.id=fac.SportID left join BookingInfo bi" +
                    " on bi.SlotID=sl.id and bi.FacilityID=fac.ID)a" +
                    " where facilityid not in (select facilityid from BookingInfo where date=@date) and" +
                    " slotid not in(select slotid from BookingInfo where date=@date) and sportid=@sportid group by facilityid, courtname";
            cmdselectava.Connection = con;
        }

        public List<BookTrans> GetBookTrans(DateTime date,int sportid)
        {
            cmdselectava.Parameters.Clear();
            SqlParameter pdate = new SqlParameter("@date", SqlDbType.Date);
            SqlParameter psportid = new SqlParameter("@sportid", SqlDbType.Int);
            cmdselectava.Parameters.AddRange(new SqlParameter[] { pdate,psportid });
            pdate.Value = date;
            psportid.Value = sportid;
            con.Open();
            SqlDataReader sdr = cmdselectava.ExecuteReader();
            List<BookTrans> avalist = new List<BookTrans>();
            try
            {
                while (sdr.Read())
                {
                    BookTrans btava = new BookTrans();
                    btava.Facilityid = Convert.ToInt32(sdr["facilityid"].ToString());
                    btava.Courtname = sdr["courtname"].ToString();
                    btava.Available = Convert.ToInt16(sdr["available"].ToString());
                    avalist.Add(btava);
                }
                con.Close();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            return avalist;
        }

        public List<BookTrans> GetBookTrans(int facid, DateTime date)
        {
            cmdselectbyp.Parameters.Clear();
            SqlParameter pfacid = new SqlParameter("@facid", SqlDbType.Int);
            SqlParameter pdate = new SqlParameter("@date", SqlDbType.Date);
            cmdselectbyp.Parameters.AddRange(new SqlParameter[] { pfacid, pdate });
            pfacid.Value = facid;
            pdate.Value = date;
            con.Open();
            SqlDataReader sdr = cmdselectbyp.ExecuteReader();
            List<BookTrans> btlist = new List<BookTrans>();
            try
            {
                while (sdr.Read())
                {
                    BookTrans bt = new BookTrans();
                    bt.Sportid = Convert.ToInt32(sdr["sportid"].ToString());
                    bt.Slotid = Convert.ToInt32(sdr["slotid"].ToString());
                    bt.Facilityid = Convert.ToInt32(sdr["facilityid"].ToString());
                    //bt.Date = Convert.ToDateTime(sdr["date"].ToString());
                    bt.Time = sdr["time"].ToString();
                    bt.Status = sdr["status"].ToString();
                    btlist.Add(bt);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return btlist;
        }

        public void AddBookingInfo(int memid, int sportid, int facilityid, int slotid, DateTime date, string status)
        {
            bi = new BookingInfo();
            bi.MemberID = memid;
            bi.SportID = sportid;
            bi.FacilityID = facilityid;
            bi.SlotID = slotid;
            bi.DateIssue = date;
            bi.Status = status;
            ctx.AddToBookingInfoes(bi);
            ctx.SaveChanges();
        }
    }
}
