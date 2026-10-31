
using System.Data.SqlClient;

namespace Lab09_DataReaderSearch.DAL
{
    public static class DbConnectionFactory
    {
        private static string connectionString =
            @"Data Source=DESKTOP-16KR6S3;
              Initial Catalog=QLSinhVien_Lab9;
              Integrated Security=True;
              TrustServerCertificate=True";

        public static SqlConnection Create()
        {
            return new SqlConnection(connectionString);
        }
    }
}
