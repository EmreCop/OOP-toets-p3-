using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public string fav_subject;
        public int highest_grade;
        public Student(string Studentname, string favsub, int Studentage, int Stundentbirthday, int Studengrade, int Studentid)
        {

            name = Studentname;
            fav_subject = favsub;
            age = Studentage;
            birthday = Stundentbirthday;
            highest_grade = Studengrade;
            id = Studentid;
        }
        
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
        }static void Main(string[] args)
        {
            Docent docentone = new Docent(true, 2999, "Henk", 60, 20081950, 1);
            Student studentone = new Student("Emre", "ICT", 20, 10032003, 10, 1);
            Student studenttwo = new Student("Arron", "ICT", 10, 20042010, 9, 2);
            Student studentthree = new Student("Noah", "ICT", 20, 14012007, 8, 3);
            Student studentfour = new Student("Tim", "ICT", 20, 11022005, 7, 4);

        }
        }
}
