using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal record Dog : Animal
    {
        private string _name;
        private string _breed;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Breed
        {
            get { return _breed; }
            init { _breed = value; }
        }
        public Dog(string name, string breed, string gender):base(gender)
        {
            _breed = breed;
            _name = name;
            Console.WriteLine($"Adi: {name}");
            Console.WriteLine($"Cinsi: {breed}");
        }
    }
}
