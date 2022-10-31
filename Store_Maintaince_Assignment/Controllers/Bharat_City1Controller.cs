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
    public class Bharat_City1Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Bharat_City1Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"select CityId1, CityName1, StateId1 from
                                     dbo.Bharat_City1s";

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

        public JsonResult Post(Bharat_City1 city1)
        {
            string query = @"insert into dbo.Bharat_City1s values (@CityName1, @StateId1)
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@CityName1", city1.CityName1);
                    MyCommand.Parameters.AddWithValue("@StateId1", city1.StateId1);
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

        public JsonResult Put(Bharat_City1 city1)
        {
            string query = @" update dbo.Bharat_City1s
                              set CityName1= @CityName1
                              where CityId1=@CityId1
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@CityId1", city1.CityId1);
                    MyCommand.Parameters.AddWithValue("@CityName1", city1.CityName1);
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
            string query = @" delete from dbo.Bharat_City1s
                              
                              where CityId1=@CityId1
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@CityId1", Id);

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