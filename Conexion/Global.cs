namespace backend_especial.Conexion
{
    public class Global
    {
        string SERVER = Environment.GetEnvironmentVariable("SERVER");
        string PORT = Environment.GetEnvironmentVariable("PORT");
        string DATABASE = Environment.GetEnvironmentVariable("DATABASE");
        string USERNAME = Environment.GetEnvironmentVariable("USERNAME");
        string PASSWORD = Environment.GetEnvironmentVariable("PASSWORD");
        string INTEGRATED_SECURITY = Environment.GetEnvironmentVariable("INTEGRATED_SECURITY");
        string TRUST_SERVER_CERTIFICATE = Environment.GetEnvironmentVariable("TRUST_SERVER_CERTIFICATE");

        public static string ConnectionString = $"Server={SERVER},{PORT}; Initial Catalog={DATABASE};Persist Security Info=False; User ID={USERNAME};Password={PASSWORD};MultipleActiveResultSets=False; Encrypt=True;Integrated Security={INTEGRATED_SECURITY};"
    } 
}
