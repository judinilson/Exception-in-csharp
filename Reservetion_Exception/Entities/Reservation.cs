using System;
using Reservetion_Exception.Entities.Exceptions;

namespace Reservetion_Exception.Entities
{
    class Reservation
    {
        public int room { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int room, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("check-out date must be after check-in");
            }
            this.room = room;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public int Duration()
        {
            //diferenca entre as duas datas
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates (DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if(checkout <= checkin)
            {
                throw new DomainException("check-out date must be after check-in");
            }
            this.checkIn = checkin;
            this.checkOut = checkout;

        }


        public override string ToString()
        {
            return "Room " +
                room
                + ", Check-in: "
                + checkIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + checkOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
