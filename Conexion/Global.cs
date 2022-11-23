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
        static string INTEGRATED_SECURITY = Environment.GetEnvironmentVariable("INTEGRATED_SECURITY");
        static string TRUST_SERVER_CERTIFICATE = Environment.GetEnvironmentVariable("TRUST_SERVER_CERTIFICATE");

        public static string ConnectionString = $"Server={SERVER},{PORT}; Initial Catalog={DATABASE};Persist Security Info=False; User ID={USERNAME};Password={PASSWORD};MultipleActiveResultSets=False; Encrypt=True;Integrated Security={INTEGRATED_SECURITY};";
    } 
}
