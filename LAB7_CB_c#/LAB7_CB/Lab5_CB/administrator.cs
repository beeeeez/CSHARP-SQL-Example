using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Lab5_CB
{
     public class administrator : buddy
    {
        validateMe validate = new validateMe();
        private string department;
        private decimal hourly;

        private bool jeez;
        private string errorMsg="";


        public administrator(string type, string id, string fname, string lname, string department, decimal hourly) : base(type, id, fname, lname)
        {
            this.Department = department;
            this.Hourly = hourly;


        }//end of construct


        public string Department
        {
            get { return department; }
            set
            {
                jeez = validate.stringCheck(value);
                if (jeez == true)
                {
                    department = value;
                }
                else
                {
                    errorMsg += "\nYou must choose a department.";
                }

            }


        }

        public decimal Hourly
        {
            get { return hourly; }
            set
            {
                jeez = validate.hourlyCheck(value);
                if (jeez == true)
                {
                   hourly = Math.Round(value, 2);
                }
                else
                {
                    errorMsg += "\nThere was a problem with your Hourly Rate input.";
                }

            }
        }

        public override string displayMe()
        {
            return base.displayMe() + $"\nDepartment : {department}\nHourly Rate : ${hourly}";
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
                string selectStatement = "insert into MyBuddies(buddyid, obtype, fname, lname, department, hourlyrate)values(@buddyid, @obtype, @fname, @lname, @department, @hourlyrate)";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@buddyid", id);
                selectCommand.Parameters.AddWithValue("@obtype", type);
                selectCommand.Parameters.AddWithValue("@fname", fname);
                selectCommand.Parameters.AddWithValue("@lname", lname);
                selectCommand.Parameters.AddWithValue("@department", department);
                selectCommand.Parameters.AddWithValue("@hourlyrate", hourly);

                connection.Open();
                SqlDataReader customerReader = selectCommand.ExecuteReader();
                customerReader.Read();
                connection.Close();
            }//end of try 
            catch (SqlException ex)
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
                string selectStatement = "update mybuddies set buddyid = @buddyid, obtype =@obtype, fname = @fname, lname = @lname, department = @department, hourlyrate = @hourlyrate,major=null,gpa=null,position=null,salary=null where buddyid=@oldid";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@buddyid", id);
                selectCommand.Parameters.AddWithValue("@obtype", type);
                selectCommand.Parameters.AddWithValue("@fname", fname);
                selectCommand.Parameters.AddWithValue("@lname", lname);
                selectCommand.Parameters.AddWithValue("@department", department);
                selectCommand.Parameters.AddWithValue("@hourlyrate", hourly);
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
