using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
{
    InitializeComponent();
    // Asignar los métodos manejadores correctos
    btnGuardar.Click += btnGuardar_Click;
    btnLimpiar.Click += btnLimpiar_Click;
    btnMostrar.Click += btnMostrar_Click;
    Load += Form1_Load;
}

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumno();
        }



        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validamos que os campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
               string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtGrupo.Text) ||
               string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Por favor complete los campos antes e guarda " +
                    "Datos incompletos",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (OleDbConnection conexion =
                    ConexioBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "INSERT INTO Alumnos" +
                        "(Matricula, Nombre, Semestre, Grupo, Especialidad)" +
                        "VALUES (? ,? ,? ,? ,? )";
                    using (OleDbCommand comando =
                        new OleDbCommand(consulta, conexion))
                    {
                        //Con OleDB importar el orden en los parametros
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtMatricula.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 100
                            ).Value = txtNombre.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.Integer
                            ).Value = int.Parse(nudSemestre.Text);
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtGrupo.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtEspecialidad.Text.Trim();
                        comando.ExecuteNonQuery();
                    
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar l alumno:{ex.Message}",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void CargarAlumno()
        {
            try
            {
                using (OleDbConnection conexion =
                    ConexioBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "SELECT idAlumno, Matricula, Nombre," +
                        " Semestre, Grupo, Especialidad" +
                        " FROM alumnos order By idAlumno";
                    using (OleDbDataAdapter adaptador =
                        new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvAlumno.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los alumnos :{ex.Message}",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }    
            }
        }
    }
