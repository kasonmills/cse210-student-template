using System;

namespace events;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        // event 1
        Address address= new Address("47 W. 8th St", "Albany", "New Hampshire", "USA", "00437");
        string _fullAddress = address.GetAddress();
        Reception reception= new Reception("The White's wedding reception", "4/17/25", "6:00PM", _fullAddress, "We are excited to announce the marriage of Wendy and Bill. They are holding a reception in their honor.", "Please RSVP by 4/10/25");
        reception.DisplayEventInfoBrief();
        // reception.DisplayEventInfoStandard();
        // reception.DisplayEventInfoFull();
        Console.WriteLine("");

        // event 2
        Address address1= new Address("8891 S. 41st", "Patch Line", "Oregon", "Madagascar", "78153");
        string _fullAddress1= address1.GetAddress();
        Outdoor outdoor= new Outdoor("Cook street Neighborhood cook off", "7/18/23", "1:00PM", _fullAddress1, "To all those in the neighborhood near cook street. We are pleased to announce a friendly neighbor hood cook off. This is a potluck style even so please bring some food or a treat to share", "The weather is looking like it will be sunny so bring your sunscreen!");
        // outdoor.DisplayEventInfoBrief();
        outdoor.DisplayEventInfoStandard();
        // outdoor.DisplayEventInfoFull();
        Console.WriteLine("");

        // event 3
        Address address2= new Address("37 temuo way", "North Haven", "Utah", "Latvia", "45873");
        string _fullAddress2= address2.GetAddress();
        Lecture lecture= new Lecture("Solving the disconnect between science and religion", "11/14/21", "9:00AM", _fullAddress2, "Join us for a lecture on the difficulty that people often find to reconcile the sciences and religious belief", "Professor Adam Wright PHD", 500);
        // lecture.DisplayEventInfoBrief();
        // lecture.DisplayEventInfoStandard();
        lecture.DisplayEventInfoFull();
    }
}