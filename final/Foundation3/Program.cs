using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        string title = "Recipe for a Horror Show";
        string description = "Camera Techniques for Creating Suspense in Film: From Dutch Angles to Choker Shots.";
        DateTime date = new DateTime(2023, 12, 12);
        string time = "10 Am - 12 Noon";
        Address venue =new Address("Turkey St","Enfeld", "London","UK");
        string speaker = "Alfred Hitchcock";
        int capacity = 80;
        LectureEvent lectureEvent = new LectureEvent(title, description, date, time, venue, speaker, capacity);
        events.Add(lectureEvent);

        title = "Ihuoma & Ekweme's Wedding";
        description = "Wedding Ceremony at Riviera Garden.";
        date = new DateTime(2023, 12, 23);
        time = "Starts 10 Am";
        venue =new Address("1451 Raji Rasaki Rd","Amuwo-Odofin", "Lagos","Nigeria");
        string email = "RSVP@rivieragarden.ng";
        ReceptionEvent receptionEvent = new ReceptionEvent(title, description, date, time, venue, email);
        events.Add(receptionEvent);

        title = "Blankets and Wine Festival";
        description = "Good music, good vibes, good food and everything good."; //Source: https://blanketsandwine.com/kenya/event/sunday-december-17th-kenyan-summer-iii/
        date = new DateTime(2023, 12, 17);
        time = "10 Am - 5 Pm";
        venue =new Address("Laureate Garden","Kasarani", "Nairobi","Kenya");
        string weatherCondition = "28°C, Clouds followed by a brightening sky";
        OutdoorEvent outdoorEvent= new OutdoorEvent(title, description, date, time, venue, weatherCondition);
        events.Add(outdoorEvent);
        OutdoorEvent outdoorEvent2= new OutdoorEvent();

        foreach (Event activity in events)
        {
            Console.Write("\n");
            activity.GenerateStandardMessage();
            Console.WriteLine("------------------------------------");
            activity.GenerateFullMessage();
            Console.WriteLine("------------------------------------");
            activity.GenerateShortDescription();
            Console.Write("\n");
            Console.WriteLine("************************************");
        }
    }
}