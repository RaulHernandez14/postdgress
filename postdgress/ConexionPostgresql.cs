using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace postdgress
{
    public class ConexionPostgresql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = sambu14; Database= postgres");


        public void Conectar()
        {
            conn.Open();
            MessageBox.Show("Listo");
        }

        public void Desconectar() 
        {
            conn.Close();
            MessageBox.Show("Cerrado");

        }

        //\\

        public DataTable Consultar() 
        {
            string query = "select * from \"Persona\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar(string nom) 
        {
            string query = "select * from \"Persona\" where \"Nombre\" = '"+nom+"'" ;
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

        }
        public void Insertar(int id, string nombre, string pais, int edad) 
        {
            string query = "Insert into \"Persona\" values ("
                + id + ",'" + nombre + "','" 
                + pais + "'," + edad + ")";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho Bebe");
        }
        public void Eliminar (string n) 
        {
            string query = "Delete from \"Persona\" where \"Nombre\" = '"+n+"'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            ejecutor.ExecuteNonQuery();

            MessageBox.Show("El registro se Ha Eliminado");
        }
        public void Actualizar(int id, string nombre, string pais, int edad, string n) 
        {
            string query = "Update \"Persona\" set \"Id\"=" + id +", \"Nombre\"='"
                +nombre+"',\"Pais\"='"+pais+"', \"Edad\"=" +edad +" " +
                "where \"Nombre\" = '"+n+"'";
            
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            ejecutor.ExecuteNonQuery();

            MessageBox.Show("El registro se Ha Modificado");
        }
    }
}
