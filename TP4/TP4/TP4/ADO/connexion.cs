﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TP4
{
    public class Connexion
    {
        public static SqlConnection cn;

        public static string cnxstring = @"Data Source=(LocalDB)\MSSQLLocalDB;
          Initial Catalog=BD;Integrated Security=True";

        public static void Ouvrir()
        {
            cn = new SqlConnection();
            if (cn.State == ConnectionState.Closed)
            {
                cn.ConnectionString = cnxstring;
                cn.Open();
            }
        }
        public static void Fermer()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

    }
}