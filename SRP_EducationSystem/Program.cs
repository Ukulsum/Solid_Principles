using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_EducationSystem
{
    //Testing the Single Responsibility Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Student umme = new Student { Name = "Umme"};
            umme.EnrollCourse("Mathematics");
            umme.AssignGrade("Mathematics", 90);

            GPACalculator gpaCalculate = new GPACalculator();
            TranscriptGenerator transcript = new TranscriptGenerator(gpaCalculate);
            transcript.PrintTranscript(umme);

            Console.ReadKey();
        }
    }
}
