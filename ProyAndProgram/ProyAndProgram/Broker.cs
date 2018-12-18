using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;


namespace ProyAndProgram
{
    class Broker
    {
        //Atributos
        OleDbConnection connection;
        OleDbCommand command;
        //Metodo que busca el archivo de la base de datos
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.15.0;Data Source=../../../BaseColegio.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }
        //Constructor de la clase
        public Broker()
        {
            ConnectTo();
        }
        //Metodos para guardar la informacion en la base de datos
        public void InsertarEstudiante(Estudiantes e)
        {
            try
            {

                command.CommandText = "INSERT INTO Alumnos (Nombre, Apellido, Edad, Sexo, Documento, CursoGrado, Direccion, Telefono, rh, Email) VALUES ('" + e.getNombre() + "', '" + e.getApellido() + "','" + e.getEdad() + "','" +  Convert.ToInt16(e.getSexo()) + "','" + e.getDocumento() + "', '" + e.getCursoGrado() + "','" + e.getDireccion() + "','" + e.getTelefono() + "', '" + e.getrh() + "','" + e.getEmail() + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void InsertarProfesor(Profesor p)
        {
            try
            {
                command.CommandText = "INSERT INTO Profesores (Nombre,Apellido,Edad,Sexo,Documento,Grupo,Titulo,Escalafon,Jornada,Direccion,Telefono,Rh,Email) VALUES ('" + p.getNombre() + "', '" + p.getApellido() + "','" + p.getEdad() + "','" + Convert.ToInt16(p.getSexo()) + "','" + p.getDocumento() + "', '" + p.getGrupo() + "','" + p.getTitulo() + "', '" + p.getEscalafon() + "','" + Convert.ToInt16(p.getJornada()) + "','" + p.getDireccion() + "','" + p.getTelefono() + "', '" + p.getrh() + "','" + p.getEmail() + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void InsertarPersonal(Personal pe)
        {
            try
            {
                command.CommandText = "INSERT INTO Personal (Nombre,Apellido,Edad,Sexo,Documento,Trabajo) VALUES ('" + pe.getNombre() + "', '" + pe.getApellido() + "','" + pe.getEdad() + "','" + Convert.ToInt16(pe.getSexo()) + "','" + pe.getDocumento() + "', '" + pe.getTrabajo() + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void InsertarVisitante(Visitante v)
        {
            try
            {
                command.CommandText = "INSERT INTO Visitas (Nombre,Apellido,Sexo,Asunto,Relacion) VALUES ('" + v.getNombre() + "', '" + v.getApellido() + "','" + Convert.ToInt16(v.getSexo()) + "','" + v.getAsunto() + "', '" + v.getRelacion() + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void InsertarLibro(Libro l){
            try
            {
                command.CommandText = "INSERT INTO Libros (CodLibro,Titulo,Disponibilidad,Autor,Edicion,Editorial,Ejemplares,Materia,FechaIngreso) VALUES ('" + l.CodLibro + "', '" + l.Titulo + "','" + Convert.ToInt16(l.Dispinibilidad1) + "','" + l.Autor + "', '" + l.Edicion + "','" + l.Editorial + "', '" + l.Ejemplares + "','" + l.Materia + "', '" + l.FechaIngreso + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        //Metodos para actualizar la informacion en la base de datos
        public void ActEstudiante(Estudiantes e)
        {
            try
            {
                command.CommandText = "UPDATE Alumnos SET Nombre="+e.getNombre()+ "Apellido=" + e.getApellido() + "Edad=" + e.getEdad() + "Sexo=" + e.getSexo() + "Documento=" + e.getDocumento() + "Curso=" + e.getCursoGrado() + "Direccion=" + e.getDireccion() + "Telefono=" + e.getTelefono() + "Rh=" + e.getrh() + "Email=" + e.getEmail() + "WHERE Nombre="+e.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void ActProfesor(Profesor p)
        {
            try
            {
                command.CommandText = "UPDATE Profesores SET Nombre=" + p.getNombre() + "Apellido=" + p.getApellido() + "Edad=" + p.getEdad() + "Sexo=" + p.getSexo() + "Documento=" + p.getDocumento() + "Grupo=" + p.getGrupo() + "Titulo="+p.getTitulo()+"Escalafon="+p.getEscalafon()+"Jornada="+p.getJornada()+"Direccion=" + p.getDireccion() + "Telefono=" + p.getTelefono() + "Rh=" + p.getrh() + "Email=" + p.getEmail() + "WHERE Nombre=" + p.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void ActPersonal(Personal pe)
        {
            try
            {
                command.CommandText = "UPDATE Personal SET Nombre=" + pe.getNombre() + "Apellido=" + pe.getApellido() + "Edad=" + pe.getEdad() + "Sexo=" + pe.getSexo() + "Documento=" + pe.getDocumento() + "Trabajo=" + pe.getTrabajo() + " WHERE Nombre="+pe.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void ActVisitantes(Visitante v)
        {
            try
            {
                command.CommandText = "UPDATE Visitas SET Nombre=" + v.getNombre() + "Apellido=" + v.getApellido() + "Sexo=" + v.getSexo() + "Asunto=" + v.getAsunto() + "Relacion=" + v.getRelacion() + " WHERE Nombre=" + v.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void ActLibros(Libro l)
        {
            try
            {
                command.CommandText = "UPDATE Libros SET CodLibro="+l.CodLibro+ "Titulo=" + l.Titulo + "Disponibilidad=" + l.Dispinibilidad1 + "Autor=" + l.Autor + "Edicion=" + l.Edicion + "Editorial=" + l.Editorial + "Ejemplares=" + l.Ejemplares + "Materia=" + l.Materia + "WHERE CodLibro=" + l.CodLibro;
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        //Metodos para eliminar la informacion en la base de datos
        public void EliminarEstudiante(Estudiantes e)
        {
            try
            {
                command.CommandText = "DELETE FROM Alumnos WHERE Nombre="+e.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void EliminarProfesor(Profesor p)
        {
            try
            {
                command.CommandText = "DELETE FROM Profesores WHERE Nombre=" + p.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void EliminarPersonal(Personal pe)
        {
            try
            {
                command.CommandText = "DELETE FROM Personal WHERE Nombre=" + pe.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void EliminarVisitante(Visitante v)
        {
            try
            {
                command.CommandText = "DELETE FROM Visitas WHERE Nombre=" + v.getNombre();
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public void EliminarLibro(Libro l)
        {
            try
            {
                command.CommandText = "DELETE FROM Libros WHERE CodLibro=" + l.CodLibro;
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

    /*    public string AccederEstudiante()
        {
            try
            {

               // OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SISC-STRONGHOLD\MIS!\wilbert.beltran\SEEDBucksDbase.accdb");
                // conn.Open();
                connection.Open();
                //OleDbCommand cmd = new OleDbCommand();
    command.Connection = connection;
    command.CommandText = "SELECT Nombre From Alumnos";
    OleDbDataReader reader = command.ExecuteReader();
             //   Estudiantes instant = new Estudiantes(reader[0].ToString(), reader[0].ToString(), Convert.ToInt16(reader[0]),true," ", "","","","",9);
   
                connection.Close();
                //  return instant;
                    return reader.GetString(0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        } */

    }
}
