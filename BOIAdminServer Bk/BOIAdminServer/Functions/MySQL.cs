using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GetOnline.Functions
{
    class MySQL
    {
        private static String ConnectionString;
        internal static void Start()
        {
            MySQL.ConnectionString = "server=" + Config.MyIP + ";Port=" + Config.MyPort + ";uid=" + Config.MyUser + ";pwd=" + Config.MyPassword + ";Connection Timeout=10 ;database=" + Config.MyDatabase + "; convert zero datetime=True";
            TryConnect();
        }
        internal static void TryConnect()
        {
            using (MySqlConnection _con = new MySqlConnection())
            {
                _con.ConnectionString = MySQL.ConnectionString;
                DataTable Result = new DataTable();
                try
                {
                    _con.Open();
                    MySqlCommand cmd = new MySqlCommand(string.Format("select count(*) from {0}.{1}", Config.MyDatabase, Config.MyTable), _con);
                    cmd.ExecuteNonQuery();
                    _con.Close();


                }
                catch (Exception e)
                {
                    if (e.Message.Contains(string.Format("{0}.{1}", Config.MyDatabase, Config.MyTable)))
                    {
                        _fixDB();
                        TryConnect();
                        return;
                    }
                    Log.WriteError(e.Message);
                    throw new Exception(e.Message);
                }

            }

        }

        internal static DataTable _Query(string Query)
        {
            using (MySqlConnection _con = new MySqlConnection())
            {
                _con.ConnectionString = MySQL.ConnectionString;
                DataTable Result = new DataTable();
                try
                {
                    _con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, _con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    Result.Load(dr);
                    _con.Close();
                    return Result;

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }

        }

        public static String _Query(string Query, string nada = null)
        {
            using (MySqlConnection _con = new MySqlConnection())
            {
                _con.ConnectionString = ConnectionString;
                try
                {
                    _con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, _con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        return dr.GetString(0);
                    }
                    // return Encoding.Default.GetBytes(dr.GetString(0)).ToList();

                    dr.Close();
                    return null;
                }
                catch (Exception e)
                {
                    Log.WriteError(e.ToString());
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
        public static int _Query(string Query, int nada)
        {
            using (MySqlConnection _con = new MySqlConnection())
            {
                _con.ConnectionString = ConnectionString;
                try
                {
                    _con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, _con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                        return dr.GetInt32(0);

                    // return Encoding.Default.GetBytes(dr.GetString(0)).ToList();

                    dr.Close();
                    return 0;
                }
                catch (Exception e)
                {
                    Log.WriteError(e.ToString());
                    return 0;
                }
            }
        }

        public static Boolean _Query(string Query, Boolean nada)
        {
            using (MySqlConnection _con = new MySqlConnection())
            {
                _con.ConnectionString = ConnectionString;
                try
                {
                    _con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, _con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                        return dr.HasRows; ;

                    return false;
                }
                catch (Exception e)
                {
                    Log.WriteError(e.ToString());
                    return false;
                }
            }
        }

        internal static protected void _fixDB()
        {
            using (MySqlConnection _con = new MySqlConnection())
            {
                _con.ConnectionString = ConnectionString;
                try
                {
                    Log.WriteInfo("Creating Database...");
                    _con.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendFormat("CREATE DATABASE if not exists `{0}`;\n", Config.MyDatabase);
                    query.AppendFormat("DROP TABLE if exists `{0}`.`{1}`;\n", Config.MyDatabase, Config.MyTable);
                    query.AppendFormat("CREATE TABLE `{0}`.`{1}` (\n", Config.MyDatabase, Config.MyTable);
                    query.AppendFormat("`Key` INT NOT NULL AUTO_INCREMENT,\n");
                    query.AppendFormat("`UserID` VARCHAR(255) NOT NULL,\n");
                    query.AppendFormat("`CharName` VARCHAR(255) NULL,\n");
                    query.AppendFormat("`Realm` VARCHAR(255) NULL,\n");
                    query.AppendFormat("`IP` VARCHAR(255) NULL,\n");
                    query.AppendFormat("`Online` INT NULL,\n");
                    query.AppendFormat("PRIMARY KEY (`Key`));");

                    //CREATE TABLE `shengui`.`unstuck` (
                    //`UserID` INT NULL,
                    //`Queue` INT NULL,
                    //`Rearson` VARCHAR(255) NULL);
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), _con);
                    cmd.ExecuteNonQuery();
                    Log.WriteInfo(string.Format("Created new Table on {0} DB, now im ready to catch online users!", Config.MyDatabase));
                }
                catch (Exception e)
                {
                    Log.WriteError(e.Message);
                }
            }
        }
    }
}
