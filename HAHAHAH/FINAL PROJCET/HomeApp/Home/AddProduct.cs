﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        Operations Op = new Operations();
        string query;
        int ProdId;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdId = Op.count();

                query = "Insert into ProductTbl values("+ProdId+",'"+ProdNameTb.Text+"','"+BrandCb.SelectedItem.ToString()+"','"+CategoryCb.SelectedItem.ToString()+"',"+ProdQty.Text+","+PriceTb.Text+")";
                Op.insertdata(query);
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
