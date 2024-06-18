using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm = new Storm("wind", false, "Zul'rajas");
            
            Pupil p = new ("Mezil-kree", "Icecrown");
            Mage m = new("Gul'dan", "Draenor");
            Archmage a = new ("Nielas Aran", "Stormwind");

            Storm mageStorm = m.CastRainStorm();
            Storm archmageRainStorm = a.CastRainStorm();
            Storm archmageLightningStorm = a.CastLightningStorm();

            Storm[] storms = [storm, mageStorm, archmageRainStorm, archmageLightningStorm];

            foreach (Storm s in storms)
            {
                s.Announce();
            }
        }
    }
}