using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Infoway Interview Applicationn !");

            Student student = new Student();
            // subcribing the event 
            student.Selected += PassedStudents;
            student.Rejected += FailedStudent;
            student.Selected += ExcellentStudents;

            student.StudentId = 101;
            student.StudentName = "Dwarkesh";
            student.City = "Pune";
            student.TotalMarks = 100;

            if (student.TotalMarks <95)
            {
                student.Selected -= ExcellentStudents; 
            }
            bool confirm = false;


            string result = student.CalculateResult(student.TotalMarks, ref confirm);


            Console.WriteLine(result);
            Console.WriteLine(confirm);
            student.InterviewRounds("Round-1");
            student.InterviewRounds("Round-1" ,"Round-2");
            student.InterviewRounds("Round-1" , "Round-2" , "Round-3" , "Round-4");



           Console.ReadKey();   
        }
        private static void PassedStudents()
        {
            Console.WriteLine("Record Stored in Oracle DataBase !");
        }

        private static void FailedStudent()
        {
            Console.WriteLine("Record Stored in MySQL DataBase ! ");
        }

        private static void ExcellentStudents()
        {
            Console.WriteLine("Record Stored in  DB2 DataBase ");
        }
    }
}
