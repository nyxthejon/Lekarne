﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;

namespace lekarne
{
    class baza
    {
        public static string connect()
        {
            var url = ConfigurationManager.AppSettings["ELEPHANTSQL_URL"] ?? "postgres://smqoixml:8IjKrAiAC94QogfYNNA1L7SCCQ6dHoYL@dumbo.db.elephantsql.com:5432/smqoixml";
            var uri = new Uri(url);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;

            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);
            return connStr;



        }

        public static List<string> kraji()
        {
            string connection = connect();
            List<string> krajiizpis = new List<string>();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM krajizpis();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string skp = reader.GetString(0) + "|" + reader.GetString(1);
                    krajiizpis.Add(skp);

                }
                con.Close();
                return krajiizpis;

            }
        }
        public static bool registracija(string email, string geslo, string ime, string tel, string kraj)
        {
            string connection = connect();

            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT registracija('" + email + "','" + geslo + "','" + ime + "','" + tel + "','" + kraj + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                bool prev = reader.GetBoolean(0);
               
                con.Close();
                return prev;
            }
            

        }

        public static bool vnoslekarne(string ime,string tel,string dcas,string naslov,string kraj,string pot,string opis)
        {
            bool ok;
            string connection = connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT vnoslekarne('" + ime + "','" + tel + "','" + dcas + "','" + naslov + "','" + kraj + "','" + pot + "','" + opis + "');",con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                ok = reader.GetBoolean(0);
                con.Close();
                return ok;
            }

               
        }
        public static bool prijava(string email,string pass)
        {
            bool prev;
            string connection = connect();
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT pri('" + email + "','" + pass + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                prev = reader.GetBoolean(0);

                con.Close();
            }
            return prev;
        }



    }
}
