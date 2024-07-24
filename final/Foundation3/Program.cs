using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Otter st.", "Philadelphia", "Arizona", "USA");
        Address address2 = new Address("Woodpecker st.", "Memphis", "Colorado", "USA");
        Address address3 = new Address("Hornet st.", "Sacramento", "Minnesota", "USA");

        LectureEvent lectureEvent = new LectureEvent("Why is Mathematics Hard?", "EdTalk about why mathematics is difficult to grasp",
            "July 2, 2024", "7:00 P.M. MT", address1, "Steven Eagling", 250);
        
        OutdoorEvent outdoorEvent = new OutdoorEvent("Rally for World", "Rally across the streets to protest for climate",
            "March 30, 2025", "8:00 A.M. MT", address2, "Cloudy");
        
        ReceptionEvent receptionEvent = new ReceptionEvent("Newmann Alumni Gathering", "Gathering of graduates of Newmann University batch 2020",
            "Novemeber 16, 2024", "6:00 P.M. MT", address3, "You are invited");

        Console.WriteLine("Short Description List");
        lectureEvent.ShortDescription();
        outdoorEvent.ShortDescription();
        receptionEvent.ShortDescription();

        Console.WriteLine("\nStandard Details List");
        lectureEvent.StandardDetails();
        outdoorEvent.StandardDetails();
        receptionEvent.StandardDetails();

        Console.WriteLine("\nFull Detail List");
        lectureEvent.FullDetails();
        outdoorEvent.FullDetails();
        receptionEvent.FullDetails();
    }
}