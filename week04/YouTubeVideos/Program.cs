using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        
        Video karaoke = new Video("Singing in the rain!", "haybayt26", 4);
        karaoke.AddComment(new Comment("March 2, 2000", "SmirkyAmoeba63", "Wow girl you are killin it!!"));
        karaoke.AddComment(new Comment("April 30, 1997", "YamGirl89", "Way to crank the high notes, you got this!"));
        karaoke.AddComment(new Comment("October 27, 2025", "LightHal1330", "I love this song, it's fun to jam with you!"));

        Video adventuring = new Video("All Around the World", "YamGirl89", 10);
        adventuring.AddComment(new Comment("August 9, 1980", "haybayt26", "What was your favorite place to adventure in?"));
        adventuring.AddComment(new Comment("February 18, 2004", "BestestAmigo", "The forest is such a vibe. What kinds of trees are those?"));
        adventuring.AddComment(new Comment("December 3, 2002", "LightHal1330", "What is your favorite peice of gear to backpack with?"));

        Video inspiration = new Video("My Favorite Things", "SmirkyAmoeba", 6);
        inspiration.AddComment(new Comment("February 10, 2026", "haybayt26", "It is so cool that everything you own is pink"));
        inspiration.AddComment(new Comment("January 17, 2000", "YamGirl89", "John 7:17 is such a great verse! Thanks for sharing!"));
        inspiration.AddComment(new Comment("July 30, 2025", "BestestAmigo", "Why is chicken your favorite meat?"));

        Console.WriteLine("\n");
        Console.WriteLine(karaoke.GetVideoContent());
        Console.WriteLine(adventuring.GetVideoContent());
        Console.WriteLine(inspiration.GetVideoContent());


    }


}