using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO_Demo.Models;
using System.Xml.Linq;

namespace ADO_Demo
{
    public partial class Form3 : Form
    {
        EmployeeCRUD crud;
        List<Department> list;
        public Form3()
        {
            InitializeComponent();
            crud = new EmployeeCRUD();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            list = crud.GetDepartment();
            cbDepartment.DataSource = list;
            cbDepartment.DisplayMember = "Dname";
            cbDepartment.ValueMember = "Did";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int res = crud.DeleteeEmployee(Convert.ToInt32(txEid.Text));
                if (res > 0)
                {
                    MessageBox.Show("Record deleted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EId = Convert.ToInt32(txEid.Text);
                emp.EName = txEName.Text;
                emp.Salary = Convert.ToInt32(txSalary.Text);
                emp.Did = Convert.ToInt32(cbDepartment.SelectedValue);
                int res = crud.UpdateEmployee(emp);
                if (res > 0)
                {
                    MessageBox.Show("Record updated..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EId= Convert.ToInt32(txEid.Text );
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

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbDepartment_Click(object sender, EventArgs e)
        {

        }

        private void txSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txEName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txEid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbESalary_Click(object sender, EventArgs e)
        {

        }

        private void lbEname_Click(object sender, EventArgs e)
        {

        }

        private void lbEid_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = crud.GetEmployeeById(Convert.ToInt32(txEid.Text));
                if (emp.EId > 0)
                {
                    foreach (Department item in list)
                    {
                        if (item.Did == emp.Did)
                        {
                            cbDepartment.Text= item.Dname;
                            break;
                        }
                    }
                    txEName.Text = emp.EName;
                    txSalary.Text = emp.Salary.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            DataTable table = crud.GetDataTable();
            dataGridView.DataSource = table;

        }
    }
}
