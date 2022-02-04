using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFormPersona.Model;

namespace WebFormPersona.CRUDOperation
{
    public class CRUDWeb:Conexion
    {
        public void Insert(Persona persona)
        {
            Connect();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO persona(nombre,apellido,edad) VALUES(@nombre,@apellido,@edad)", cnn);
                command.Parameters.Add(new SqlParameter("@nombre", persona.Nombre));
                command.Parameters.Add(new SqlParameter("@apellido", persona.Apellido));
                command.Parameters.Add(new SqlParameter("@edad", persona.Edad));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Close();
            }
        }

        public List<Persona> GetAll()
        {
            List<Persona> lista = new List<Persona>();
            Connect();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM persona",cnn);
                SqlDataReader datos = command.ExecuteReader();
                while(datos.Read())
                {
                    Persona persona = new Persona();
                    persona.Id = int.Parse(datos[0].ToString());
                    persona.Nombre = datos[1].ToString();
                    persona.Apellido = datos[2].ToString();
                    persona.Edad = int.Parse(datos[3].ToString());
                    lista.Add(persona);

                }                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Close();
            }
            return lista;
        }
        public void Update(Persona persona)
        {
            Connect();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE persona set nombre=@nombre,apellido=@apellido,edad=@edad WHERE id=@id", cnn);
                command.Parameters.Add(new SqlParameter("@nombre", persona.Nombre));
                command.Parameters.Add(new SqlParameter("@apellido", persona.Apellido));
                command.Parameters.Add(new SqlParameter("@edad", persona.Edad));
                command.Parameters.Add(new SqlParameter("@id", persona.Id));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Close();
            }
        }
        public void Delete(int id)
        {
            Connect();
            try
            {
                SqlCommand command = new SqlCommand("DELETE * FROM persona WHERE id=@id", cnn);
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Close();
            }
        }
    }
}