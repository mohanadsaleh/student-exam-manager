using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace DatagirdView
{
    public partial class Form1 : Form
    {
        string dbName = "students.db";
        SQLiteConnection con = new SQLiteConnection(@"Data Source = students.db");
        public Form1()
        {
            InitializeComponent();

            CreateDatabas();

            getAllStudent();


        }
        private void CreateDatabas()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "create table exams(id integer primary key, first_name varchar(255) not null, last_name varchar(255) not null, student_id varchar(255) not null, exam varchar(255) not null, grade integer not null)";

                cmd.ExecuteNonQuery();
                MessageBox.Show("veriTabani oluşturdu");
                con.Close();

            }
        }

        private void getAllStudent()
        {
            try
            {
                using (var con = new SQLiteConnection($"Data Source={dbName}"))
                {
                    con.Open();
                    string query = "SELECT id AS 'ID', first_name || ' ' || last_name AS 'Full Name', exam AS 'Exam', grade AS 'Grade' FROM exams";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Add Action Button Column
                    if (!dataGridView1.Columns.Contains("btnDetails"))
                    {
                        DataGridViewButtonColumn bc = new DataGridViewButtonColumn
                        {
                            HeaderText = "Action",
                            Text = "Details",
                            Name = "btnDetails",
                            UseColumnTextForButtonValue = true,
                            Width = 100
                        };
                        dataGridView1.Columns.Add(bc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO exams(first_name,last_name,student_id,exam,grade) VALUES(@first_name,@last_name,@student_id,@exam,@grade)";
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@exam", cmbExamName.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@grade", int.Parse(txtGrade.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("eklendi");
                    getAllStudent();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(e.ColumnIndex + " - " + e.RowIndex);
                if (e.ColumnIndex == 4 && e.RowIndex >= 0)
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    StudentDetailForm frm2 = new StudentDetailForm();
                    frm2.recordID = id;
                    frm2.ShowDialog();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void btnRefrece_Click(object sender, EventArgs e)
        {
            getAllStudent();
        }
    }
}
