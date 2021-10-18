using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            var oSubjectForm = new SubjectForm();
            oSubjectForm.Show();

            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var oStudentForm = new StudentForm();
            oStudentForm.Show();

            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializarFuente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inicializarFuente()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Poppins_Regular.Length;
            byte[] fontdata = Properties.Resources.Poppins_Regular;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            label1.Font = new Font(pfc.Families[0], label1.Font.Size);            
        }
    }
}
