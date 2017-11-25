using System;

namespace PersonsAgeGeekout
{
    class Program
    {
        /// <summary>
        /// Calculates a persons age
        /// StackOverflow question: https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c        
        /// Lots of different answers and the accepted answer gets a lot of bad press so have used...
        /// Taken from the StackOverflow answer: https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c/229#229
        /// </summary>
        static void Main(string[] args)
        {
            DateTime birthdate = DateTime.Parse("2000-01-01");

            int age = GetAge(birthdate);

            Console.WriteLine(age);
        }

        static int GetAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if(now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}
