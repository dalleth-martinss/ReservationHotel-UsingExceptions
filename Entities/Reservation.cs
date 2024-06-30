using System;
using ReservationHotel.Entities.Exceptions;


namespace ReservationHotel.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data do checkout deve ser depois da data do checkIn!");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                throw new DomainException( "As datas de reservas devem ser futuras");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainException( "A data do checkout deve ser depois da data do checkIn!");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Room"
                + RoomNumber
                
                + " , Check-In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + " , Check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + " , "
                + Duration()
                + " Noites";
        }
    }
}
