﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Person> 員工基本資料集合 = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person.aboutInfo();
            //GobalVar.目前的使用者 = "人資經理 - 黃小貓";
            GobalVar.目前的使用者 += "-人資經理";
            lalLoginName.Text ="目前使用者:" + GobalVar.目前的使用者;
        }
        private void btnWorker1_Click(object sender, EventArgs e)
        {
            Person 員工1 = new Person();
            員工1.姓名 = "王大衛";
            員工1.身高 = 170.0f;
            員工1.體重 = 70.0;
            員工1.到職日 = Convert.ToDateTime("2022-4-28");
            員工1.薪資 = 24000.0;
            員工1.部門代號 = (int)MyEunms.Dep.行政處;
            員工1.Email.data = "DavidWang@test.com.tw";
            員工1.age.data = 30;
            員工1.Email.SaveData("DavidWang@test.com.tw");
            員工1.age.SaveData(30);
            員工1.地址 = new AddressInfo("高雄市", "前金區", "中正路88號");


            員工基本資料集合.Add(員工1);
            員工1.顯示基本資料();
        }

        private void btnWorker2_Click(object sender, EventArgs e)
        {
            Person 員工2 = new Person();
            員工2.姓名 = "李瑪莉";
            員工2.身高 = 160.0f;
            員工2.體重 = 50.0;
            員工2.到職日 = new DateTime(2018, 7, 2, 0, 0, 0);
            員工2.薪資 = 32000.0;
            員工2.部門代號 = (int)MyEunms.Dep.資訊處;
            員工2.Email.data = "MAryLe@test.com.tw";
            員工2.age.data = 35;
            員工2.地址.縣市 = "台南市";
            員工2.地址.行政區 = "東區";
            員工2.地址.街道門牌 = "中華路100號";
 
            員工基本資料集合.Add(員工2);
            員工2.顯示基本資料();
        }

        private void btnWorker3_Click(object sender, EventArgs e)
        {
            string strInfo = "";

            for (int i = 0; i < 員工基本資料集合.Count; i++)
            {
                Person myperson = 員工基本資料集合[i];

                strInfo += string.Format("{0} {1:F}公分 {2:F}公斤 {3:C}元 {4:D} 年資:{5:F}年 獎金:{6:C}元\n", myperson.姓名, myperson.身高, myperson.體重, myperson.薪資, myperson.到職日, myperson.計算年資(), myperson.依年資計算獎金(1000));
                
            }

            MessageBox.Show(strInfo);
        }

        private void btnManerger_Click(object sender, EventArgs e)
        {
            manager 管理者1 = new manager("陳經理");
            管理者1.身高 = 175.0f;
            管理者1.體重 = 65.0;
            管理者1.薪資 = 60000.0;
            管理者1.到職日 = new DateTime(2010, 2, 21, 0, 0, 0);
            管理者1.部門代號 = (int)MyEunms.Dep.業務部;
            管理者1.職稱代號 = (int)MyEunms.Man.總經理;

            員工基本資料集合.Add(管理者1);
            管理者1.顯示基本資料();
            
        }
    }
}
