using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace linux_demo_api
{
    public class QuotesDAO
    {
        private IConfiguration configurations;

        public QuotesDAO(IConfiguration config)
        {
            this.configurations = config;
        }

        public Quote Retrieve(string symbol)
        {
            var connString = configurations.GetConnectionString("BaseQuotes");
            using (SqlConnection connection = new SqlConnection(connString))
            {
                return connection.QueryFirstOrDefault<Quote>(
                    "SELECT Symbol, Currency, LastQuote, Price " +
                    "FROM dbo.Quotes " +
                    "WHERE Symbol = @Symbol ",
                    new { Symbol = symbol }
                );
            }
        }
    }
}
