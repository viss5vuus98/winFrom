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
    class manager : Person, IMan
    {
        public int 職稱代號 = 0;
        public manager()
        {

        }

        public manager(string myName) //建構式不繼承  所以不會複寫person的myName
        {
            姓名 = myName + " 主管";
        }

        public override double 薪資
        {
            get
            {
                return _薪資;
            }
            set 
            {
                if (value < 25250.0)
                {
                    value = 25250.0;
                }
                value += 6000;
                _薪資 = value;
            }

        }

     
        public override void 顯示基本資料()
        {
            string strInfo = String.Format($"姓名:{this.姓名}\n身高:{this.身高:F}\n體重:{this.體重:F}\n到職日:{this.到職日:D}\n薪資:{this.薪資:C}元\n部門:{顯示部門名稱(部門代號)}\n職稱:{顯示職稱(職稱代號)}\n");

            strInfo += "管理者職務";

            MessageBox.Show(strInfo);
        }

        public string 顯示職稱(int 職稱代號)
        {
            string strMan = "";
            switch (職稱代號)
            {
                case (int)MyEunms.Man.董事長:
                    strMan = "董事長";
                    break;
                case (int)MyEunms.Man.總經理:
                    strMan = "總經理";
                    break;
                case (int)MyEunms.Man.副總:
                    strMan = "副總";
                    break;
                case (int)MyEunms.Man.經理:
                    strMan = "經理";
                    break;
                case (int)MyEunms.Man.組長:
                    strMan = "組長";
                    break;
                default:
                    break;
            }

            return strMan;
        }

    }
}
