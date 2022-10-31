using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Store_Maintaince_Assignment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bharat_City2Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Bharat_City2Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"select CityIdd, CityName2, StateId2 from
                                     dbo.Bharat_City2s";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyReader = MyCommand.ExecuteReader();
                    data.Load(MyReader);
                    MyReader.Close();
                    MyPlace.Close();

                }
            }
            return new JsonResult(data);


        }

        // post............................................................


        [HttpPost]

        public JsonResult Post(Bharat_City2 city2)
        {
            string query = @"insert into dbo.Bharat_City2s values (@CityName2, @StateId2)
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@CityName2", city2.CityName2);
                    MyCommand.Parameters.AddWithValue("@StateId2", city2.StateId2);
                    MyReader = MyCommand.ExecuteReader();
                    data.Load(MyReader);
                    MyReader.Close();
                    MyPlace.Close();

                }
            }
            return new JsonResult("Add Successfully");

        }

        //put..................................................................................................

        [HttpPut]

        public JsonResult Put(Bharat_City2 city2)
        {
            string query = @" update dbo.Bharat_City2s
                              set CityName2= @CityName2
                              where CityIdd=@CityIdd
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@CityIdd", city2.CityIdd);
                    MyCommand.Parameters.AddWithValue("@CityName2", city2.CityName2);
                    MyReader = MyCommand.ExecuteReader();
                    data.Load(MyReader);
                    MyReader.Close();
                    MyPlace.Close();

                }
            }
            return new JsonResult("Update successfully");

        }

        //Delete...........................................................................

        [HttpDelete("{Id}")]

        public JsonResult Delete(int Id)
        {
            string query = @" delete from dbo.Bharat_City2s
                              
                              where CityIdd=@CityIdd
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@CityIdd", Id);

                    MyReader = MyCommand.ExecuteReader();
                    data.Load(MyReader);
                    MyReader.Close();
                    MyPlace.Close();

                }
            }
            return new JsonResult("Delete Successfully");

        }
    }
}
