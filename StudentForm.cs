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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            getStudents();
        }
        void getStudents()
        {
            string connString = "Server=DESKTOP-UV4U0E0;Database=INTEC;User Id=intec;Password=intec;";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_student", sqlConnection);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.Parameters.Add("@Seq", SqlDbType.Int).Value = 1;

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvStudent.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbEdit.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO STUDENT (FIRSTNAME,LASTNAME,DAYOFBIRTH)" + "VALUES('" + NameBox.Text + "','" + LastNameBox.Text + "','" + DobBox.Text + "')";
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
                        MessageBox.Show("Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().Name);
                }

                sqlConnection.Close();
                getStudents();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM STUDENT WHERE Seq=" + DSeqBox.Text;
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
                getStudents();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            gbDel.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var oForm1 = new Form1();
            oForm1.Show();

            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gbEdition.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string update = "UPDATE STUDENT SET FIRSTNAME='" + ENameBox.Text+ "', LASTNAME='" + ELastNameBox.Text + "', DayOfBirth='"+ EDobBox.Text +"' WHERE SEQ="+ ESeqBox.Text +"";
            string connString = "Server=DESKTOP-UV4U0E0;Database=INTEC;User Id=intec;Password=intec;";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(update, sqlConnection);
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
                getStudents();
            }
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularIndice_Click(object sender, EventArgs e)
        {
            //obtiene el elemento seleccionado actualmente
            //string a;
            //int rowindex = dgvStudent.CurrentCell.RowIndex;
            //int columnindex = dgvStudent.CurrentCell.ColumnIndex;
            //a = dgvStudent.Rows[rowindex].Cells[columnindex].Value.ToString();
            //label8.Text = a;
            //--------------------------------------------------------

            List<List<string>> itemList = new List<List<string>>();
            List<string> values = new List<string>();
            itemList.Add(values);
            //se necesita  
            
            var row = dgvStudent.CurrentRow;
            for (int i = 0; i<5; i++)
            {
                values.Add(row.Cells[i].Value.ToString());
            }
            //[[1,juan,avila,fecha,bla,bla]]
            label8.Text = itemList[0][1]; //Imprime el elemento que esta en la columa dos de esa fila.
        }

        //private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        //{
        //    string a;
        //    int rowindex = dgvStudent.CurrentCell.RowIndex;
        //    int columnindex = dgvStudent.CurrentCell.ColumnIndex;

        //    a = dgvStudent.Rows[rowindex].Cells[columnindex].Value.ToString();
        //    label8.Text = a;

        //}
   
    }
    
}
