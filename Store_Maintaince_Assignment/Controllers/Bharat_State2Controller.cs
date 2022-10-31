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
    public class Bharat_State2Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Bharat_State2Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"select StateId2, StateName2 from
                                     dbo.Bharat_State2s";

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

        public JsonResult Post(Bharat_State2 state2)
        {
            string query = @"insert into dbo.Bharat_State2s values (@StateName2)
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StateName2", state2.StateName2);
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

        public JsonResult Put(Bharat_State2 state2)
        {
            string query = @" update dbo.Bharat_State2s
                              set StateName2= @StateName2
                              where StateId2=@StateId2
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StateId2", state2.StateId2);
                    MyCommand.Parameters.AddWithValue("@StateName2", state2.StateName2);
                    MyReader = MyCommand.ExecuteReader();
                    data.Load(MyReader);
                    MyReader.Close();
                    MyPlace.Close();

                }
            }
            return new JsonResult("Update successfully");

        }

        //Delete...........................................................................

        [HttpDelete("{StateId2}")]

        public JsonResult Delete(int StateId2)
        {
            string query = @" delete from dbo.Bharat_State2s
                              
                              where StateId2=@StateId2
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StateId2", StateId2);

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
