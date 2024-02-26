using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzureFunction_Dapper.Models
{
    public class Bike
    {
		[JsonIgnore]
		public int BikeID { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Type { get; set; }
		public decimal Price { get; set; }

	}
}
