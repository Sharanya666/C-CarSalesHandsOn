using CarSalesApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarSalesApplication
{
    public partial class CarHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load1();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CarDbConn c = new CarDbConn();
            Carpropdb cp = new Carpropdb();
            cp.CarModel = TextBox1.Text;
            cp.CarName = TextBox6.Text;
            cp.CarCategory = TextBox2.Text;
            cp.CarPrice = Convert.ToInt32(TextBox3.Text);
            cp.YearOfModel = Convert.ToInt32(TextBox4.Text);
            cp.CarDescription = TextBox5.Text;
            string m = c.InsertCar(cp);
            Response.Write($"<script>alert('{m}'</script>");
            load1();

        }
        protected void load1()
        {
            CarDbConn c = new CarDbConn();
            DataTable d = c.load();
            Cartable.DataSource = d;
            Cartable.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CarDbConn c = new CarDbConn();
            Carpropdb cp = new Carpropdb();
            cp.CarModel = TextBox1.Text;
            string msg = c.DeleteCar(cp);
            Response.Write($"<script>alert('{msg}')</script>");
            load1();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CarDbConn c = new CarDbConn();
            Carpropdb cp = new Carpropdb();
            cp.CarModel = TextBox1.Text;
            cp.CarName = TextBox6.Text;
            cp.CarCategory = TextBox2.Text;
            cp.CarPrice = Convert.ToInt32(TextBox4.Text);
            cp.YearOfModel = Convert.ToInt32(TextBox3.Text);
            cp.CarDescription = TextBox5.Text;
            string msg = c.UpdateCar(cp);
            Response.Write($"<script>alert('{msg}')</script>");
            load1();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

        }
    }
}