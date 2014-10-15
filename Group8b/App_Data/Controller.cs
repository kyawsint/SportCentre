using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Group8b.App_Data;
using System.Text.RegularExpressions;

namespace Group8b.App_Data
{
    class Controller
    {
    }

    class BookingInfoController
    { 
        
    }

    class SportController
    {
        SportBroker sb = new SportBroker();

        public List<Sport> GetSports()
        {
            return sb.GetAll();
        }

        public Sport GetSport(string sname)
        {
            return sb.GetSport(sname);
        }
    }

    class FacilityController
    {
        FacilityBroker fb = new FacilityBroker();

        public Facility GetFacility(string courtname)
        {
            return fb.GetFacility(courtname);
        }

        public List<Facility> GetFacilities(int SportID)
        {
            return fb.GetFacilities(SportID);
        }
    }

    class SlotController
    {
        SlotBroker sb = new SlotBroker();

        public List<Slot> GetSlots(int facilityid)
        {
            return sb.GetSlots(facilityid);
        }
    }

    class BookTransController
    {
        BookTransBroker bt = new BookTransBroker();

        public List<BookTrans> GetBookTrans(int facid, DateTime date)
        {
            return bt.GetBookTrans(facid,date);
        }

        public List<BookTrans> GetBookTrans(DateTime date, int sportid)
        {
            return bt.GetBookTrans(date, sportid);
        }

        public List<BookingInfo> GetBookingInfoes()
        {
            return bt.GetBookingInfoes();
        }

        public void UpdateBookingInfo(int id, string status)
        {
            bt.UpdateBookingInfo(id, status);
        }

        public int AddBookingInfo(int memid, int sportid, int facilityid, int slotid, DateTime date, string status)
        {
            return bt.AddBookingInfo(memid, sportid, facilityid, slotid, date, status);
        }

        public int GetBookingInfo(int slotid, DateTime date)
        {
            return bt.GetBookingInfo(slotid, date);
        }
    }

    class MemberController
    {
        MemberBroker mb = new MemberBroker();

        public List<Member> GetMembers()
        {
            return mb.GetMembers();
        }

        public Member GetMember(string name)
        {
            Member m = mb.GetMember(Regex.Split(name, "\r\n")[0]);
            return m;
        }
    }
}
