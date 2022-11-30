using System;

namespace AspIT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello();
            //Trylleri();
            //Historie();
            //Lærer();
            //Digt();
            //Taxa();
            //Converting();
            //Hobby();
            //Meth();
            //Sko();
            BMI();
        }

        static void Hello()
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Simsalabim");
        }
        static void Trylleri()
        {
            Console.WriteLine("hokus pokus");     
        }
        static void Historie()
        {
            Console.Write("Dig og mig og vi");
            Console.WriteLine(" to sejled i en træsko");
            Console.WriteLine("Da vi kom til Langeland var vor træskoe fuld a vand.");
        }
        static void Lærer()
        {
            Console.WriteLine("Hvem er den bedste lærer? ");
            string lærer;
            lærer = Console.ReadLine();
            Console.WriteLine(lærer + " er den bedste lærer.");
            Console.ReadLine();
        }

        static void Digt()
        {
            Console.Write("Indtast navneord: ");
            string navneord = Console.ReadLine();
            Console.Write("Indtast udsagnsord i nutid: ");
            string udsagnsord = Console.ReadLine();
            Console.Write("Indtast tillægsord i flertal [f.eks. smukke]: ");
            string tillægsord = Console.ReadLine();
            Console.Write("Indtast Navneord: ");
            string navneord2 = Console.ReadLine();
            Console.WriteLine($"Masser af {navneord}");
            Console.WriteLine($"Og det der {udsagnsord} til");
            Console.WriteLine($"Masser af {tillægsord} spotlights");
            Console.WriteLine($"Privatliv og {navneord2}");
        }
        static void Taxa()
        {
            Console.Write("Indtast antal kilometer: ");
            int tal = int.Parse(Console.ReadLine());
            //Console.Write("Det koster " + tal *9 +29);
            Console.WriteLine($"Din pris er: {tal * 9 + 29}");
        }
        static void Converting()
        {
            Console.Write("indtast tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("indtast tal2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2} ");
        }
        static void Hobby()
        {
            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.Write("Indtast alder: ");
            int alder = int.Parse(Console.ReadLine());
            Console.Write("Indtast hobby: ");
            string hobby = Console.ReadLine();
            Console.Write("Indtast antal år du har haft hobby: ");
            int haft = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hej {navn}. Din hobby er {hobby}. Den har du haft siden {2022 - haft} i en alder af {alder - haft}.");
        }
        static void Meth()
        {
            Console.Write("indtast tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("indtast tal2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("9 + 10 = 21");
        }
        static void Sko()
        {
            Console.Write("Indtast skostørrelse: ");
            int skostørrelse = int.Parse(Console.ReadLine());
            if (skostørrelse > 45)
            {
                Console.WriteLine("Store plader.");
            }
            else if (skostørrelse >= 38)
            {
                Console.WriteLine("Gennemsnitlige fødder.");
            }
            else
            {
                Console.WriteLine("Små fødder.");
            }
        }   
        static void BMI()
        {
            Console.Write("Indtast din højde i meter: ");
            int højde = int.Parse(Console.ReadLine());
            Console.Write("Indtast din vægt i kilo: ");
            int vægt = int.Parse(Console.ReadLine());
            Console.Write("Indtast køn M/K: ");
            int køn = int.Parse(Console.ReadLine());
            int BMI;
            string vægtig = "";
            BMI = vægt / (højde * højde);
            Console.Write($"Du har en BMI på {BMI}");
            Console.Write(", det betyder at du ");
            if (BMI < 18.5)
            {
                vægtig = "undervægtig";
                Console.WriteLine($"er undervægtig.");
            }
            else if (BMI < 25)
            {
                vægtig = "normal vægtig";
            }
            else if (BMI < 30)
            {
                vægtig = "overvægtig";
            }
            else i9f
            {
                vægtig = "meget overvægtig";
            }
            else if (køn = M)
            {

            }

            Console.WriteLine($"er {vægtig}.");

        }
    }
}
