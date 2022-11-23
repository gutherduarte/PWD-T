using System;

namespace backend_especial.Conexion
{
    public class Global
    {
        static string SERVER = Environment.GetEnvironmentVariable("SERVER");
        static string PORT = Environment.GetEnvironmentVariable("PORT");
        static string DATABASE = Environment.GetEnvironmentVariable("DATABASE");
        static string USERNAME = Environment.GetEnvironmentVariable("USERNAME");
        static string PASSWORD = Environment.GetEnvironmentVariable("PASSWORD");

        public static string ConnectionString = $"Server={SERVER},{PORT}; Initial Catalog={DATABASE};Persist Security Info=False; User ID={USERNAME};Password={PASSWORD};MultipleActiveResultSets=False; Encrypt=True;";
    } 
}
