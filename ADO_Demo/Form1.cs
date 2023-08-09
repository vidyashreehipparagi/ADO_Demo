using ADO_Demo.Models;
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
    public partial class Form1 : Form
    {
        ProductCRUD crud;
        List<Category> list;

        public Form1()
        {
            InitializeComponent();
            crud = new ProductCRUD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = crud.GetCategaries();
            cbCategoryName.DataSource = list;
            cbCategoryName.DisplayMember = "Cname";
            cbCategoryName.ValueMember = "Cid";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSvae_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Name = txName.Text;
                p.Price = Convert.ToInt32(txPrice.Text);
                p.Cid = Convert.ToInt32(cbCategoryName.SelectedValue);
                int res = crud.AddProduct(p);
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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(txId.Text);
                p.Name = txName.Text;
                p.Price = Convert.ToInt32(txPrice.Text);
                p.Cid = Convert.ToInt32(cbCategoryName.SelectedValue);
                int res = crud.UpdateProduct(p);
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

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = crud.GetProductById(Convert.ToInt32(txId.Text));
                if (prod.Id > 0)
                {
                    foreach (Category item in list)
                    {
                        if (item.Cid == prod.Cid)
                        {
                            cbCategoryName.Text = item.Cname;
                            break;
                        }
                    }
                    txName.Text = prod.Name;
                    txPrice.Text = prod.Price.ToString();

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



}


private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int res = crud.DeleteProduct(Convert.ToInt32(txId.Text));
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

        private void txName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCategoryNAme_Click(object sender, EventArgs e)
        {

        }
    }
}
 
