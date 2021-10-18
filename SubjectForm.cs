using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intec
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            getSubjects();
        }

        void getSubjects()
        {
            string connString = "Server=DESKTOP-UV4U0E0;Database=INTEC;User Id=intec;Password=intec;";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_subjects", sqlConnection);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.Parameters.Add("@Seq", SqlDbType.Int).Value = 1;

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSubject.DataSource = dt;
                sqlConnection.Close();
            } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbEdit.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO SUBJECT (NAME,CODE,CREDITS)" + "VALUES('"+ NameBox.Text + "','" + CodeBox.Text + "','" + CreditBox.Text + "')";
            string connString = "Server=DESKTOP-UV4U0E0;Database=INTEC;User Id=intec;Password=intec;";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(add, sqlConnection);
                cmd.CommandType = CommandType.Text;
                sqlConnection.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Añadido Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error: Dato no encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().Name);
                }

                sqlConnection.Close();
                getSubjects();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM SUBJECT WHERE Code=" + "'" + DCodeBox.Text + "'";
            string connString = "Server=DESKTOP-UV4U0E0;Database=INTEC;User Id=intec;Password=intec;";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(delete, sqlConnection);
                cmd.CommandType = CommandType.Text;
                sqlConnection.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Eliminado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error: Dato no encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().Name);
                }
                sqlConnection.Close();
                getSubjects();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var oForm1 = new Form1();
            oForm1.Show();

            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string edit = "UPDATE SUBJECT SET NAME='" + ENameBox.Text + "', CREDITS='" + ECreditBox.Text + "' WHERE CODE='" + ECodeBox.Text + "'";
            string connString = "Server=DESKTOP-UV4U0E0;Database=INTEC;User Id=intec;Password=intec;";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(edit, sqlConnection);
                cmd.CommandType = CommandType.Text;
                sqlConnection.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Editado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error: Dato no encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().Name);
                }

                sqlConnection.Close();
                getSubjects();
            }
        }

        private void SubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
