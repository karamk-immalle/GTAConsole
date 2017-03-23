using GtaConsole;
using GTAConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Voertuig truck = new Vrachtwagen();
            Voertuig car = new Auto();

            Persoon p = new Persoon();
            Console.WriteLine("Wat is uw naam?");
            p.Naam = Console.ReadLine();

            v.Bestuurder = p;

            v.Rij();
            truck.Rij();
            car.Rij();     
        }
    }

    class Persoon
    {
        public string Naam { get; set; }
    }

    class Voertuig
    {
        private ConsoleColor kleur;

        public Persoon Bestuurder { get; set; }

        public Voertuig(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }


        public virtual void Rij()
        {
            Console.WriteLine("Het voertuig rijdt..., en wordt bestuurd door {0}", Bestuurder.Naam);
        }

        public virtual void Stuur(int graden)
        {
            Console.WriteLine("");
        }
    }

    class Auto : Voertuig
    {
        public Auto() : base(ConsoleColor.DarkYellow)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De auto rijdt...", ConsoleColor.Red);            
        }
    }

    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen()
            : base(ConsoleColor.Green)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De vrachtwagen rijdt...", ConsoleColor.Yellow);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De vrachtwagenchauffeur kijkt in zijn dode-hoek-spiegel");
            base.Stuur(graden);
        }

        public void LaadLeeg()
        {
        }
    }

    class Brommer : Voertuig
    {
        public Brommer() : base(ConsoleColor.DarkBlue)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De Brommer rijdt...", ConsoleColor.DarkCyan);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("");
            base.Stuur(graden);
        }
    }

}
