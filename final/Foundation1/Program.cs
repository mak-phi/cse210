using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //Show emoji characters: https://stackoverflow.com/questions/67508469/how-to-show-emoji-in-c-sharp-console-output

        List<Video> myVideos = new List<Video>();
        
        Video v1 = new Video("ULTIMATE Beginner's Guide to Game Development (2022)", "Tactical Programmer", 1530);
        Comment c1 = new Comment("@anispinner", "I like how you packed 700 tips and tricks into just 2. Very efficient.");
        v1.AddComment(c1);
        Comment c2 = new Comment("@davidpasion2509", "This video was impeccably written (though I've only watched about 8 mins as of now). A bit of consistency will go a long way and you'll be helping a lot more people. Thanks for the video!");
        v1.AddComment(c2);
        Comment c3 = new Comment("@mooishiiart", "i wanted to try making  diner dash clone out of nostalgia for older flash games lol. it seems like it would be a very easy first game, and since im more of an artist and not really a programmer (although im trying to learn) i can make art the most appealing part of it. this video helped a lot! thanks (:");
        v1.AddComment(c3);
        Comment c4 = new Comment("@niravkansara776", "Exact video I was looking for and very informative mate. Need more positive people like you, Keep up");
        v1.AddComment(c4);
        myVideos.Add(v1);

        Video v2 = new Video("Cleanup time for the JUNKYARD Ranchero", "Speed Bump Garage", 712);
        c1 = new Comment("@jordangabriel2323", "This kid is proof that there are still a few amazing dads out there!");
        v2.AddComment(c1);
        c2 = new Comment("@jeankitten3685", "Why do I like this kid so much ?! He’s so bright and skilled that makes you get a spot in anyone’s heart . Keep it up Jack .");
        v2.AddComment(c2);
        c3 = new Comment("@amberbradley1104", "Mom and dad are doing a amazing job raising this young man.");
        v2.AddComment(c3);
        myVideos.Add(v2);

        Video v3 = new Video("ILLEGAL Street Racing tournament Round One, Races 6 &7 Hot Wheels", "BoyRacerBen", 311);
        c1 = new Comment("@jordangabriel2323", "Where did you get those road mats? They look great");
        v3.AddComment(c1);
        c2 = new Comment("@YenCrew", "That Jetta win. That was one of the cleanest wins yet 👌");
        v3.AddComment(c2);
        c3 = new Comment("@the_train_master", "I like how the r35 launched a police officer into the back doors of the ambulance like: yo, you need to GO to the hospital 😂");
        v3.AddComment(c3);
        myVideos.Add(v3);

        foreach(Video video in myVideos)
        {
            Console.WriteLine($"\n\"{video.GetTitle()}\" (Duration: {video.GetLength()} seconds)");
            Console.WriteLine($"By: {video.GetAuthor()}");
            // Console.WriteLine($"Duration: {video.GetLength()}");
            Console.WriteLine($"\n{video.CountComments()} Comments");
            video.DsiplayComments();
            Console.WriteLine("-------");
        }

    }
}