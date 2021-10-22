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
using Intec;

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
            string connString = "Server=desktop-91438d4;Database=ProyectoIDS311;Integrated Security = true";
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_Student", sqlConnection);
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
            string add = "INSERT INTO STUDENTS (STUDENTID, SUBJECTID, SUBJECTNAME , CREDITS, GRADE)" + "VALUES("+ idBox.Text + ",'" + CodeBox.Text + "','" + NameBox.Text + "'," + CreditBox.Text + ",'" + notaBox.Text + "')";
            string connString = "Server=desktop-91438d4;Database=ProyectoIDS311;Integrated Security = true";
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
            string connString = "Server=desktop-91438d4;Database=ProyectoIDS311;Integrated Security = true";
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
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string edit = "UPDATE SUBJECT SET NAME='" + ENameBox.Text + "', CREDITS='" + ECreditBox.Text + "' WHERE CODE='" + ECodeBox.Text + "'";
            string connString = "Server=desktop-91438d4;Database=ProyectoIDS311;Integrated Security = true";
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
        private void calcularIndice()
        {
            int sumaCreditos = 0, sumaPuntos = 0, creditos = 0;
            float indice;
            string nota;
            foreach (DataGridViewRow row in dgvSubject.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    creditos = Convert.ToInt32(row.Cells[4].Value.ToString());
                    sumaCreditos += creditos;
                }//suma de creditos

                if (row.Cells[5].Value != null)
                {
                    nota = row.Cells[5].Value.ToString().Trim();
                    switch (nota)
                    {
                        case "A":
                            sumaPuntos += 4 * creditos; 
                            break;
                        case "B":
                            sumaPuntos += 3 * creditos;
                            break;
                        case "C":
                            sumaPuntos += 2 * creditos;
                            break;
                        case "D":
                            sumaPuntos += 1 * creditos;
                            break;
                        case "F":
                            sumaPuntos += 0 * creditos;
                            break;
                    }
                }
            }

            indice = sumaPuntos/ sumaCreditos; 
            labelIndice.Text = indice.ToString();
            if (indice >= 3.8)
            {
                labelHonor.Text = "Summa Cum Laude";
            }
            else if (indice >= 3.5)
            {
                labelHonor.Text = "Magna Cum Laude";
            }
            else if (indice >= 3.2)
            {
                labelHonor.Text = "Cum Laude";
            }
            else
            {
                labelHonor.Text = "Sin Honor";
            }

            //añadir otro label que indique si es summa cum laude y eso (es un if/switch sencillo) 
        }
        private void SubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            calcularIndice();
        }
    }
}
