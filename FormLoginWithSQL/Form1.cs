﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace FormLoginWithSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LPAOOKV\SQLEXPRESS;Initial Catalog=Quan Ly;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from NguoiDung where TaiKhoan = '"+tk+"' and MatKhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Dang nhap thanh cong");

                }
                else
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
