using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ADO_Demo.Models
{
    public class ProductCRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductCRUD()
        {
            string connstr = ConfigurationManager.ConnectionStrings["defaultConnction"].ConnectionString;
            con = new SqlConnection(connstr);


        }
        public int UpdateProduct(Product prod) {

            //step1-->qry
            string qry = "update Product set name=@name,price=@price,cid=@cid where id=@id";
            //step2-->assign qry to coomand
            cmd = new SqlCommand(qry, con);
            //step3-pass value to the parametr
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            cmd.Parameters.AddWithValue("@cid", prod.Cid);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            //step4-fire the query
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public int AddProduct(Product prod)
        {
            //step1-->qry
            string qry = "insert into Product Values(@name,@price,@cid)";
            //step2-->assign qry to coomand
            cmd=new SqlCommand(qry, con);
            //step3-pass value to the parametr
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            cmd.Parameters.AddWithValue("@cid", prod.Cid);
            //step4-fire the query
            con.Open();
            int result=cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public List<Category> GetCategaries()
        {
            List<Category> list = new List<Category>();
            //step 1;
            string qry = "select * from Category";
            cmd=new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    Category c = new Category();
                    c.Cid = Convert.ToInt32(dr["cid"]);
                    c.Cname = dr["cname"].ToString();
                    list.Add(c);
                }
            }
            con.Close();
            return list;
        }
        public int DeleteProduct(int id)
        {
            // step1 -> qry
            string qry = "delete from Product where id=@id";
            // step2- assign qry to command
            cmd = new SqlCommand(qry, con);
            // step3- pass valeu to the parameters
            cmd.Parameters.AddWithValue("@id", id);
            // step4- open the connection
            con.Open();
            //step5- fire the query
            int result = cmd.ExecuteNonQuery();
            //step6- close the conn
            con.Close();
            return result;
        }

        public Product GetProductById(int id)
        {
            Product product = new Product();
            string qry = "select * from Product where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    product.Id = Convert.ToInt32(dr["id"]);
                    product.Name = dr["name"].ToString();
                    product.Price = Convert.ToInt32(dr["price"]);
                    product.Cid = Convert.ToInt32(dr["cid"]);
                }
            }
            con.Close();
            return product;
        }




    }
}
