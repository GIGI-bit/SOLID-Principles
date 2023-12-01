using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_O
{
    // Open/Close prinsipine esasen bir class yeniliklere aciq deyisikliklere qapali olmalidir
    // Meselen asagidaki numunede bir tur agentliyi yaradan class var ve bu classin calculateTickets adindaki method-u
    // gelen string-e gore bilet qiymetlerini hesablayir.
    //Hal hazirda normal islesede eyer sonradan ferqli bir tur elave olunarsa kod deyismeli olacaq Bunu defelerle tekrar etdiyinizi tesevvur edin
    internal class TravelAgency
    {
        public TravelAgency()
        {

        }

        public double calculateTickets(string travelPlan, int person)
        {
            double total = person;
            if (travelPlan == "Cruise Tour")
            {
                total *= 1869;
            }
            else if (travelPlan == "Turkey Tour")
            {
                total *= 630;
            }
            return total;
        }

    }
}

namespace After_O
{
    // Bu numunemizde ise uzun-uzun if sertlerine ehtiyac yoxdur yenilikler elave etmek daha asandir
    public interface ITicket
    {
        double calculateTickets(int person);
    }

    public class TurkeyTour : ITicket
    {
        public double calculateTickets(int person)
        {
            return person * 1890;
        }
    }
    public class CruiseTour : ITicket
    {
        public double calculateTickets(int person)
        {
            return person * 630;
        }
    }

    public class OpenClose
    {
        private readonly ITicket _ticket;
        public OpenClose(ITicket ticket)
        {
            _ticket = ticket;
        }
        public double calculate(int person)
        {
            return _ticket.calculateTickets(person);
        }

    }

}