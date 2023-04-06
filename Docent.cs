using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Docent : Person
    {
        public bool mentor;
        public int salaris;

        public Docent(bool checkmentor, int Docentsalaris, string Docentname, int DocentAge, int Docentbirthday, int Docentid)
        {
            name = Docentname;
            mentor = checkmentor;
            salaris = Docentsalaris;
            age = DocentAge;
            birthday = Docentbirthday;
            id = Docentid;
        }

         private static void Main(string[] args)
        {
            Docent docentone = new Docent(true, 2999, "Henk", 60, 20081950, 1);
            Docent docenttwo = new Docent(false, 1999, "Sam", 27, 10111988, 2);
            Docent Docentthree = new Docent(false, 999, "Simone", 10, 20082013, 50);



        }

    }
}
