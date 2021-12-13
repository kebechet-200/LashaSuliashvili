using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yieldReturn_Demo.Ticket
{
    public class FlightRegister
    {
        public static void SyncFlightTickets()
        {
            var tickets = GetFlightTickets();
           
            foreach (var ticket in tickets)
            {
                if (ticket.Id == 10)
                    break;
                Console.WriteLine($"Ticket {ticket.Id}");
            }
        }

        static IEnumerable<FlightTicket> GetFlightTickets()
        {
            //List<FlightTicket> flightTickets = new List<FlightTicket>();

            for (int i = 0; i < 20000; i++)
            {
                yield return new FlightTicket() { Company = "Test", Id = i, Passenger = $"Passsenger test {i}" };
                Console.WriteLine(i);
            }

            //return flightTickets;
        }
    }
}
