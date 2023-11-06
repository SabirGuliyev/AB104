﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkADONET.Data
{
    internal class Sql
    {
        private const string _connectionString = "server=msi;database=SpotifyAB104;trusted_connection=true;integrated security=true;";
        private readonly SqlConnection _connection=new SqlConnection(_connectionString);


        public int ExecuteCommand(string cmd)
        {
            int result = 0;

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(cmd, _connection);
                result=command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();

            try
            {
                _connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _connection.Close();
            }
            return table;
        }
    }
}
