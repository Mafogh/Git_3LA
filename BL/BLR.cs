using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DL;

namespace BL
{
    public class BLR: DA
    {
        public string ReservationID;
        public string CustomerID;
        public string Date;
        public string RoomNum;
        public string DateFrom;
        public string DateTo;


        public DataTable customerdisplay()
        {
            base.connect();
            string query = "select * from Customer";
            DataTable dt = base.selectdata(query);
            base.disconnect();
            return dt;
        }

        public DataTable roomdisplay()
        {
            base.connect();
            string query = "select * from Room";
            DataTable dt = base.selectdata(query);
            base.disconnect();
            return dt;
        }

        public DataTable reservedisplay()
        {
            base.connect();
            string query = "select * from Reservation";
            DataTable dt = base.selectdata(query);
            base.disconnect();
            return dt;
        }

        public void roomreserve()
        {
            try
            {
                base.connect();
                string query = "insert into Reservation (ReservationID,CustomerID,Date,RoomNum,DateFrom,DateTo) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')";
                query = string.Format(query, ReservationID, CustomerID, Date, RoomNum, DateFrom, DateTo);
                base.cmdtext(query);
                base.disconnect();
            }
            catch (Exception)
            {
                //
            }
        }

        public void deleteall()
        {
            base.connect();
            string query = "delete from Reservation";
            base.cmdtext(query);
            base.disconnect();
        }
    }
}
