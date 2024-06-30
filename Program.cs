using ReservationHotel.Entities;
using ReservationHotel.Entities.Exceptions;
using System;


namespace ReservationHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-In date (dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/MM/yyyy)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update  the reservation");
                Console.WriteLine("Check-In date (dd/MM/yyyy)");
                 checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/MM/yyyy)");
                 checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
