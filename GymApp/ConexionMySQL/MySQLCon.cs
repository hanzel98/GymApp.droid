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

        public string VerificaUsuarioYContraseña(string user, string password)
        {
            string id = "";
            string StringConexion = CreadorStringConexion();
            string consulta = "SELECT id FROM `cliente` WHERE usuario = \"" + user+ "\" AND contrasena = \""+password+ "\"";
            try
            {
                conexionMySQL = new MySqlConnection(StringConexion);
                conexionMySQL.Open();

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand(consulta, conexionMySQL);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id = rdr["id"].ToString();
                }
                return id;
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

        public DatosInformacion ConsigueDatos(string user, string password)
        {
            DatosInformacion Dato = new DatosInformacion();
            Dato= BDDatosInformation(user,password,Dato);
            Dato = BDDatosRutina(Dato);
            //Dato = BDDatosPago(user,password,Dato);
            return Dato;
        }
        
        public DatosInformacion BDDatosInformation(string user,string password, DatosInformacion Dato )
        {
            
            string StringConexion = CreadorStringConexion();
            int id = Convert.ToInt32(MainActivity.id);

            string consulta = "SELECT * FROM `cliente` WHERE `id`= "+id;
            try
            {
                conexionMySQL = new MySqlConnection(StringConexion);
                conexionMySQL.Open();

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand(consulta, conexionMySQL);

                rdr = cmd.ExecuteReader();

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

        private DatosInformacion BDDatosRutina( DatosInformacion Dato)
        {
            string StringConexion = CreadorStringConexion();

            //int id = Convert.ToInt32(MainActivity.id);
            string consulta = "SELECT * FROM `ejercicio` WHERE `id`= "+2;
            try
            {
                conexionMySQL = new MySqlConnection(StringConexion);
                conexionMySQL.Open();

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand(consulta, conexionMySQL);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Dato.NombreRutina = rdr["id"].ToString();
                    Dato.NombreEjercicio = rdr["nombre"].ToString();
                    Dato.Descanso = rdr["descanso"].ToString();
                    Dato.Series = rdr["numero_series"].ToString();
                    Dato.Repeticiones = rdr["numero_repeticiones"].ToString();
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
        private DatosInformacion BDDatosPago(string user, string password, DatosInformacion Dato)
        {
            string StringConexion = CreadorStringConexion();
            string consulta = "SELECT * FROM `ejercicio` WHERE `id`= 1";
            try
            {
                conexionMySQL = new MySqlConnection(StringConexion);
                conexionMySQL.Open();

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand(consulta, conexionMySQL);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Dato.FechaDeUltimoPago= rdr[""].ToString();
                    Dato.FechaDePagoSiguiente = rdr[""].ToString();
                    Dato.DíasRestantes = rdr[""].ToString();
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