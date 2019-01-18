using Reservetion_Exception.Entities;
using Reservetion_Exception.Entities.Exceptions;
using System;

namespace Reservetion_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number:");
                int num = int.Parse(Console.ReadLine());
                Console.Write(" Check -in date(dd / MM / yyyy): ");
                DateTime check_In = DateTime.Parse(Console.ReadLine());
                Console.Write(" Check -out date(dd / MM / yyyy): ");
                DateTime check_Out = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(num, check_In, check_Out);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write(" Check -in date(dd / MM / yyyy): ");
                check_In = DateTime.Parse(Console.ReadLine());
                Console.Write(" Check -out date(dd / MM / yyyy): ");
                check_Out = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(check_In, check_Out);
                Console.WriteLine("Reservation: " + reservation);
            }catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: "+e.Message);
            }catch(FormatException e)
            {
                Console.WriteLine("Format error: "+e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Unexpected exception: " +e.Message);
            }
        }
    }
}
