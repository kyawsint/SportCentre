using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group8b.App_Data
{
    class EntityClass
    {

    }

    class BookTrans
    {
        int sportid, slotid, facilityid, available;

        public int Facilityid
        {
            get { return facilityid; }
            set { facilityid = value; }
        }

        public int Slotid
        {
            get { return slotid; }
            set { slotid = value; }
        }

        public int Sportid
        {
            get { return sportid; }
            set { sportid = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        string status, time, courtname;

        public string Courtname
        {
            get { return courtname; }
            set { courtname = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Available
        {
            get { return available; }
            set { available = value; }
        }
    }
}
