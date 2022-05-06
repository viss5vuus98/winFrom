using System;
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
    class Person
    {
        //欄位
        public float 身高 = 0.0f; //field欄位
        public double 體重 = 0.0; //欄位
        public DateTime 到職日 = DateTime.Now; //欄位
        public int 部門代號 = 0;
        

        //屬性
        public string 姓名 { get; set; } //屬性 property ,  get:取值 set:存值

        protected double _薪資;
        public virtual double 薪資
        {
            get
            {//取值
                return _薪資;
            }
            set
            {//存值
                if (value < 25250)
                {
                    value = 25250;
                }
                else
                {
                    //符合最低

                }
                _薪資 = value;
            }
        }

        //泛行欄位
        public PersonInfo<string> Email = new PersonInfo<string>();
        public PersonInfo<int> age = new PersonInfo<int>();

        //結構欄位
        public AddressInfo 地址;



        public Person()
        {
            //預設建構式  不需指定資料型態 回傳的資料型態就是自己

        }

        public Person(string myName)
        {//建構方法多載
            this.姓名 = myName;  //This 這裡指向物件本身
        }

        public virtual void 顯示基本資料()    //加上virtual允許複寫
        {
            //string strInfo = $"姓名:{StringFormat.this.姓名} 身高:{this.身高} 體重:{this.體重} 到職日:{this.到職日:D} 薪資:{this._薪資}元";
            string strInfo = String.Format($"姓名:{this.姓名}\n身高:{this.身高:F}\n體重:{this.體重:F}\n到職日:{this.到職日:D}\n薪資:{this._薪資:C}元\n部門代號:{this.部門代號}\n部門名稱:{顯示部門名稱(部門代號)}\nEmail:{Email.data}\n年齡:{age.data}\n地址:{地址.完整地址()}");
            strInfo += "\n本資料由" + GobalVar.目前的使用者 + "編輯輸入";


            MessageBox.Show(strInfo);
        }

        public static void aboutInfo()
        {
            MessageBox.Show("類別名稱:Person\n功能:儲存員工基本資料\n版本:v0.1");
        }

        public double 計算年資()
        {
            double 年資 = 0.0;

            TimeSpan ts = DateTime.Now - this.到職日;
            年資 = ts.TotalDays / 365.0;

            return 年資;
        }

        public double 依年資計算獎金(double 一年獎金)
        {
            double 獎金 = Math.Ceiling(計算年資() * 一年獎金);
            if (獎金 < 500)
            {
                獎金 = 500;
            }

            return 獎金;
        }

        public string 顯示部門名稱(int 部門代號)
        {
            string strDep = "";

            switch (部門代號)
            {
                case (int)MyEunms.Dep.行政處:
                    strDep = "行政執行處";
                    break;
                case (int)MyEunms.Dep.資訊處:
                    strDep = "資訊管理處";
                    break;
                case (int)MyEunms.Dep.業務部:
                    strDep = "業績推廣部";
                    break;
                case (int)MyEunms.Dep.研發部:
                    strDep = "創新研發部";
                    break;
                default:
                    strDep = "無此部門";
                    break;
            }

            return strDep;
        }
    }
}
