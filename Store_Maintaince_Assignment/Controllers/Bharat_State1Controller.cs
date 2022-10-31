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
    public class Bharat_State1Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Bharat_State1Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"select StateId1, StateName1 from
                                     dbo.Bharat_State1s";

            DataTable data = new DataTable();
            string sqlDataSource = "Data Source=192.168.1.230;Initial Catalog=AdventureWorks2017;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";
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

        public JsonResult Post(Bharat_State1 state1)
        {
            string query = @"insert into dbo.Bharat_State1s values (@StateName1)
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StateName1", state1.StateName1);
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

        public JsonResult Put(Bharat_State1 state1)
        {
            string query = @" update dbo.Bharat_State1s
                              set StateName1= @StateName1
                              where StateId1=@StateId1
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StateId1", state1.StateId1);
                    MyCommand.Parameters.AddWithValue("@StateName1", state1.StateName1);
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
            string query = @" delete from dbo.Bharat_State1s
                              
                              where StateId1=@StateId1
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StateId1", Id);

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
