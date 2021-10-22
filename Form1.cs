using System;
using System.Windows.Forms;
using Back;


namespace Intec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
	
		private void button1_Click(object sender, EventArgs e)
        {
			if (IDField.Text != "")
			{
				if (PasswordField.Text != "")
				{
					ConnectionToSql.UserModel user = new ConnectionToSql.UserModel();
					var validLogin = user.LoginUser(IDField.Text, PasswordField.Text);
					if (validLogin == true)
					{
						// Show the main form and hide the Login form
						SubjectForm crud = new SubjectForm(); 
						crud.Show();
						this.Hide();
					}
					else
					{
						msgError("ID o contraseña incorrecta. \n Por favor, intente nuevamente!");
						IDField.Clear();
						PasswordField.Focus();
						PasswordField.Clear();
					}
				}
				else msgError("Por favor, ingrese su contraseña.");
			}
			else msgError("Por favor, ingrese su ID.");
		}
		private void msgError(string msg)
		{
			lblErrorMessage.Text = "     " + msg;
			lblErrorMessage.Visible = true;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
