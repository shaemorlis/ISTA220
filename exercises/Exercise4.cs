using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex04
{
    //		********************************************Implementing one class********************************************
    public class AnimalFarm
    {       

        // Default constructor.
        public AnimalFarm()
        {            
        }

        // Instance constructor.
        public AnimalFarm(string name, string voice, string type, string food)
        {
            this.name = name;
            this.voice = voice;
            this.type = type;
            this.food = food;
        }
        
        // Copy constructor.
        public AnimalFarm(AnimalFarm AnimalFarmObject)
        {            
            this.name   = AnimalFarmObject.name;
            this.voice  = AnimalFarmObject.voice;
            this.type   = AnimalFarmObject.type;
            this.food   = AnimalFarmObject.food;
        }

        public virtual string speak()
        {
            string s = "I " + voice;            
            return s;
        }

        public virtual string eat()
        {
            string s = "I eat " + food;            
            return s;
        }

        public void printAnimalInformation()
        {
            string s = "Hello, my name is "+name+", and I am a "+type+".I "+voice+"! and I eat "+food;
            Console.WriteLine(s);
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Voice
        {
            get
            {
                return voice;
            }

            set
            {
                voice = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Food
        {
            get
            {
                return food;
            }

            set
            {
                food = value;
            }
        }

        private string name;
        private string voice;
        private string type;
        private string food;
    }

    public class Horse:  AnimalFarm
    {
        public Horse()
        {

        }
        public override string speak()
        {
            string s = "I Neigh!";
            return s;
        }

        public override string eat()
        {
            string s = "I eat Grass!";
            return s;
        }
    }

    public class Sheep : AnimalFarm
    {
        public Sheep()
        {

        }

        public override string speak()
        {
            string s = "I Bleat!";
            return s;
        }

        public override string eat()
        {
            string s = "I eat Grass!";
            return s;
        }
    }

    public class Cow : AnimalFarm
    {        
        public Cow()
        {

        }

        public override string speak()
        {
            string s = "I Moos!";
            return s;
        }

        public override string eat()
        {
            string s = "I eat Grass and Vegetables!";
            return s;
        }
    }

    public class Goat : AnimalFarm
    {
        public string name;

        public Goat()
        {

        }

        public override string speak()
        {
            string s = "I bleats!";
            return s;
        }

        public override string eat()
        {
            string s = "I eat Grass and Fruits!";
            return s;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //		********************************************Four instances********************************************

            Console.WriteLine("********************************************Four instances********************************************");

            AnimalFarm Pig = new AnimalFarm("Miss Piggy", "Oinks", "Pig", "Vegetables and Fruits");
            Console.WriteLine(Pig.speak());
            Console.WriteLine(Pig.eat());
            Pig.printAnimalInformation();

            AnimalFarm Sheep = new AnimalFarm("Mr. Sh", "Bleats", "Sheep", "Grass");
            Console.WriteLine(Sheep.speak());
            Console.WriteLine(Sheep.eat());
            Sheep.printAnimalInformation();

            AnimalFarm Cow = new AnimalFarm("Miss Cow", "Moos", "Cow", "Grass and Vegetables");
            Console.WriteLine(Cow.speak());
            Console.WriteLine(Cow.eat());
            Cow.printAnimalInformation();

            AnimalFarm Goat = new AnimalFarm("Mr. Go", "Bleats", "Goat", "Grass and Fruits");
            Console.WriteLine(Goat.speak());
            Console.WriteLine(Goat.eat());
            Goat.printAnimalInformation();

            //		********************************************Four classes, Four instances********************************************

            Console.WriteLine("\n\n********************************************Four classes, Four instances********************************************\n");

            Horse horse = new Horse();
            horse.Type = "Horse";
            horse.Name = "Mr. Ed";
            horse.Food = "Grass";
            horse.Voice = "Neigh";
            Console.WriteLine(horse.speak());
            Console.WriteLine(horse.eat());
            horse.printAnimalInformation();

            Sheep sheep = new Sheep();
            sheep.Type = "Sheep";
            sheep.Name = "Mr. Sh";
            sheep.Food = "Grass";
            sheep.Voice = "Bleats";
            Console.WriteLine(sheep.speak());
            Console.WriteLine(sheep.eat());
            sheep.printAnimalInformation();

            Cow cow = new Cow();
            cow.Type = "Cow";
            cow.Name = "Miss Cow";
            cow.Food = "Grass and Vegetables";
            cow.Voice = "Moos";
            Console.WriteLine(cow.speak());
            Console.WriteLine(cow.eat());
            cow.printAnimalInformation();

            Goat goat = new Goat();
            goat.Type = "Goat";
            goat.Name = "Mr. Go";
            goat.Food = "Grass and Fruits";
            goat.Voice = "Bleats";
            Console.WriteLine(goat.speak());
            Console.WriteLine(goat.eat());
            goat.printAnimalInformation();


            Console.ReadLine();
        }
    }
}
