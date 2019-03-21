using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            reverseChar tempReverseChar = new reverseChar();
            char[] toReverse = { 'c', 'b', 'a' };
            tempReverseChar.ReverseCharacters(toReverse);
            for (int i = 0; i <= toReverse.Length - 1; i++)
            {
                Console.WriteLine(toReverse[i].ToString());
            }

               Course course = (new Course(310, "CIS", 3.5);
               Console.WriteLine(course.ToString());
               
        }

     

        
    }

    public class reverseChar
    {
          public reverseChar()
          {

          }

        public void ReverseCharacters(char[] toReverse)
        {
            int right = toReverse.Length - 1;

            for (int left = 0; left <= right; left++, right--)
            {
                char temp = toReverse[left];
                toReverse[left] = toReverse[right];
                toReverse[right] = temp;
            }
        }
    }

     public class Course
     {
          public int Number { get; private set; }
          public string Title { get; private set; }
          public double Credits { get; private set; }

          public Course()
          {
               Number = 297;
               Title = "CIS";
               Credits = 4.0;
          }

          public Course(int tempNum, string tempTitle, double tempCredits)
          {
               Number = tempNum;
               Title = tempTitle;
               Credits = tempCredits;
          }

          public override string ToString()
          {
               return "Course: " + Title + " " + Number + "\nCredits: " + Credits;
          }


          public class Seminar : Course
          {
               public string guestLecturer { get; private set; }

               public override string ToString()
               {
                    return "Course: " + Title + " " + Number + "\nCredits: " + Credits + "\nGuest Lecturer: " + guestLecturer;
               }
          } 
          

     }


     interface ILuckyNumber
     {
          int GetLuckyNumber();
     }


     public class LuckyNumber : ILuckyNumber
     {
          public int GetLuckyNumber()
          {
               Random random = new Random();
               return random.Next(1, 100);

          }
     }
}
