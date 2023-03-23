public class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("321 Market St", "Otherville", "NY", "USA");

        Event[] events = new Event[]
        {
            new Lecture("Introduction to C#", "Learn the basics of C#", DateTime.Now.AddDays(1), DateTime.Now.AddHours(3), address1, "John Doe", 100),
            new Reception("Company Holiday Party", "Celebrate the season with coworkers", DateTime.Now.AddMonths(2), DateTime.Now.AddHours(5), address2, "RSVP to HR by December 1st"),
            new OutdoorGathering("Summer BBQ", "Join us for food, games, and fun", DateTime.Now.AddMonths(4), DateTime.Now.AddHours(4), address1, "Sunny and warm")
        };

        foreach (Event e in events)
        {
            Console.WriteLine("-----------------------");
            DateTime myDateTime = new DateTime(2023, 03, 22, 14, 30, 0);
            Console.WriteLine("Date: " + e.Date.ToString("MM/dd/yyyy"));
            Console.WriteLine("Time: " + e.Time.ToString("hh:mm tt"));


            if (e is Lecture)
            {
                Lecture l = (Lecture)e;
                Console.WriteLine("Title: Lecture" + e.Title);
                Console.WriteLine("Speaker: John Brown " + l.Speaker);
                Console.WriteLine("Capacity: 60 " + l.Capacity);
                DateTime myDateTime2 = new DateTime(2023, 03, 22, 14, 30, 0);
                Console.WriteLine("Date: " + e.Date.ToString("MM/dd/yyyy"));
                Console.WriteLine("Time: " + e.Time.ToString("hh:mm tt"));

            }
            else if (e is Reception)
            {
                Reception r = (Reception)e;
                Console.WriteLine("Title: Reception" + e.Title);
                Console.WriteLine("RSVP: If you are unable to join us please respond promptly. " + r.RSVP);
                DateTime myDateTime3 = new DateTime(2023, 03, 22, 14, 30, 0);
                Console.WriteLine("Date: " + e.Date.ToString("MM/dd/yyyy"));
                Console.WriteLine("Time: " + e.Time.ToString("hh:mm tt"));

            }
            else if (e is OutdoorGathering)
            {
                OutdoorGathering o = (OutdoorGathering)e;
                Console.WriteLine("Title: Outdoor Gathering" + e.Title);
                Console.WriteLine("Weather: Sunny, 60 " + o.Weather);
                DateTime myDateTime4 = new DateTime(2023, 03, 22, 14, 30, 0);
                Console.WriteLine("Date: " + e.Date.ToString("MM/dd/yyyy"));
                Console.WriteLine("Time: " + e.Time.ToString("hh:mm tt"));

            }

            Console.WriteLine("-----------------------");
        }
    }
}
