using System;
using System.Collections.Generic;
using System.Text;

namespace Starbu__
{
    public abstract class CaffeineBeverage
    {
        public virtual void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }
        public abstract void brew();
        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

    }
}
