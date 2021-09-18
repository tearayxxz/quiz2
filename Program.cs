using System;
using System.Collections.Generic;

namespace Quiz2
{
    class User1
    {
        public string name;
        private List<Rose> Roses;
        public User1(string valuename)
        {
            name = valuename;
            Roses = new List<Rose>();
        }
            public void addRose(Rose rose)
            {
                Roses.Add(rose);
            }
            public void getRose()
            {
                foreach (Rose rose in Roses)
                {
                Console.WriteLine("ID : {0}", rose.ID);
                Console.WriteLine("Name : {0}", rose.Name);
                Console.WriteLine("Descript : {0}", rose.Descript);
                Console.WriteLine("Amount : {0}", rose.Amount);
                Console.WriteLine("Height : {0}", rose.Height);
                Console.WriteLine("Circumference : {0}", rose.Circumference);
                }
            }
    }
    class User2
    {
        public string name;
        private List<Sunflower> Sunflowers;
        public User2(string valuename)
        {
            name = valuename;
            Sunflowers = new List<Sunflower>();
        }
        public void addSunflower(Sunflower sunflower)
        {
            Sunflowers.Add(sunflower);
        }
        public void getSunflower()
        {
            foreach (Sunflower sunflower in Sunflowers)
            {
                Console.WriteLine("ID : {0}", sunflower.ID);
                Console.WriteLine("Name : {0}", sunflower.Name);
                Console.WriteLine("Descript : {0}", sunflower.Descript);
                Console.WriteLine("Amount : {0}", sunflower.Amount);
                Console.WriteLine("Height : {0}", sunflower.Height);
                Console.WriteLine("Circumference : {0}", sunflower.Circumference);
            }
        }
    }
    class Rose : flower
    {
        public int Amount;
        
        public Rose(int iD, string name, string descript, string height, string circumference) : base(iD, name, descript, height, circumference)
        {
            this.ID = iD;
            this.Name = name;
            this.Descript = descript;
            this.Height = height;
            this.Circumference = circumference;
        }
    }
    class Sunflower : flower
    {
        public int Amount;
        public Sunflower(int iD, string name, string descript, string height, string circumference) : base(iD, name, descript, height, circumference)
        {
            this.ID = iD;
            this.Name = name;
            this.Descript = descript;
            this.Height = height;
            this.Circumference = circumference;
        }
    }
    class flower
    {
        public int ID;
        public string Name;
        public string Descript;
        public string Height;
        public string Circumference;
        public flower(int iD, string name, string descript, string height, string circumference)
        {
            this.ID = iD;
            this.Name = name;
            this.Descript = descript;
            this.Height = height;
            this.Circumference = circumference;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User1 A = new User1("A");
            Rose ดอกกุหลาบสีเขียว = new Rose(
                1,
                "ดอกกุหลาบสีเขียว",
                "สวยงามมาก",
                "10.5",
                "6"
                );
            User2 B = new User2("B");
            Sunflower ดอกทานตะวันเล็ก = new Sunflower(
                1,
                "ดอกทานตะวันเล็ก",
                "สวยงาม",
                "2.0",
                "2.0"
                );
            Console.Write("Input Total Rose: ");
            ดอกกุหลาบสีเขียว.Amount = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sunflower: ");
            ดอกทานตะวันเล็ก.Amount = int.Parse(Console.ReadLine());
            A.addRose(ดอกกุหลาบสีเขียว);
            Console.WriteLine("Input Rose");
            Console.WriteLine("----------");
            Console.WriteLine("");
            A.getRose();
            B.addSunflower(ดอกทานตะวันเล็ก);
            Console.WriteLine("Input Sunflower");
            Console.WriteLine("----------");
            Console.WriteLine("");
            B.getSunflower();
            string Con;
            Console.WriteLine("");
            Console.WriteLine("Please Enter");
            Con = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Roses Information");
            Console.WriteLine("----------");
            Console.WriteLine("Name : {0}", ดอกกุหลาบสีเขียว.Name);
            Console.WriteLine("Name : ดอกกุหลาบสีแดง");
            Console.WriteLine("SunFlowers Information");
            Console.WriteLine("----------");
            Console.WriteLine("Name : {0}", ดอกทานตะวันเล็ก.Name);
            Console.WriteLine("Name : ดอกทานตะวันใหญ่");
        }
    }
}
