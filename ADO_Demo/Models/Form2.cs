using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADO_Demo.Models;
using System.Xml.Linq;
namespace ADO_Demo.Models
{
    public partial class Form2 : Form
    {
        EmployeeCRUD crud;
        List<Department> list;

        public Form2()
        {
            InitializeComponent();
            crud = new EmployeeCRUD();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EName = txEName.Text;
                emp.Salary = Convert.ToInt32(txSalary.Text);
                emp.Did = Convert.ToInt32(cbDepartment.SelectedValue);
                int res = crud.AddProduct(emp);
                if (res > 0)
                {
                    MessageBox.Show("Record inserted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           list=crud.GetDepartment();
            cbDepartment.DataSource = list;
            cbDepartment.DisplayMember = "Dname";
            cbDepartment.ValueMember = "Did";
        }
    }
}
