using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamS00178556
{
   // private static Random rng = new Random();
    public enum Position { Goalkeeper, Defender, Midfielder, Forward}
    public class Player

    {

        public string FName { get; set; }

        public string Surname { get; set;}

        public Position TypeOfPosition { get; set; }

        public DateTime DateOfBirth { get; set; }

        private int age;

        public int Age
        {
            get
            {
                age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    age--;
                return age;
            }
        }
        
    }
}
