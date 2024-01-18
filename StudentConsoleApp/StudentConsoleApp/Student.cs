using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{

    public enum Course
    {
        DAC,
        DMC,
        DVLSI,
        DESD,
        DACA,
        DSSD,
        DBDA
    }
    public class Student
    {
        public  int Rollnumber { get; set; }
        public  string name { get; set; }

        public string dateofbirth  { get; set; }

        public double fees { get; set; }

        public string email_id { get; set; }

        public Course course { get; set; }

        public Student()
        {
            
        }

        public Student(int rollnumber, string name, string dateofbirth, double fees, string email_id, Course course)
        {
            Rollnumber = rollnumber;
            this.name = name;
            this.dateofbirth = dateofbirth;
            this.fees = fees;
            this.email_id = email_id;
            this.course = course;
        }


    }


    
}
