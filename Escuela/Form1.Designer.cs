namespace Escuela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtGrupo = new TextBox();
            nudSemestre = new NumericUpDown();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            dgvAlumno = new DataGridView();
            label5 = new Label();
            txtEspecialidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(95, 8);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Semestre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 82);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Grupo";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(368, 79);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(135, 23);
            txtGrupo.TabIndex = 7;
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(383, 8);
            nudSemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(120, 23);
            nudSemestre.TabIndex = 8;
            nudSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(566, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar ";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(566, 82);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(566, 151);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAlumno
            // 
            dgvAlumno.AllowUserToResizeColumns = false;
            dgvAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumno.Dock = DockStyle.Bottom;
            dgvAlumno.Location = new Point(0, 198);
            dgvAlumno.Name = "dgvAlumno";
            dgvAlumno.ReadOnly = true;
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumno.Size = new Size(679, 252);
            dgvAlumno.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 150);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 13;
            label5.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(383, 147);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(120, 23);
            txtEspecialidad.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(txtEspecialidad);
            Controls.Add(label5);
            Controls.Add(dgvAlumno);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(nudSemestre);
            Controls.Add(txtGrupo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMatricula;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private TextBox txtGrupo;
        private NumericUpDown nudSemestre;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnLimpiar;
        private DataGridView dgvAlumno;
        private Label label5;
        private TextBox txtEspecialidad;
    }
}
