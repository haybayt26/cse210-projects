using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Video karaoke = new Video("Singing in the rain!", "haybayt26", 4);
        // karaoke.AddComment(new Comment("March 2, 2000", "SmirkyAmoeba63", "Wow girl you are killin it!!"));
        // karaoke.AddComment(new Comment("April 30, 1997", "YamGirl89", "Way to crank the high notes, you got this!"));
        // karaoke.AddComment(new Comment("October 27, 2025", "LightHal1330", "I love this song, it's fun to jam with you!"));

        Order o1 = new Order(new Customer("Haley Light", new Address("852 W 1560 N", "Orem", "UT", "USA")));
        o1.AddProduct(new Product("Shampoo", "SP001", 10.56, 2));
        o1.AddProduct(new Product("Conditioner", "CD002", 11.26, 2));
        o1.AddProduct(new Product("Face Wash", "FW003", 8.21, 1));


        Order o2 = new Order(new Customer("Elixera Labs", new Address("742 Maple Ridge Avenue", "Victoria", "BC", "Canada")));
        o2.AddProduct(new Product("Razor", "RZ004", 2.50, 4));
        o2.AddProduct(new Product("Bar Soap", "BS005", 4.75, 3));
        o2.AddProduct(new Product("Lotion", "LT006", 6.59, 1));

        Console.WriteLine();
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine(o1.GetPackingLabel());

        Console.WriteLine();
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine(o2.GetPackingLabel());


    }
}