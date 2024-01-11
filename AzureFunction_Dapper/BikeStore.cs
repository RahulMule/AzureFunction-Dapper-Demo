using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using AzureFunction_Dapper.Models;
using Dapper;

namespace AzureFunction_Dapper
{
    public  class BikeStore
    {
    
        [FunctionName("BikeStore")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            try
            {
                using var connection = GetSqlConnection();
                var bikes = connection.Query<Bike>("Select * from Bikes");
                return new OkObjectResult(bikes);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        private SqlConnection GetSqlConnection()
        {
            string connstring = Environment.GetEnvironmentVariable("connstring");
            SqlConnection sqlConnection = new SqlConnection(connstring);
            return sqlConnection;
        }
    }
}
