using System;
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

        public static List<string> IzpisLekarne(int id)
        {
            string connection = connect();
            List<string> izpislek = new List<string>();
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izplekarne(" + id + ");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                izpislek.Add(reader.GetString(0));
                izpislek.Add(reader.GetString(1));
                izpislek.Add(reader.GetString(2));
                izpislek.Add(reader.GetString(3));
                izpislek.Add(reader.GetString(4));
                izpislek.Add(reader.GetString(5));
                izpislek.Add(reader.GetString(6));



                con.Close(); 
                return izpislek;
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

        public static string updatelekarne(int id,string lime,string tel,string dcas,string nas,string kraj,string pot,string op)
        {
            string ret = "";
            string connection = connect();
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                try
                {
                    ret = "Posodobitev je bila uspešna";
                    NpgsqlCommand com = new NpgsqlCommand("SELECT updatelekarne(" + id +",'" + lime + "','" + tel + "','" + dcas + "','" + nas + "','" + kraj + "','" + pot + "','" + op + "');",con);
                    com.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    ret = "Prišlo je do napake " + ex.ToString();
                    throw;
                }
                
                con.Close();
                return ret;
            }
        }     

        public static void deletelekarno(int idl)
        {
            string connection = connect();
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT deletelekarno(" + idl + ");", con);
                com.ExecuteNonQuery();

                
                con.Close();
            }
        }

        public static bool checkmail(string mail)
        {
            string connection = connect();
            bool ok;
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT prevmail('" + mail + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                ok = reader.GetBoolean(0);
                con.Close();
                
            }
            return ok;
        }

        public static void zamenjajgeslo(string mail,string geslo)
        {
            string connection = connect();
            
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT zamgeslo('" + mail + "','" + geslo + "');", con);
                com.ExecuteNonQuery();
                con.Close();

            }
           
        }

        public static void deletekraj(string ime, string posta)
        {
            string connection = connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT delkraj('" + ime + "','" + posta + "');", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void updatekraj(string nime , string nposta, string sime, string sposta)
        {
            string connection = connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT updatekraj('" + nime + "','" + nposta + "','" + sime + "','" + sposta + "');", con);
                com.ExecuteNonQuery();
                con.Close();
                
            }
        }

        public static bool insertkraj(string nime, string nposta)
        {
            string connection = connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT insertkraj('" + nime + "','" + nposta + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                bool ok = reader.GetBoolean(0);
                con.Close();
                return ok;
            }
        }
        public static int iduporabnika(string email, string pass)
        {
            string connection = connect();
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand(" SELECT getiduporabnika('" + email + "','" + pass + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                int id = reader.GetInt32(0);
                con.Close();
                return id;
            }
        }

        public static bool updateuser(string email,string pass,string telefon,string kraj,string ime , int ajdi)
        {
            string connection = connect();
            
            using(NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand(" SELECT updateuser('" + email + "','" + pass + "','" + telefon + "','" + kraj + "','" + ime + "'," + ajdi + ");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                bool ok = reader.GetBoolean(0);
                con.Close();
                return ok;
            }
        }

        public static void deluser(int id)
        {
            string connection = connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT deluser(" + id + ");", con);
                com.ExecuteNonQuery();
                con.Close();
                


            }
        }
        public static int stevilo_lek_vkraju(string krajime, string krajposta)
        {
            string connection = connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT stlek_pokraju('" + krajime + "','" + krajposta + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                int stlek = reader.GetInt32(0);
               
                con.Close(); 
                return stlek;
            }
        }

        
    }
}
