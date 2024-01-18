using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{

    public delegate void InfowayDelegate(); // define a delegate 


    internal class Student
    {
       

        // defining a event on the basic of delegates 
        public event InfowayDelegate Selected;
        public event InfowayDelegate Rejected ;
        /*public int m_StudentID
        {
            get { return m_StudentID; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Student can not  have negative ID !");
                }
                else
                {
                    m_StudentID = value;
                }
            }
        }*/

        public int  StudentId   { get; set; }
        public  String StudentName { get; set; }
        public  String City { get; set; }
        public  int TotalMarks { get; set; }

        public String CalculateResult(int marks, ref bool confirmation)
        {
            if (marks > 80)
            {
                if (Selected != null)
                {
                    Selected();
                }
                confirmation = true;
                return $"{StudentName} has been passed the interview !";
            }
            else
            {
                if (Rejected != null) { Rejected(); }
                confirmation = false;
                return $"{StudentName} has been failed the interview !";

            }
        }

        public void InterviewRounds(params String[] round)
        {
            for(int i=0; i <round.Length; i++) {
                Console.WriteLine(round[i]);

            }
        }
    }
}
