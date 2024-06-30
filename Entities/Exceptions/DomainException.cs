using System;
using System.Collections.Generic;


namespace ReservationHotel.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
