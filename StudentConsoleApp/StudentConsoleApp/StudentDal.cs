using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Specialized;



namespace StudentConsoleApp
{
    public class StudentDal
    {


        // Event declaration
        public event Action StudentListChanged;
        public void  SearchStudent()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand("Select * from student where Rollnumber = @P_RollNumber and name = @P_name ", CN))
                {
                    Console.WriteLine("Enter Student RollNumber :");
                    int P_Rollnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Name :");
                    string P_name = Console.ReadLine();
                    CMD.Parameters.AddWithValue("@P_RollNumber", P_Rollnumber);
                    CMD.Parameters.AddWithValue("@P_name", P_name);
                    CN.Open();
                    //CMD.Connection = CN;
                    //   CMD.CommandType = CommandType.StoredProcedure;
                    //  CMD.CommandText = "GetAllStudent";
                    MySqlDataReader DR = CMD.ExecuteReader();
                  //  List<Student> Students = new List<Student>();
                  Student student = new Student();  
                    while (DR.Read())
                    {
                       
                        {
                            student.Rollnumber = Convert.ToInt32(DR["Rollnumber"]);
                            student.name = Convert.ToString(DR["name"]);
                            student.dateofbirth = Convert.ToString(DR["dateofbirth"]);
                            student.fees = Convert.ToDouble(DR["fees"]);
                            student.email_id = Convert.ToString(DR["email_id"]);
                           

                        };
                    }

                    DR.Close();
                    CN.Close();

                    Console.WriteLine($"Student name : {student.name}");
                    Console.WriteLine($"Student DOB : {student.dateofbirth}");
                    Console.WriteLine($"Student course Fees : {student.fees}");
                    Console.WriteLine($"Student Email_ID : {student.email_id}");

                }

            }


        }


        public void AddStudent(Student student)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand("INSERT INTO student(Rollnumber, name, dateofbirth, fees, email_id ,course)   VALUES (@P_Rollnumber, @P_name, @P_dateofbirth, @P_fees, @P_email_id, @P_course);", CN))
                {
                    CN.Open();
                  

                    Console.WriteLine("Enter Student RollNumber :");
                    int P_Rollnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Name :");
                    string P_name = Console.ReadLine();
                    Console.WriteLine("Enter Student DOB :");
                    string P_dateofbirth = Console.ReadLine();
                    Console.WriteLine( "Enter Student Course Fees :");
                    Double P_fees = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Email_ID :");
                    string P_email_id = Console.ReadLine();
                    Console.WriteLine("1.DAC , 2.DMC , 3.DVSLI , 4.DESD ,5.DACA , 6.DSSD , 7.DBDA");
                    Console.WriteLine("Enter Choice for Course :");
                    String P_course = Console.ReadLine();   




                    CMD.Parameters.AddWithValue("@P_Rollnumber", P_Rollnumber);
                    CMD.Parameters.AddWithValue("@P_name", P_name);
                    CMD.Parameters.AddWithValue("@P_dateofbirth", P_dateofbirth);
                    CMD.Parameters.AddWithValue("@P_fees", P_fees);
                    CMD.Parameters.AddWithValue("@P_email_id", P_email_id);
                    CMD.Parameters.AddWithValue("@P_course", P_course);


                    int result = CMD.ExecuteNonQuery();

                    OnStudentListChanged();
                    CN.Close();
                    //  return result;



                    // Event firing method
                   


                }
            }

          
        }

        public void UpdateCustomer(Student student)
        {

            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand("UPDATE student SET Name = @P_name, dateofbirth = @P_dateofbirth, fees = @P_fees, fees = @P_Fees, email_id = @P_email_id  WHERE Rollnumber = @P_Rollnumber ;", CN ))
                {
                    CN.Open();

                    StudentDal studentDal = new StudentDal();
                    studentDal.SearchStudent();


                    Console.WriteLine("Enter Student updated RollNumber :");
                    int P_Rollnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student udated Name :");
                    string P_name = Console.ReadLine();
                    Console.WriteLine("Enter Student updated DOB :");
                    string P_dateofbirth = Console.ReadLine();
                    Console.WriteLine("Enter Student updated Course Fees :");
                    Double P_fees = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student updated Email_ID :");
                    string P_email_id = Console.ReadLine();


                    CMD.Parameters.AddWithValue("@P_Rollnumber", P_Rollnumber);
                    CMD.Parameters.AddWithValue("@P_name", P_name);
                    CMD.Parameters.AddWithValue("@P_dateofbirth", P_dateofbirth);
                    CMD.Parameters.AddWithValue("@P_fees", P_fees);
                    CMD.Parameters.AddWithValue("@P_email_id", P_email_id);

                    Console.WriteLine("Student Data Updated Successfully into DataBase!!");

                    int result = CMD.ExecuteNonQuery();

                    CN.Close();
                }
            }

        }

        public bool RemoveStudent(Student student)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand(" DELETE FROM Student WHERE Rollnumber = @P_Rollnumber ;", CN))
                {
                    CN.Open();
                    Console.WriteLine("Enter The Student RollNumber Which You Want to Delete : ");
                    int P_RollNumber = int.Parse(Console.ReadLine());
                    CMD.Parameters.AddWithValue("@P_Rollnumber", P_RollNumber);
                    int result = CMD.ExecuteNonQuery();
                    OnStudentListChanged();
                    CN.Close();
                    return true;
                }
            }

        }

        // Helper method to raise the event
        protected virtual void OnStudentListChanged()
        {
            StudentListChanged?.Invoke();
        }


    }
}
