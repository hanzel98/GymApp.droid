using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Android.Widget;

namespace GymApp
{
    public class MySQLCon
    {
        MySqlConnection conexionMySQL;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();


        public string CreadorStringConexion()
        {
            builder.Server = "sql10.freemysqlhosting.net";
            builder.Database = "sql10209158";
            builder.UserID = "sql10209158";
            builder.Password = "Yt5kKkrRBk";

            return builder.ToString();
        }

        public DatosInformacion Datillo(string user,string password)
        {
            
            string StringConexion = CreadorStringConexion();
            string consulta = "SELECT * FROM `cliente` WHERE `id`= 3";
            try
            {
                conexionMySQL = new MySqlConnection(StringConexion);
                conexionMySQL.Open();

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand(consulta, conexionMySQL);

                rdr = cmd.ExecuteReader();

                DatosInformacion Dato = new DatosInformacion();

                while (rdr.Read())
                {
                    Dato.Nombre = rdr["nombre"].ToString();
                    Dato.Peso= rdr["peso"].ToString();
                    Dato.PorcentajeDeGrasa = rdr["porcentaje_grasa"].ToString();
                    Dato.PorcentajeDeAgua = rdr["porcentaje_agua"].ToString();
                    Dato.IndiceDeMasaCorporal = rdr["imc"].ToString();
                    Dato.Pecho = rdr["pecho"].ToString();
                    Dato.Espalda = rdr["espalda"].ToString();
                    Dato.Brazo = rdr["brazo"].ToString();
                    Dato.Cintura = rdr["cintura"].ToString();
                    Dato.Abdomen = rdr["abdomen"].ToString();
                    Dato.Cadera = rdr["cadera"].ToString();
                    Dato.Muslo = rdr["muslo"].ToString();
                    Dato.Pantorrilla = rdr["pantorrilla"].ToString();
                }
                return Dato;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexionMySQL.Close();
            }
        }
    }

}