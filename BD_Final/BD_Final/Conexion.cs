using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BD_Final
{
    public class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("server=localhost;user id=Administrador;password=123;database=fitstyle");
        }

        public bool AbrirCon()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }

        }

        public bool CerrarCon()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
