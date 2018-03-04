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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void objectTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(obCo.Text == "Student")
            {
                pictureBox1.Image = Lab5_CB.Properties.Resources.ralph4;
                unCo.Items[0] = "Networking";
                unCo.Items[1] = "Software Engineering";
                unCo.Items[2] = "Game Development";
                titleLb.Text = "Major : ";
                unLb.Text = "GPA : ";

            }//end of student selection

            else if (obCo.Text == "Teacher")
            {
                pictureBox1.Image = Lab5_CB.Properties.Resources.edna4;
                unCo.Items[0] = "Professor";
                unCo.Items[1] = "Associate Professor";
                unCo.Items[2] = "Adjunct Faculty";
                titleLb.Text = "Rank : ";
                unLb.Text = "Salary : ";

            }//end of teacher selection

            else if (obCo.Text == "Administrator")
            {
                pictureBox1.Image = Lab5_CB.Properties.Resources.willie4;
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

        private void button1_Click(object sender, EventArgs e)
        {

            //new sql stuffffff
       
           

          /*
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";                  
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "SELECT ProductCode, Description, UnitPrice, OnHandQuantity FROM Products WHERE ProductCode= @ProductCode";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);            
            selectCommand.Parameters.AddWithValue("@ProductCode", productID);            
            connection.Open();            
            SqlDataReader customerReader = selectCommand.ExecuteReader();
            customerReader.Read();
            connection.Close();

    */

            //end of new sql stufffffffffff



            bool fff;
            string errorMsg = "";
            decimal customVal;

            fff = decimal.TryParse(unBox.Text, out customVal);
            if (fff == false)
            {
                customVal = -1;

            }



            if (obCo.Text == "Student")
            {
                student stuOb = new student(obCo.Text, idBox.Text, firstBox.Text, lastBox.Text, unCo.Text, customVal);
                if (errorMsg == "")// had to make these gross looking nested if statements to generate the errorMsg value twice to output SQL exceptions to the user (breaking the unique value restriction on BuddyId)
                {//no i didn't that was dumbbbb
                    stuOb.sendSQL();
                    errorMsg = stuOb.ErrorMsg();
                    if(errorMsg =="") {
                        outLb.Text = stuOb.displayMe() + "\n\nStudent object created successfully!";
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
                if (errorMsg == "")
                {
                    teaOb.sendSQL();
                    errorMsg = teaOb.ErrorMsg();
                    if (errorMsg == "")
                    {
                        outLb.Text = teaOb.displayMe() + "\n\nTeacher object created successfully!";
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
                if (errorMsg == "")
                {
                    admOb.sendSQL();
                    errorMsg = admOb.ErrorMsg();
                    if (errorMsg == "")
                    {
                        outLb.Text = admOb.displayMe() + "\n\nAdministrator object created successfully!";
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



        }

        private void unCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obCo.Text = "Student";



        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search temp = new search();
            temp.Show();
        }
    }
}
