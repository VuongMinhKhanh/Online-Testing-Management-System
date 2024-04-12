﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_BUS;

namespace QuestionBank_GUI
{
    public partial class Login : Form
    {
        private Login_BUS loginBUS;
        public Login()
        {
            InitializeComponent();
            loginBUS = new Login_BUS();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userRole = cmbUserRole.SelectedItem as string;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                return;
            }

            // Thực hiện kiểm tra đăng nhập
            if (loginBUS.XacThucDangNhap(username, password, userRole))
            {
                MessageBox.Show("Đăng nhập thành công!");

                switch (userRole)
                {
                    case "Sinh viên":
                        // Hiển thị trang chủ của sinh viên
                        HomePage_Student studentHomePage = new HomePage_Student();
                        studentHomePage.Show();
                        break;
                    case "Giảng viên":
                        // Hiển thị trang chủ của giảng viên
                        HomePage_Teacher teacherHomePage = new HomePage_Teacher();
                        teacherHomePage.Show();
                        break;
                    case "Admin":
                        // Hiển thị trang chủ của admin
                        HomePage_Admin adminHomePage = new HomePage_Admin();
                        adminHomePage.Show();
                        break;
                    default:
                        MessageBox.Show("Vai trò không hợp lệ!");
                        break;

                }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
