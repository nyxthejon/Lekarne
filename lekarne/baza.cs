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
        
    }

}
