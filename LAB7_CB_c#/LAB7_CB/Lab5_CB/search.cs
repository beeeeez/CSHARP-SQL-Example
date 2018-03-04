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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

                    
        private void unCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            DataSet bung = new DataSet();
            

            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);

            string sqlStr = "Select buddyid, obtype, fname, lname, major, gpa, position, salary, department, hourlyrate FROM mybuddies WHERE 0=0 AND obtype LIKE @obtype";
            

            if(idBox.Text.Length > 0)
            {
                sqlStr += " AND buddyid LIKE @id";
            }

            if (firstBox.Text.Length > 0)
            {
                sqlStr += " AND fname LIKE @fname";
            }

            if (lastBox.Text.Length > 0)
            {
                sqlStr += " AND lname LIKE @lname";
            }

            if (obCo.Text == "Student")
            {
                sqlStr += " AND major LIKE @major";

                if(unBox.Text.Length > 0)
                {
                    decimal junk=99999;
                    Decimal.TryParse(unBox.Text, out junk);
                    sqlStr += " AND gpa LIKE @gpa";
                }


            }

            if (obCo.Text == "Teacher")
            {
                sqlStr += " AND position LIKE @position";

                if (unBox.Text.Length > 0)
                {
                    decimal junk = 99999;
                    Decimal.TryParse(unBox.Text, out junk);
                    sqlStr += " AND salary LIKE @salary";
                }


            }

            if (obCo.Text == "Administrator")
            {
                sqlStr += " AND department LIKE @department";

                if (unBox.Text.Length > 0)
                {
                    decimal junk = 99999;
                    Decimal.TryParse(unBox.Text, out junk);
                    sqlStr += " AND hourlyrate LIKE @hourlyrate";
                }


            }//end of all this nonsense


            SqlCommand commandah = new SqlCommand(sqlStr, connection);

         

            
            SqlDataAdapter dataShmata = new SqlDataAdapter();

            dataShmata.SelectCommand = commandah;


            commandah.Parameters.AddWithValue("@obtype", "%" + obCo.Text + "%");
            commandah.Parameters.AddWithValue("@id", "%" + idBox.Text + "%");
            commandah.Parameters.AddWithValue("@fname", "%" + firstBox.Text + "%");
            commandah.Parameters.AddWithValue("@lname", "%" + lastBox.Text + "%");
            if (obCo.Text == "Student")
            {
                commandah.Parameters.AddWithValue("@major", "%" + unCo.Text + "%");
                decimal junk = 99999;
                Decimal.TryParse(unBox.Text, out junk);
                commandah.Parameters.AddWithValue("@gpa", "%" + junk + "%");

            }
            if (obCo.Text == "Teacher")
            {
                commandah.Parameters.AddWithValue("@position", "%" + unCo.Text + "%");
                decimal junk = 99999;
                Decimal.TryParse(unBox.Text, out junk);
                commandah.Parameters.AddWithValue("@salary", "%" + junk + "%");
            }
            if (obCo.Text == "Administrator")
            {
                commandah.Parameters.AddWithValue("@department", "%" + unCo.Text + "%");
                decimal junk = 99999;
                Decimal.TryParse(unBox.Text, out junk);
                commandah.Parameters.AddWithValue("@hourlyrate", "%" + junk + "%");
            }



            connection.Open();

            //SqlDataReader customerReader = selectCommand.ExecuteReader();
            dataShmata.Fill(bung, "fff");

            connection.Close();



            putStuff.DataSource = bung;
            putStuff.DataMember = bung.Tables["fff"].ToString();



        }

        private void search_Load_1(object sender, EventArgs e)
        {
            obCo.Text = "Student";
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

        private void all_btn_Click(object sender, EventArgs e)
        {
            DataSet bung = new DataSet();


            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);

            string sqlStr = "Select * FROM mybuddies";

            SqlCommand commandah = new SqlCommand(sqlStr, connection);




            SqlDataAdapter dataShmata = new SqlDataAdapter();

            dataShmata.SelectCommand = commandah;
            connection.Open();

            //SqlDataReader customerReader = selectCommand.ExecuteReader();
            dataShmata.Fill(bung, "fff");

            connection.Close();



            putStuff.DataSource = bung;
            putStuff.DataMember = bung.Tables["fff"].ToString();


        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void putStuff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update upTemp = new update(putStuff.Rows[e.RowIndex].Cells[0].Value);
            upTemp.Show();
            this.Close();

        }
    }
}
