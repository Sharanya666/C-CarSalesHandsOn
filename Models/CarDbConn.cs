using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarSalesApplication.Models
{
    public class CarDbConn
    {
        string Connstr = "Data Source=100.72.130.5;Initial Catalog=Training;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";

        public string InsertCar(Carpropdb car)
        {
            SqlConnection sqlconn = new SqlConnection(Connstr);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand("insert into CarSales values('" + car.CarModel + "','" + car.CarName + "','" + car.CarCategory + "'," + car.CarPrice + "," + car.YearOfModel + ",'" + car.CarDescription + "')", sqlconn);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            return "Saved Successfully";
        }

        public string UpdateCar(Carpropdb car)
            {
                SqlConnection sqlconn = new SqlConnection(Connstr);
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("update CarEntryDetails set Category='" + car.CarCategory + "',Price = " + car.CarPrice + ",YearOfModel=" + car.YearOfModel + ",Description='" + car.CarDescription + "' where CarModel = '" + car.CarModel + "'",sqlconn);
                cmd.ExecuteNonQuery();
                sqlconn.Close();
                return "Updated Successfully";
            }
        public string DeleteCar(Carpropdb car)
        {
            SqlConnection sqlconn = new SqlConnection(Connstr);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand($"Delete from CarSales where CarModel='{car.CarModel}'", sqlconn);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            return "Deleted Successfully";
        }
        public DataTable load()
        {
            SqlConnection sqlconn = new SqlConnection(Connstr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from CarSales", sqlconn);
            DataTable d = new DataTable();
            sda.Fill(d);
            return d;
        }

    }
}