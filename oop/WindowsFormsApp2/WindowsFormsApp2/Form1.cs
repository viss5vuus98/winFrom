using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string msg);

        public Form1()
        {
            InitializeComponent();
        }
        void MethodOne(string MyMsg)
        {
            string strOut = "MathodOne 執行, 傳遞參數:" + MyMsg;
            MessageBox.Show(strOut);
        }

        void passDekegateMethod(MyDelegate myDelegateObj)
        {
            myDelegateObj("成功執行");
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            MyDelegate delegateTest = MethodOne;
            passDekegateMethod(delegateTest);
        }
        

        private void btnAct_Click(object sender, EventArgs e)
        {
            Action<int, int> actionPlus = plus; 
            //<int, int>裡是物件後方法的參數 (int a, int b)
            actionPlus(7, 8);
        }

        void plus(int a, int b)
        {
            int sum = a + b;
            MessageBox.Show("action demo:" + sum);
        }


        private void btnFun_Click(object sender, EventArgs e)
        {
            Func<int, int, int, int> funcSum = sum;
            //第四個參數是回傳值
            MessageBox.Show("Func demo:" + funcSum(1, 2, 3));
        }

        int sum(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

    }
}
