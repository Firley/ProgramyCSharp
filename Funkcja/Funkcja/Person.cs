
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcja
{
    class Person
    {
        public string Imie;
        public Dictionary<string,bool> Cechy;
        public List<string> Kuchnia;
        public Person( string imie, Dictionary<string, bool> cechy, List<string> kuchnia)
        {
            Imie = imie;
            Cechy = cechy;
            Kuchnia = kuchnia;
        }
    }
}
