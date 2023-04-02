using Dapper;
using ManagementPurchasing.Data;
using ManagementPurchasing.Models;
using Microsoft.Data.SqlClient;

namespace ManagementPurchasing.Services
{
    public interface IPRService
    {
        Task<List<PR>> GetPRs();
    }

    public class PRService : IPRService
    {
        public async Task<List<PR>> GetPRs()
        {
            SqlConnection cnn = new SqlConnection(ConnectionString.defaultConnetionString);
            cnn.Open();
            var prs = await cnn.QueryAsync<PR>("select * from PR");
            cnn.Close();
            return prs.ToList();
        }
    }
}
