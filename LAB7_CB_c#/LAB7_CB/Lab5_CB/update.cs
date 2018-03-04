using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lab5_CB
{
    public partial class update : Form
    {
        public update(object row)
        {
            InitializeComponent();



           

            string fff = row.ToString();
            oldBox.Text = fff;

            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);

            string selectStatement = "select * from mybuddies where buddyid = @id";
           SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@id", fff);
            connection.Open();
            SqlDataReader blargh = selectCommand.ExecuteReader();
            blargh.Read();

            obCo.Text = blargh["obtype"].ToString();
            idBox.Text = blargh["buddyid"].ToString();
            firstBox.Text = blargh["fname"].ToString();
            lastBox.Text = blargh["lname"].ToString();

            if(obCo.Text == "Student")
            {
                unCo.Text = blargh["major"].ToString();
                unBox.Text = blargh["gpa"].ToString();
            }
            else if(obCo.Text == "Teacher")
            {
                unCo.Text = blargh["position"].ToString();
                unBox.Text = blargh["salary"].ToString(); 
            }
            else
            {
                unCo.Text = blargh["department"].ToString();
                unBox.Text = blargh["hourlyrate"].ToString();
            }
    


            connection.Close();


        }

        private void unCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void obCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (obCo.Text == "Student")
            {
                unCo.Items[0] = "Networking";
                unCo.Items[1] = "Software Engineering";
                unCo.Items[2] = "Game Development";
                titleLb.Text = "Major : ";
                unLb.Text = "GPA : ";

            }//end of student selection

            else if (obCo.Text == "Teacher")
            {
                unCo.Items[0] = "Professor";
                unCo.Items[1] = "Associate Professor";
                unCo.Items[2] = "Adjunct Faculty";
                titleLb.Text = "Rank : ";
                unLb.Text = "Salary : ";

            }//end of teacher selection

            else if (obCo.Text == "Administrator")
            {
                unCo.Items[0] = "Maintenance";
                unCo.Items[1] = "Security";
                unCo.Items[2] = "Cleircal";
                titleLb.Text = "Department : ";
                unLb.Text = "Hourly Rate : ";

            }//end of teacher selection
            else
            {
                obCo.Text = "Student";
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            
            string errorMsg="";
            bool tempHold;
            decimal customVal;

            tempHold = decimal.TryParse(unBox.Text, out customVal);
            if (tempHold == false)
            {
                customVal = -1;

            }



            if (obCo.Text == "Student")
            {
                student stuOb = new student(obCo.Text, idBox.Text, firstBox.Text, lastBox.Text, unCo.Text, customVal);
                errorMsg = stuOb.ErrorMsg();
                if (errorMsg == "")// had to make these gross looking nested if statements to generate the errorMsg value twice to output SQL exceptions to the user (breaking the unique value restriction on BuddyId)
                {
                    stuOb.updateSQL(oldBox.Text);
                    errorMsg = stuOb.ErrorMsg();
                    if (errorMsg == "")
                    {
                        outLb.Text = stuOb.displayMe() + "\n\nStudent object updated successfully!";
                    }
                    else
                    {
                        outLb.Text = errorMsg;
                    }

                }
                else
                {

                    outLb.Text = errorMsg;
                }
            }

            if (obCo.Text == "Teacher")
            {
                teacher teaOb = new teacher(obCo.Text, idBox.Text, firstBox.Text, lastBox.Text, unCo.Text, customVal);
                errorMsg = teaOb.ErrorMsg();
                if (errorMsg == "")
                {
                    teaOb.updateSQL(oldBox.Text);
                    errorMsg = teaOb.ErrorMsg();
                    if (errorMsg == "")
                    {
                        outLb.Text = teaOb.displayMe() + "\n\nTeacher object updated successfully!";
                    }
                    else
                    {
                        outLb.Text = errorMsg;
                    }
                }
                else
                {
                    outLb.Text = errorMsg;
                }
            }

            if (obCo.Text == "Administrator")
            {
                administrator admOb = new administrator(obCo.Text, idBox.Text, firstBox.Text, lastBox.Text, unCo.Text, customVal);
                errorMsg = admOb.ErrorMsg();
                if (errorMsg == "")
                {
                    admOb.updateSQL(oldBox.Text);
                    errorMsg = admOb.ErrorMsg();
                    if (errorMsg == "")
                    {
                        outLb.Text = admOb.displayMe() + "\n\nAdministrator object updated successfully!";
                    }
                    else
                    {
                        outLb.Text = errorMsg;
                    }

                }
                else
                {
                    outLb.Text = errorMsg;
                }

            }


            if (errorMsg == "")
            {
                cancel_btn.Text = "Finish";
                update_btn.Visible = false;

            }



        }






        private void cancel_btn_Click(object sender, EventArgs e)
        {
            search temp = new search();
            temp.Show();
            this.Close();

           
        }

        private void update_Load(object sender, EventArgs e)
        {

        }
    }
}
