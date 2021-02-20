using System;

namespace quiz4
{
    class Firearms
    {
        static void Main(string[] args)
        {
            Weapon s = new Weapon();
            s.shotgun = "Boom";
            s.rifle = "Bang";
            s.pistol = "Pop";
            s.ShootingNoise();
        }
    }

    interface firearms
    {
        void ShootingNoise();
    }

    class Weapon : firearms
    {
        public string shotgun { get; set; }
        public string rifle { get; set; }
        public string pistol { get; set; }

        public void ShootingNoise()
        {
            Console.WriteLine($"I am a shotgun and I go {shotgun}.");
            Console.WriteLine($"I am a rifle and I go {rifle}.");
            Console.WriteLine($"I am a pistol and I go {pistol}.");
        }
    }
}



