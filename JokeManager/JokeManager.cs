/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JokeManagerNamespace
{
    public class JokeManager
    {
        public static int SaveJoke(String UCID, String joke)
        {
            int status = 0;
            Config.login = "3045Fall2021FinalProjectLogin";
            Config.password = "Qbert42Fish";
            Config.server = "IL-Server-002.uccc.uc.edu\\Mssqlserver2019";
            Config.database = "3045Fall2021FinalProject";
            status = Utils.ExecuteNonQuery("INSERT INTO tJoke(UCID, Joke) VALUES( 'nicholdw', 'a cow does something')", System.Data.CommandType.Text,null, null);

            return status;
        }
    }
    class Utils
    {
        /// <summary>
        /// Make sure the database connection is open
        /// </summary>
        /// <returns>true if the connection is open, false otherwise</returns>
        private static bool CheckConnection()
        {
            // todo: Add a select case to handle all the possible states of myConnection.State
            bool status = true, justGotConnString = false;

            if (Config.myConnection == null)
            {
                Config.myConnection = new System.Data.SqlClient.SqlConnection(Config.connectionString);
                justGotConnString = true;
            }
            if (Config.myConnection.State != System.Data.ConnectionState.Open)
            {
                if (!justGotConnString) { Config.myConnection.ConnectionString = Config.connectionString; }
                try
                {
                    Config.myConnection.Open();
                }
                catch (Exception ex)
                {
                    status = false;
                    throw new Exception(ex.Message);
                }
            }
            return status;
        }
        /// <summary>
        /// Execute an action query. The name , "Non Query" reflects what Microsoft uses in the .Net framework
        /// </summary>
        /// <param name="pSQL">The SQL to be executed</param>
        /// <param name="pCommandType">Text or Stored Procedure</param>
        /// <param name="pSQLCmd"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(String pSQL,
                                          System.Data.CommandType pCommandType,
                                          System.Data.SqlClient.SqlCommand pSQLCmd,
                                          List<SqlParameter> parameters)
        {
            int status = -1;
            try
            {
                // I don't know why the Framework method is called "ExecuteNonQuery" but I named this
                //  method the same, to reduce confusion. The name should be "ExecuteActionQuery"

                CheckConnection();
                System.Data.SqlClient.SqlCommand objCmd = Config.myConnection.CreateCommand();
                objCmd.CommandText = pSQL;
                objCmd.CommandType = pCommandType;      // The default is 'text', which implies an SQL string
                objCmd.Parameters.Clear();          // Just in case we used any the last time we called this
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters) { objCmd.Parameters.Add(parameter); }
                }
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                try
                {
                    //ErrorLog.LogEvent(pSQL + " ERROR in ExcecuteNonQuery() : " + ex.Message, 0,  0);
                    System.Console.WriteLine(DateTime.Now + " ExecuteNonQuery() : " + ex.Message + " : " + pSQL);
                    status = 1;
                }
                catch (Exception ex1)
                {
                    status = 0;
                    throw new Exception(ex.Message);
                }
            }
            finally { }
            return status;
        }
    }
    class Config
    {
        internal static SqlConnection mMyConnection;
        internal static string mServer, mLogin, mPassword, mDatabase;

        public static SqlConnection myConnection
        {
            get { return mMyConnection; }
            set { mMyConnection = value; }
        }
        public static string server
        {
            get { return mServer; }
            set { mServer = value; }
        }
        public static string login
        {
            get { return mLogin; }
            set { mLogin = value; }
        }
        public static string password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public static string database
        {
            get { return mDatabase; }
            set { mDatabase = value; }
        }
        public static string connectionString
        {
            get
            {
                return "user id=" + login + ";" +
                       "password=" + password + " ;" +
                       "server=" + server + ";" +
                       "Trusted_Connection=no;" +
                       "database=" + database + ";" +
                       "MultipleActiveResultSets=true; " +
                       "connection timeout=30";
            }
        }
    }
}




