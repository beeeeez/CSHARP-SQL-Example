using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Lab5_CB
{
    public class teacher : buddy
    {
        validateMe validate = new validateMe();
        private string rank;
        private decimal salary;

        private bool jeez;
        private string errorMsg="";

        public teacher(string type, string id, string fname, string lname, string rank, decimal salary) : base(type, id, fname, lname)
        {
            this.Rank = rank;
            this.Salary = salary;


        }//end of construct


        public string Rank
        {
            get { return rank; }
            set
            {
                jeez = validate.stringCheck(value);
                if (jeez == true)
                {
                    rank = value;
                }
                else
                {
                    errorMsg += "\nYou must choose a rank.";
                }

            }


        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                jeez = validate.salCheck(value);
                if (jeez == true)
                {
                    salary = Math.Round(value, 2);
                }
                else
                {
                    errorMsg += "\nThere was a problem with your Salary input.";
                }

            }
        }

        public override string displayMe()
        {
            return base.displayMe() + $"\nRank : {rank}\nSalary : ${salary}";
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
                string selectStatement = "insert into MyBuddies(buddyid, obtype, fname, lname, position, salary)values(@buddyid, @obtype, @fname, @lname, @position, @salary)";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@buddyid", id);
                selectCommand.Parameters.AddWithValue("@obtype", type);
                selectCommand.Parameters.AddWithValue("@fname", fname);
                selectCommand.Parameters.AddWithValue("@lname", lname);
                selectCommand.Parameters.AddWithValue("@position", rank);
                selectCommand.Parameters.AddWithValue("@salary", salary);

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
                string selectStatement = "update mybuddies set buddyid = @buddyid, obtype =@obtype, fname = @fname, lname = @lname, position = @position, salary = @salary,major=null,gpa=null,department=null,hourlyrate=null where buddyid=@oldid";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@buddyid", id);
                selectCommand.Parameters.AddWithValue("@obtype", type);
                selectCommand.Parameters.AddWithValue("@fname", fname);
                selectCommand.Parameters.AddWithValue("@lname", lname);
                selectCommand.Parameters.AddWithValue("@position", rank);
                selectCommand.Parameters.AddWithValue("@salary", salary);
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
