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

        //public List<Sport> GetSports()      //Getsports
        //{
        //    var spo = sb.GetAll();
        //    return spo;
        //}

        //public Sport GetSport(string sname)   //Getsport
        //{
        //    return sb.GetSport(sname);
        //}

        public void UpdateSport(int id, Sport s)   //update
        {
            sb.UpdateSport(id, s);
        }

        public void DeleteSport(int id, Sport s)   //delete
        {
            sb.DeleteSport(id, s);
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

        public List<Facility> GetFacilities()     //Getfacilities
        {
            var fac = fb.GetAll();
            return fac;
        }

        //public Facility GetFacility(string courtname)  //Getfacility
        //{
        //    return fb.GetFacility(courtname);
        //}

        public void UpdateFacility(int id, Facility f)  //update
        {
            fb.UpdateFacility(id, f);
        }

        public void DeleteFacility(int id, Facility f)  //delete
        {
            fb.DeleteFacility(id, f);
        }
    }

    class SlotController
    {
        SlotBroker sb = new SlotBroker();

        public List<Slot> GetSlots(int facilityid)
        {
            return sb.GetSlots(facilityid);
        }

        public List<Slot> GetSlot()
        {
            var slo = sb.GetAll();
            return slo;
        }

        public Member getSlot(string sName)
        {
            return sb.getSlot(sName);
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

        public List<BookingInfo> GetBookingInfoes(DateTime date)
        {
            return bt.GetBookingInfoes(date);   
        }

        public List<BookingInfo> GetBookingInfoes(string memname)
        {
            return bt.GetBookingInfoes(Regex.Split(memname,"\r\n")[0]);
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

    class UsersController
    {
        public bool Is_Valid_User(string Username, string Password)
        {
            UserBroker el = new UserBroker();
            bool Flag = el.is_valid_user(Username, Password);
            return Flag;
        }
        public bool Change_Password(string User_Name, string Confirm_Password)
        {
            UserBroker el = new UserBroker();
            bool flag = el.change_password(User_Name, Confirm_Password);
            return flag;
        }
        public bool Is_Valid_Member(string memname)
        {
            UserBroker el = new UserBroker();
            bool Flag = el.is_valid_member(memname);
            return Flag;
        }
        public void Delete_Booinginfo(int MemberId)
        {
            UserBroker el = new UserBroker();
            el.delete_bookinginfo(MemberId);
        }

        public List<BookingInfo> View_Booinginfo(string memname)
        {
            UserBroker el = new UserBroker();
            return el.view_bookinginfo(memname);
        }
        public void Delete_Booking(int li)
        {
            UserBroker el = new UserBroker();

            el.delete_booking(li);
        }
    }
}
