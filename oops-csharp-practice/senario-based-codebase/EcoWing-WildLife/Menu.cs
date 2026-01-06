using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EcoWing_WildLife
{
    internal class Menu
    {
        public static Bird[] Entry()
        {
            Bird[] birds = new Bird[5];
            birds[0] = new Eagle("20", new DateTime(2025, 12, 15), "rainforest", "fish", false, 001);
            birds[1] = new Sparrow("0.09", new DateTime(2025, 11, 25), "scrublands", "grains", true, 002);
            birds[2] = new Duck("5", new DateTime(2024, 1, 1), "wetlands", "seeds", false, 003);
            birds[3] = new Penguin("2", new DateTime(2024, 10, 5), "marine", "seafood", true, 004);
            birds[4] = new Seagull("3", new DateTime(2025, 2, 12), "costal", "insects", false, 005);

            return birds;
        }

        public void birdSantury()
        {

            Bird[] bird = Entry();

            for(int i = 0; i < bird.Length; i++)
            {
                bird[i].Display();
                if (bird[i] is IFlyable ff && bird[i] is ISwimable ss)
                {
                    ff.Fly();
                    ss.Swim();
                }
                else if (bird[i] is IFlyable f)
                {
                    f.Fly();
                }
                else if (bird[i] is ISwimable s)
                {
                    s.Swim();
                }
                
                Console.WriteLine();
            }
        }
    }
}
