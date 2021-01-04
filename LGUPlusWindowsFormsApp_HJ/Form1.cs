﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LGUplus.Common.ClassLibrary.HJ01;

namespace LGUPlusWindowsFormsApp_HJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        ///  폼 화면이 로딩 완료되면 실행되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            UserService service = new UserService();
            var user = service.GetUserData("Hojoon");

            this.textBox1.Text = user.UserName;
            this.textBox2.Text = user.UserEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장 버튼을 클릭했음");
        }
    }
}
