using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab5_CB
{
    public class student : buddy
    {
        validateMe validate = new validateMe();
        public string major;
        public decimal gpa;

        private bool jeez;
        public string errorMsg="";

        public student(string type, string id, string fname, string lname, string major, decimal gpa) : base(type, id, fname, lname)
        {
            this.Major = major;
            this.Gpa = gpa;

            
        }//end of construct


        public string Major
        {
            get { return major; }
            set
            {
                jeez = validate.stringCheck(value);
                if (jeez == true)
                {
                    major = value;
                }
                else
                {
                    errorMsg += "\nYou must choose a major.";
                }

            }


        }

        public decimal Gpa
        {
            get { return gpa; }
            set
            {
                jeez = validate.gpaCheck(value);
                if (jeez == true)
                {
                    gpa = Math.Round(value,2);
                }
                else
                {
                    errorMsg += "\nThere was a problem with your GPA input.";
                }

            }
        }

        public override string displayMe()
        {
            return base.displayMe() + $"\nMajor : {major}\nG.P.A. : {gpa}";
        }

        public override string ErrorMsg()
        {
            return base.ErrorMsg() + errorMsg;
        }

        public void sendSQL()
        {
            try
            {
                string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
                SqlConnection connection = new SqlConnection(connString);
                string selectStatement = "insert into MyBuddies(buddyid, obtype, fname, lname, major, gpa)values(@buddyid, @obtype, @fname, @lname, @major, @gpa)";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@buddyid", id);
                selectCommand.Parameters.AddWithValue("@obtype", type);
                selectCommand.Parameters.AddWithValue("@fname", fname);
                selectCommand.Parameters.AddWithValue("@lname", lname);
                selectCommand.Parameters.AddWithValue("@major", major);
                selectCommand.Parameters.AddWithValue("@gpa", gpa);

                connection.Open();
                SqlDataReader customerReader = selectCommand.ExecuteReader();
                customerReader.Read();
                connection.Close();
            }//end of try
            catch(SqlException ex)//had to think about thissssssss
            {
        
                    errorMsg += "\nYour ID must be unique in the database, darlin'.";
                


            }//end of 1st catch

            
        }

        public void updateSQL(string oldid)
        {
            try
            {
                int oldidint;
                bool fool = Int32.TryParse(oldid, out oldidint);
                string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
                SqlConnection connection = new SqlConnection(connString);
                string selectStatement = "update mybuddies set buddyid = @buddyid, obtype =@obtype, fname = @fname, lname = @lname, major = @major, gpa = @gpa, department=null, position=null,salary=null,hourlyrate=null where buddyid=@oldid";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@buddyid", id);
                selectCommand.Parameters.AddWithValue("@obtype", type);
                selectCommand.Parameters.AddWithValue("@fname", fname);
                selectCommand.Parameters.AddWithValue("@lname", lname);
                selectCommand.Parameters.AddWithValue("@major", major);
                selectCommand.Parameters.AddWithValue("@gpa", gpa);
                selectCommand.Parameters.AddWithValue("@oldid", oldidint);
                connection.Open();
                SqlDataReader customerReader = selectCommand.ExecuteReader();
                customerReader.Read();
                connection.Close();
            }

            catch (SqlException ex)
            {

                errorMsg += "\nYour ID must be unique in the database, darlin'.";



            }//end of 1st catch
        }



        }
}
