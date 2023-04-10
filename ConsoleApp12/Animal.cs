using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal record Animal
    {
        private string _gender;
        private int _birthdate;
        public int BirthDate
        {
            get
            {
                return _birthdate;
            }
            init { _birthdate = value; }
        }
        public string Gender
        {
            get { return _gender; }
            init { _gender = value; }
        }
        public Animal(string gender)
        {
            _birthdate = DateTime.Now.Year;
            _gender = gender;
            Console.WriteLine($"Dgum Tarixi: {_birthdate}");
            Console.WriteLine($"Cinsi: {_gender}");
        }
    }
}
