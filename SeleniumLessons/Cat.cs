using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLessons
{
    class Cat
    {
        string name;
        string poroda;
        string color;
        public Cat()
        {
            name = "Dasha";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        public Cat(string name,string poroda,string color)
        {
            this.name = name;
            this.poroda = poroda;
            this.color = color;
        }

        public void Rename(string name)
        {
            this.name = name;
        }
    }
}
