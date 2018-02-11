using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Janek = new Person("Janek", new Dictionary<string, bool>() { { "ekstrawertyk", true }, { "lubi_podroze", true }, { "lubi_koty", true } }, new List<string>() { "azjatycka", "włoska" });

            Person Danuta = new Person("Danuta", new Dictionary<string, bool>() { { "ekstrawertyk", false }, { "lubi_podroze", true }, { "lubi_koty", true } }, new List<string>() { "azjatycka" });
            Person Genowefa = new Person("Genowefa", new Dictionary<string, bool>() { { "ekstrawertyk", true }, { "lubi_koty", true } }, new List<string>() { "azjatycka" });
            Person Janina = new Person("Janina", new Dictionary<string, bool>() { { "ekstrawertyk", true }, { "lubi_podroze", true }, { "lubi_koty", true } }, new List<string>() { "włoska" });
            Person Leontyna = new Person("Leontyna", new Dictionary<string, bool>() { { "ekstrawertyk", true }, { "lubi_koty", true } }, new List<string>() { "japońska", "francuska" });
            List<Person> panie = new List<Person>() { Danuta, Genowefa, Janina, Leontyna };

            foreach (var pani in panie)
            {
                WypiszWynikA(Janek, pani);
            }
            Console.WriteLine();

            foreach (var pani in panie)
            {
                WypiszWynikB(Janek, pani);
            }
            Console.WriteLine();

            foreach (var pani in panie)
            {
                WypiszWynikC(Janek, pani);
            }
           
            Console.ReadLine();
        }

        static void WypiszWynikA(Person person1, Person person2)
        {
            Console.WriteLine(person1.Imie + " && " + person2.Imie + " == " + DopasujA(person1, person2));
        }

        static void WypiszWynikB(Person person1, Person person2)
        {
            Console.WriteLine(person1.Imie + " && " + person2.Imie + " == " + DopasujB(person1, person2));
        }

        static void WypiszWynikC(Person person1, Person person2)
        {
            Console.WriteLine(person1.Imie + " && " + person2.Imie + " == " + DopasujC(person1, person2));
        }

        static bool DopasujA(Person person1, Person person2)
        {
            foreach (var cechaP1 in person1.Cechy)
            {
                if (person2.Cechy.ContainsKey(cechaP1.Key))
                {
                    if (person2.Cechy[cechaP1.Key] != cechaP1.Value)
                    {
                        return false;
                    }
                }

            }
            bool wspolnaKuchnia = false;
            foreach (var kuchniaP1 in person1.Kuchnia)
            {
                foreach (var kuchniaP2 in person2.Kuchnia)
                {
                    if (kuchniaP1 == kuchniaP2)
                    {
                        wspolnaKuchnia = true;
                    }
                }
            }

            return wspolnaKuchnia;
        }

        static bool DopasujB(Person person1, Person person2)
        {
            foreach (var cechaP1 in person1.Cechy)
            {
                if (person2.Cechy.ContainsKey(cechaP1.Key))
                {
                    if (person2.Cechy[cechaP1.Key] != cechaP1.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            bool wspolnaKuchnia = false;
            foreach (var kuchniaP1 in person1.Kuchnia)
            {
                foreach (var kuchniaP2 in person2.Kuchnia)
                {
                    if (kuchniaP1 == kuchniaP2)
                    {
                        wspolnaKuchnia = true;
                    }
                }
            }

            return wspolnaKuchnia;
        }

        static int DopasujC(Person person1, Person person2)
        {
            int dopasowanie = 0;
            foreach (var cechaP1 in person1.Cechy)
            {
                if (person2.Cechy.ContainsKey(cechaP1.Key))
                {
                    if (person2.Cechy[cechaP1.Key] == cechaP1.Value)
                    {
                        dopasowanie++;
                    }
                }

            }
            bool wspolnaKuchnia = false;
            foreach (var kuchniaP1 in person1.Kuchnia)
            {
                foreach (var kuchniaP2 in person2.Kuchnia)
                {
                    if (kuchniaP1 == kuchniaP2)
                    {
                        wspolnaKuchnia = true;
                    }
                }
            }
            if (wspolnaKuchnia)
            {
                dopasowanie++;
            }

            return 100 * dopasowanie / (person1.Cechy.Count + 1);
        }


    }
}
