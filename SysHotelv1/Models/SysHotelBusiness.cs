using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class SysHotelBusiness
    {
        Messenger msn = new Messenger();

        public bool makeReservation(int IdRoom,DateTime EntranceDate, DateTime OutDate)
        {
            return true;
        }

        public int getReservationTotal()
        {
            return 3;
        }
    }
}