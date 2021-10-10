using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 魔術方陣
{
    public partial class Form1 : Form
    {
            Random rd = new Random();
            int[] a = new int[9];
            Button[] btn = new Button[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
            set();
            int[] check = new int[6];
            check[0] = a[0] + a[3] + a[6];
            check[1] = a[1] + a[4] + a[7];
            check[2] = a[2] + a[5] + a[8];
            check[3] = a[0] + a[1] + a[2];
            check[4] = a[3] + a[4] + a[5];
            check[5] = a[6] + a[7] + a[8];
            for(int i=0;i<6;i++)
            {
                while(check[i]!=15)
                {
                    set();
                }
            }
            
        }
        void set()
        {
            
            for (int i = 0; i < 9; i++)
            {
                a[i] = rd.Next(1,10);
                for (int j = 0; j < i; j++)
                {
                    while (a[i] == a[j])
                    {
                        a[i] = rd.Next(1, 10);
                        j = 0;
                    }           
                }
                btn[i].Text = a[i].ToString();
            }
        }
    }
}
