using System;
using System.Collections.Generic;
using System.Diagnostics;
using StudentConsoleApp;







class Program
{
    static void Main(string[] args)
    {
        StudentDal studentdal = new StudentDal();
        Student student = new Student();

        studentdal.StudentListChanged += () => Console.WriteLine("***************Student list is been changed ! ************************");

        Console.WriteLine("Enter The RollNumber And Name of student to Search in the DataBase !");

        studentdal.SearchStudent();


        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Enter Details of Student to Add into Database : ");
        
         studentdal.AddStudent(student);
          Console.WriteLine("Student Data insert into DataBase Successfully !!");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Enter the Student Rollnumber and Student Name for Updatation !");
        studentdal.UpdateCustomer(student);
        Console.WriteLine("-------------------------------------------------------");
        if (studentdal.RemoveStudent(student))
        {
            Console.WriteLine("Student Data from DataBase Deleted SuccessFully !");
        }
        else { Console.WriteLine("Please Provide Valid Rollnumber of Student "); }

        Console.WriteLine("-----------------------THANK YOU-----------------------------");
        Console.ReadKey();
    }
}