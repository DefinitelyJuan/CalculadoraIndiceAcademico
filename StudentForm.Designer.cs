
namespace Intec
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.DobBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDel = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DSeqBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbEdition = new System.Windows.Forms.GroupBox();
            this.ESeqBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EDobBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.ELastNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ENameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCalcularIndice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.gbDel.SuspendLayout();
            this.gbEdition.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(34, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(436, 391);
            this.dgvStudent.TabIndex = 0;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.DobBox);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.button4);
            this.gbEdit.Controls.Add(this.btnSave);
            this.gbEdit.Controls.Add(this.LastNameBox);
            this.gbEdit.Controls.Add(this.ApellidoLabel);
            this.gbEdit.Controls.Add(this.NameBox);
            this.gbEdit.Controls.Add(this.label3);
            this.gbEdit.Enabled = false;
            this.gbEdit.Location = new System.Drawing.Point(547, 12);
            this.gbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.gbEdit.Size = new System.Drawing.Size(205, 133);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edition Panel";
            // 
            // DobBox
            // 
            this.DobBox.Location = new System.Drawing.Point(14, 91);
            this.DobBox.Margin = new System.Windows.Forms.Padding(2);
            this.DobBox.Name = "DobBox";
            this.DobBox.Size = new System.Drawing.Size(76, 20);
            this.DobBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(227)))), ((int)(((byte)(84)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(118, 90);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 21);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(117, 39);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(76, 20);
            this.LastNameBox.TabIndex = 3;
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoLabel.Location = new System.Drawing.Point(115, 23);
            this.ApellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(51, 15);
            this.ApellidoLabel.TabIndex = 2;
            this.ApellidoLabel.Text = "Apellido";
            this.ApellidoLabel.Click += new System.EventHandler(this.ApellidoLabel_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(14, 39);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(76, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbDel
            // 
            this.gbDel.Controls.Add(this.btnDelete);
            this.gbDel.Controls.Add(this.DSeqBox);
            this.gbDel.Controls.Add(this.label1);
            this.gbDel.Enabled = false;
            this.gbDel.Location = new System.Drawing.Point(547, 160);
            this.gbDel.Name = "gbDel";
            this.gbDel.Size = new System.Drawing.Size(202, 83);
            this.gbDel.TabIndex = 8;
            this.gbDel.TabStop = false;
            this.gbDel.Text = "Delete Panel";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(17)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(120, 43);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 21);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DSeqBox
            // 
            this.DSeqBox.Location = new System.Drawing.Point(14, 44);
            this.DSeqBox.Margin = new System.Windows.Forms.Padding(2);
            this.DSeqBox.Name = "DSeqBox";
            this.DSeqBox.Size = new System.Drawing.Size(76, 20);
            this.DSeqBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seq";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(227)))), ((int)(((byte)(84)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(544, 412);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(204, 26);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbEdition
            // 
            this.gbEdition.Controls.Add(this.ESeqBox);
            this.gbEdition.Controls.Add(this.label7);
            this.gbEdition.Controls.Add(this.EDobBox);
            this.gbEdition.Controls.Add(this.label2);
            this.gbEdition.Controls.Add(this.button1);
            this.gbEdition.Controls.Add(this.btnEdit);
            this.gbEdition.Controls.Add(this.ELastNameBox);
            this.gbEdition.Controls.Add(this.label5);
            this.gbEdition.Controls.Add(this.ENameBox);
            this.gbEdition.Controls.Add(this.label6);
            this.gbEdition.Enabled = false;
            this.gbEdition.Location = new System.Drawing.Point(544, 248);
            this.gbEdition.Margin = new System.Windows.Forms.Padding(2);
            this.gbEdition.Name = "gbEdition";
            this.gbEdition.Padding = new System.Windows.Forms.Padding(2);
            this.gbEdition.Size = new System.Drawing.Size(205, 155);
            this.gbEdition.TabIndex = 9;
            this.gbEdition.TabStop = false;
            this.gbEdition.Text = "Edition Panel";
            // 
            // ESeqBox
            // 
            this.ESeqBox.Location = new System.Drawing.Point(14, 39);
            this.ESeqBox.Margin = new System.Windows.Forms.Padding(2);
            this.ESeqBox.Name = "ESeqBox";
            this.ESeqBox.Size = new System.Drawing.Size(76, 20);
            this.ESeqBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Seq";
            // 
            // EDobBox
            // 
            this.EDobBox.Location = new System.Drawing.Point(115, 95);
            this.EDobBox.Margin = new System.Windows.Forms.Padding(2);
            this.EDobBox.Name = "EDobBox";
            this.EDobBox.Size = new System.Drawing.Size(76, 20);
            this.EDobBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOB";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(227)))), ((int)(((byte)(84)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(120, 123);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 21);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Guardar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ELastNameBox
            // 
            this.ELastNameBox.Location = new System.Drawing.Point(14, 95);
            this.ELastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.ELastNameBox.Name = "ELastNameBox";
            this.ELastNameBox.Size = new System.Drawing.Size(76, 20);
            this.ELastNameBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido";
            // 
            // ENameBox
            // 
            this.ENameBox.Location = new System.Drawing.Point(115, 39);
            this.ENameBox.Margin = new System.Windows.Forms.Padding(2);
            this.ENameBox.Name = "ENameBox";
            this.ENameBox.Size = new System.Drawing.Size(76, 20);
            this.ENameBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(89)))), ((int)(((byte)(232)))));
            this.btnUpdate.BackgroundImage = global::Intec.Properties.Resources.update_autorenew_refresh_reload_31805;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(482, 287);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 53);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Intec.Properties.Resources.pngtree_vector_plus_icon_png_image_515260;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(282, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 53);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(17)))));
            this.btnDel.BackgroundImage = global::Intec.Properties.Resources.delete_sign__v21;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(482, 171);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 53);
            this.btnDel.TabIndex = 9;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(227)))), ((int)(((byte)(84)))));
            this.btnAdd.BackgroundImage = global::Intec.Properties.Resources.add__v2;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(482, 51);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 53);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Intec.Properties.Resources.pngtree_vector_plus_icon_png_image_515260;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(282, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 53);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCalcularIndice
            // 
            this.btnCalcularIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(227)))), ((int)(((byte)(84)))));
            this.btnCalcularIndice.FlatAppearance.BorderSize = 0;
            this.btnCalcularIndice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularIndice.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularIndice.ForeColor = System.Drawing.Color.White;
            this.btnCalcularIndice.Location = new System.Drawing.Point(144, 412);
            this.btnCalcularIndice.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcularIndice.Name = "btnCalcularIndice";
            this.btnCalcularIndice.Size = new System.Drawing.Size(204, 26);
            this.btnCalcularIndice.TabIndex = 17;
            this.btnCalcularIndice.Text = "Calcular indice";
            this.btnCalcularIndice.UseVisualStyleBackColor = false;
            this.btnCalcularIndice.Click += new System.EventHandler(this.btnCalcularIndice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Seq";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcularIndice);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbEdition);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gbDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.dgvStudent);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbDel.ResumeLayout(false);
            this.gbDel.PerformLayout();
            this.gbEdition.ResumeLayout(false);
            this.gbEdition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.TextBox DobBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbDel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox DSeqBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbEdition;
        private System.Windows.Forms.TextBox EDobBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox ELastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ENameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox ESeqBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcularIndice;
        private System.Windows.Forms.Label label8;
    }
}