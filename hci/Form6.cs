﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemList(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 List = new Form8();
            List.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 LoginPage = new Form1();
            LoginPage.Show();
        }






























        private void ClrAll_Click(object sender, EventArgs e)
        {
            
        }

        //private void insertbtn_Click(object sender, EventArgs e)
        //{
        //    dgvOrderDtls.Rows.Add(txtqntty.Text,txtboxsku.Text,txtboxUofM.Text,txtdsptn.Text);
        //}

        //private void dltbtn_Click(object sender, EventArgs e)
        //{
        //    int rowindex = dgvOrderDtls.CurrentCell.RowIndex;
        //    dgvOrderDtls.Rows.RemoveAt(rowindex);
        //}

        private void txtqntty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxsku_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxUofM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdsptn_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUofM_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;
        }
    }
}
