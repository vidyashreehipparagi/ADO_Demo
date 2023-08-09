using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Data;

namespace ADO_Demo.Models
{
    public class EmployeeCRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public EmployeeCRUD()
        {
            string connstr = ConfigurationManager.ConnectionStrings["defaultConnction"].ConnectionString;
            con = new SqlConnection(connstr);


        }
        public int AddProduct(Employee emp)
        {
            //step1-->qry
            string qry = "insert into Employee Values(@Eid,@EName,@salary,@Did)";
            //step2-->assign qry to coomand
            cmd = new SqlCommand(qry, con);
            //step3-pass value to the parametr
            cmd.Parameters.AddWithValue("@Eid", emp.EId);
            cmd.Parameters.AddWithValue("@EName",emp.EName);
            cmd.Parameters.AddWithValue("@salary",emp.Salary);
            cmd.Parameters.AddWithValue("@Did", emp.Did);
            //step4-fire the query
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public List<Department> GetDepartment()
        {
            List<Department> list = new List<Department>();
            //step 1;
            string qry = "select * from Department";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Department d = new Department();
                    d.Did = Convert.ToInt32(dr["Did"]);
                    d.Dname = dr["Dname"].ToString();
                    list.Add(d);
                }
            }
            con.Close();
            return list;
        }
        public int UpdateEmployee(Employee emp)
        {

            //step1-->qry
            string qry = "update Employee set Ename=@Ename,salary=@salary,Did=@Did where EId=@EId";
            //step2-->assign qry to coomand
            cmd = new SqlCommand(qry, con);
            //step3-pass value to the parametr
            cmd.Parameters.AddWithValue("@Ename", emp.EName);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            cmd.Parameters.AddWithValue("@Did",emp.Did);
            cmd.Parameters.AddWithValue("@EId",emp.EId);
            //step4-fire the query
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public Employee GetEmployeeById(int EId)
        {
            Employee employee = new Employee();
            string qry = "select * from Employee where EId=@EId";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@EId", EId);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    employee.EId = Convert.ToInt32(dr["EId"]);
                    employee.EName = dr["Ename"].ToString();
                    employee.Salary = Convert.ToInt32(dr["salary"]);
                    employee.Did = Convert.ToInt32(dr["Did"]);
                }
            }
            con.Close();
            return employee;
        }
        public int DeleteeEmployee(int EId)
        {
            // step1 -> qry
            string qry = "delete from Employee where EId=@EId";
            // step2- assign qry to command
            cmd = new SqlCommand(qry, con);
            // step3- pass valeu to the parameters
            cmd.Parameters.AddWithValue("@EId", EId);
            // step4- open the connection
            con.Open();
            //step5- fire the query
            int result = cmd.ExecuteNonQuery();
            //step6- close the conn
            con.Close();
            return result;
        }
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            string qry = "Select * from Employee";
            cmd= new SqlCommand(qry, con);
            con.Open();
            dr= cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dt.Load(dr);
            }
            con.Close();
            return dt;
        }
    }
}
