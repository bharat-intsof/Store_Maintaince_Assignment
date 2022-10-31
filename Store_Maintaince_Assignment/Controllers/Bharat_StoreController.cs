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
    public class Bharat_StoreController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Bharat_StoreController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"select StoreNumber, Name, Address1, Zip, Phone, Ext, Fax, Address2, Email, DefaultFinanceCharge, DefaultNumberOfDays, CurrentAccountPeroid, DateOfLastArchive, CycleBeginDate from
                                     dbo.Bharat_Stores";

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

        public JsonResult Post(Bharat_Store store)
        {
            string query = @"insert into dbo.Bharat_Stores values (@Name, @Address1, @Zip, @Phone, @Ext, @Fax, @Address2, @Email, @DefaultFinanceCharge, @DefaultNumberOfDays, @CurrentAccountPeroid, @DateOfLastArchive, @CycleBeginDate)
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@Name", store.Name);
                    MyCommand.Parameters.AddWithValue("@Address1", store.Address1);
                    MyCommand.Parameters.AddWithValue("@Zip", store.Zip);
                    MyCommand.Parameters.AddWithValue("@Phone", store.Phone);
                    MyCommand.Parameters.AddWithValue("@Ext", store.Ext);
                    MyCommand.Parameters.AddWithValue("@Fax", store.Fax);
                    MyCommand.Parameters.AddWithValue("@Address2", store.Address2);
                    MyCommand.Parameters.AddWithValue("@Email", store.Email);
                    MyCommand.Parameters.AddWithValue("@DefaultFinanceCharge", store.DefaultFinanceCharge);
                    MyCommand.Parameters.AddWithValue("@DefaultNumberOfDays", store.DefaultNumberOfDays);
                    MyCommand.Parameters.AddWithValue("@CurrentAccountPeroid", store.CurrentAccountPeroid);
                    MyCommand.Parameters.AddWithValue("@DateOfLastArchive", store.DateOfLastArchive);
                    MyCommand.Parameters.AddWithValue("@CycleBeginDate", store.CycleBeginDate);
                    MyReader = MyCommand.ExecuteReader();
                    data.Load(MyReader);
                    MyReader.Close();
                    MyPlace.Close();

                }
            }
            return new JsonResult("Add Successfully");

        }

        //put..................................................................................................

        //[HttpPut]

        //public JsonResult Put(Bharat_Store store)
        //{
        //    string query = @" update dbo.Bharat_Stores
        //                      set CityName2= @CityName2
        //                      where CityIdd=@CityIdd
        //                             ";

        //    DataTable data = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
        //    SqlDataReader MyReader;
        //    using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
        //    {
        //        MyPlace.Open();
        //        using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
        //        {
        //            MyCommand.Parameters.AddWithValue("@CityIdd", city2.CityIdd);
        //            MyCommand.Parameters.AddWithValue("@CityName2", city2.CityName2);
        //            MyReader = MyCommand.ExecuteReader();
        //            data.Load(MyReader);
        //            MyReader.Close();
        //            MyPlace.Close();

        //        }
        //    }
        //    return new JsonResult("Update successfully");

        //}

        //Delete...........................................................................

        [HttpDelete("{Id}")]

        public JsonResult Delete(int Id)
        {
            string query = @" delete from dbo.Bharat_Stores
                              
                              where StoreNumber=@StoreNumber
                                     ";

            DataTable data = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader MyReader;
            using (SqlConnection MyPlace = new SqlConnection(sqlDataSource))
            {
                MyPlace.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, MyPlace))
                {
                    MyCommand.Parameters.AddWithValue("@StoreNumber", Id);

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
