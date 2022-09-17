using MySql.Data.MySqlClient;
using Biblioteca.Models;
using BibliotecaMAUI.Methods;

namespace Biblioteca.DataBase
{
    internal class conn
    {

        public static async Task<MySqlConnection> GetConnectionAsync()
        {
            Alerts alerts = new Alerts();
            string server, database, uid, password;
            server = "localhost";
            database = "escuela";
            uid = "root";
            password = "RootPass23.1";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {

                await alerts.snackBarAlert("MySql connection! \n" + ex.Message, "Intentar denuevo");
                
                
                

            }
            return conn;
        }
        //funcion añadida para agregar alumnos en la base de datos, se utilizo un modelo de datos ubicado en la carpeta datos donde se extraera el modelo de valores del alumno en cuestion
        public static void AddAlumno(Alumnos alum)
        {
            string sql = "INSERT INTO alumnos VALUES (@Matricula, @Nombre, @Carrera, @Semestre)";
            MySqlConnection con = GetConnectionAsync();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Matricula", MySqlDbType.Int16).Value = alum.Identificador;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = alum.Nombre;
            cmd.Parameters.Add("@Carrera", MySqlDbType.VarChar).Value = alum.Carrera;
            cmd.Parameters.Add("@Semestre", MySqlDbType.VarChar).Value = alum.Semestre;
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Alumno añadido correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Alumno no añadido! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }
        public static void AddDocente(Docentes docente)
        {
            string sql = "INSERT INTO docentes VALUES (@No_Empleado, @Nombre, @Carrera, @Semestre)";
            MySqlConnection con = GetConnectionAsync();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@No_Empleado", MySqlDbType.Int16).Value = docente.No_Empleado;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = docente.Nombre;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alumno añadido correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Alumno no añadido! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();

        }
    }
}