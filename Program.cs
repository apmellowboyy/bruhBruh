using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace pluh
{
    abstract class Anime
    {
        abstract public string Name { get; set; }
        abstract public string Type { get; set; }
        abstract public int Release { get; set; }
        abstract public string Audience { get; set; }
        abstract public string Platform { get; set; }

        public abstract string Describe();
        public string animeDesc()
        {
            return "It was released on " + Release + " and is loved by " + Audience;
        }
    }
    class Program
    {
        class AOT : Anime
        {
            public override string Name { get; set; }
            public override string Type { get; set; }
            public override int Release { get; set; }
            public override string Audience { get; set; }
            public override string Platform { get; set; }

            public AOT()
            {
                Name = "Attack on Titan";
                Type = "Action";
                Release = 2013;
                Audience = "All";
                Platform = "Crunchyroll, Netflix, Hulu";
            }
            public AOT(string name, string type, int release, string audience, string platform)
            {
                Name=name;
                Type=type;
                Release=release;
                Audience=audience;
                Platform=platform;
            }
            public override string Describe()
            {
                return "This Anime is " + Type + " \nand it is called " + Name;
            }
        }

        static void Main(string[] args)
        {
            AOT aOT = new AOT();
            aOT.Name = "Attack on Titan";
            aOT.Type = "Action/Thriller";
            aOT.Release = 2013;
            aOT.Platform ="Crunchyroll, Netflix, Hulu";
            Console.WriteLine(aOT.Describe());
            Console.WriteLine(aOT.animeDesc());

            Console.WriteLine("---------------------");

            AOT demonSlayer = new AOT();
            demonSlayer.Name = "Demon Slayer";
            demonSlayer.Type = "Action";
            demonSlayer.Release = 2019;
            demonSlayer.Platform = "Crunchyroll, Netflix, Hulu";
            demonSlayer.Audience = "All";
            Console.WriteLine(demonSlayer.Describe());
            Console.WriteLine(demonSlayer.animeDesc());

            Console.WriteLine("---------------------");

            AOT trigun = new AOT();
            trigun.Name = "Trigun";
            trigun.Type = "Action/Comedy";
            trigun.Release = 1998;
            trigun.Platform = "Crunchyroll, Netflix, Hulu";
            trigun.Audience = "Males";
            Console.WriteLine(trigun.Describe());
            Console.WriteLine(trigun.animeDesc());

            Console.WriteLine("---------------------");
            AOT chainsawMan = new AOT();
            chainsawMan.Name = "Chainsaw Man";
            chainsawMan.Type = "Action/drama";
            chainsawMan.Release = 2022;
            chainsawMan.Platform = "Crunchyroll, Hulu";
            chainsawMan.Audience = "Males";
            Console.WriteLine(chainsawMan.Describe());
            Console.WriteLine(chainsawMan.animeDesc());

            Console.WriteLine("---------------------");
            AOT jojos = new AOT();
            jojos.Name = "Jojo's Bizarre Adventure";
            jojos.Type = "Adventure/Supernatural";
            jojos.Release = 1993;
            jojos.Platform = "Crunchyroll, Netflix";
            jojos.Audience = "Females";
            Console.WriteLine(jojos.Describe());
            Console.WriteLine(jojos.animeDesc());
        }
    }
}
