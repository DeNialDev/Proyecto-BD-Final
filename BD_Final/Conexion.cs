using System;
using MySql.Data.MySqlClient;

public class Class1
{
    public MySqlConnection conexion;

    public Conexion()
    {
        conexion = new MySqlConnection("server=localhost;user id=root;password=123456;database=ABCMYSQL");
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
