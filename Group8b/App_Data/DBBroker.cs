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

        public Member GetMember(string mname)
        {
            var memname = (Member)(from x in ctx.Members where x.Name == mname select x).Single();
            return memname;
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

        public void UpdateSport(int id, Sport ss)               //update
        {
            Sport s = (from x in ctx.Sports
                       where x.ID == id
                       select x).Single();

            s.Name = ss.Name;
            s.SportType = ss.SportType;
            s.Size = ss.Size;
            s.Description = ss.Description;
            ctx.SaveChanges();
        }

        public void DeleteSport(int id, Sport ss)           //delete
        {
            Sport s = (from x in ctx.Sports
                       where x.ID == id
                       select x).Single();


            ss = ctx.Sports.Where(x => x.ID == s.ID).Single();
            ctx.Sports.DeleteObject(ss);
            ctx.SaveChanges();
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

        public List<Facility> GetAll()                     //GetAll
        {
            var fs = from x in ctx.Facilities select x;
            return fs.ToList();
        }

        //public List<Facility> GetAll(int SportID)         //with one parameter
        //{
        //    var fs = from x in ctx.Facilities
        //             where x.SportID == SportID
        //             select x;
        //    return fs.ToList();

        //}

        //public Facility GetFacility(string courtname)     //GetFacility
        //{
        //    var fcourtname = (Facility)ctx.Facilities.First(x => x.CourtName == courtname);
        //    return fcourtname;
        //}

        public void UpdateFacility(int id, Facility ff)   //Update
        {
            Facility f = (from x in ctx.Facilities
                          where x.ID == id
                          select x).Single();

            f.SportID = ff.SportID;
            f.CourtCode = ff.CourtCode;
            f.CourtName = ff.CourtName;
            f.Description = ff.Description;
            ctx.SaveChanges();
        }

        public void DeleteFacility(int id, Facility ff)   //delete
        {
            Facility f = (from x in ctx.Facilities
                          where x.ID == id
                          select x).Single();

            ff = ctx.Facilities.Where(x => x.ID == f.ID).Single();
            ctx.Facilities.DeleteObject(ff);
            ctx.SaveChanges();
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

        public List<Slot> GetAll()
        {
            var Slot = from x in ctx.Slots select x;
            return Slot.ToList();
        }

        public Member getSlot(string sName)
        {
            var sloName = (Member)ctx.Members.First(x => x.Name == sName);
            return sloName;
        }
    }

    class BookTransBroker
    {
        group8bEntities ctx = new group8bEntities();
        BookingInfo bi;
        SqlConnection con;
        SqlCommand cmdselectbyp;
        SqlCommand cmdselectava;
        SqlCommand cmdselectall;
        string cons = "data source=(local); initial catalog=group8b; integrated security=True";

        public BookTransBroker()
        {
            con = new SqlConnection(cons);
            cmdselectbyp = new SqlCommand();
            cmdselectbyp.CommandText = "select sportid, slotid, facilityid, courtname, date, time,case when status is null then 'Available'"+
                " else status end as status from (select * from (select s.id as sportid, sl.id as slotid, fac.id as facilityid,"+
                " fac.courtname as courtname, bi.dateissue as date, Concat(datepart(hour,TimeFrom),':00',' to ', datepart(hour,TimeTo),':00')"+
            " as Time, bi.status from slots sl left join facility fac on fac.id=sl.FacilityID left join Sports s on s.id=fac.SportID left join"+
            " BookingInfo bi on bi.SlotID=sl.id and bi.FacilityID=fac.ID)a where"+
            " slotid not in(select slotid from BookingInfo where dateissue=@date)"+ 
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

            cmdselectall = new SqlCommand();
            cmdselectall.CommandText = "select * from bookinginfo where dateissue=@date";
            cmdselectall.Connection = con;
        }


        public List<BookingInfo> GetBookingInfoes()
        {
            var bookinfo = (from x in ctx.BookingInfoes where x.Status != "Confirmed" select x).ToList();
            return bookinfo;
        }

        public List<BookingInfo> GetBookingInfoes(DateTime date)
        {
            var bookinfo = (from x in ctx.BookingInfoes where x.DateIssue == date.Date && x.Status!="Confirmed" select x).ToList();
            return bookinfo;
        }

        public List<BookingInfo> GetBookingInfoes(string memname)
        {
            var bookinfo = (from x in ctx.BookingInfoes where x.Member.Name == memname && x.Status != "Confirmed" select x).ToList();
            return bookinfo;
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

        public int AddBookingInfo(int memid, int sportid, int facilityid, int slotid, DateTime date, string status)
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
            return bi.ID;
        }

        public void UpdateBookingInfo(int id, string status)
        {
            BookingInfo upd = ctx.BookingInfoes.First(x => x.ID == id);
            upd.Status = status;
            ctx.SaveChanges();
        }

        public int GetBookingInfo(int slotid, DateTime date)
        {
            var booklist = (from x in ctx.BookingInfoes where x.SlotID==slotid && x.DateIssue==date.Date select x).ToList();
            if (booklist.Count==0)
            {
                return 0;
            }
            return 1;
        }
    }

    class UserBroker
    {
        group8bEntities context = new group8bEntities();
        public bool is_valid_user(string username, string password)
        {

            var valid = from v in context.Users
                        where v.Name == username && v.Password == password
                        select v;
            if (valid.Any())
                return true;
            else
                return false;
        }
        public bool is_valid_member(string memname)
        {
            var valid = from v in context.Members
                        where v.Name == memname
                        select v;
            if (valid.Any())
                return true;
            else
                return false;
        }
        public bool change_password(string user_name, string confirm_password)
        {

            bool f = false;

            context = new group8bEntities();
            User u = new User();
            var q = from o in context.Users
                    where o.Name == user_name
                    select o;

            int count = q.Count();
            User u1 = q.First<User>();
            if (count == 1)
            {
                u1.Name = user_name;
                u1.Password = confirm_password;
                u1.ConfirmPassword = confirm_password;

                context.SaveChanges();
                f = true;

            }

            return f;
        }
        public void delete_bookinginfo(int memberid)
        {
            group8bEntities context = new group8bEntities();
            var id = (from m in context.BookingInfoes
                      where m.MemberID == memberid
                      select m).First();

            context.SaveChanges();
        }

        //internal void change_password(int MemberId)
        //{
        //    throw new NotImplementedException();
        //}

        public List<BookingInfo> view_bookinginfo(string memname)
        {
            group8bEntities context = new group8bEntities();

            List<BookingInfo> id = (from l in context.BookingInfoes
                                    where l.Member.Name == memname && l.Status != "Confirmed"
                                    select l).ToList();
            return id;
        }

        public void delete_booking(int li)
        {
            group8bEntities context = new group8bEntities();
            var del = from d in context.BookingInfoes
                      where d.ID == li
                      select d;
            foreach (var d in del)
            {
                context.BookingInfoes.DeleteObject(d);
            }
            context.SaveChanges();
        }
    }
}
