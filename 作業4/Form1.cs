using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業4
{
    public partial class Form1 : Form
    {
        int 杯數1 = 0, 杯數2 = 0, 杯數3 = 0, 杯數4 = 0, 杯數5 = 0;
        double 售價1 = 0.0, 售價2 = 0.0, 售價3 = 0.0, 售價4 = 0.0, 售價5 = 0.0;
        double 品項1總價 = 0.0, 品項2總價 = 0.0, 品項3總價 = 0.0, 品項4總價 = 0.0, 品項5總價 = 0.0;
        double 折數 = 10.0;
        double 總價 = 0.0;
        double 折扣後總價 = 0.0;
        int[] arrayCupNum ;
        double[] arrayPrice;
        double[] arrayTotal;



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl品項1.Text = "麥香紅茶";
            lbl品項2.Text = "茉香綠茶";
            lbl品項3.Text = "珍珠奶茶";
            lbl品項4.Text = "玫瑰花茶";
            lbl品項5.Text = "新鮮水果茶";

            售價1 = 35.0;
            售價2 = 40.0;
            售價3 = 45.0;
            售價4 = 50.0;
            售價5 = 55.0;

            lbl售價1.Text = 售價1.ToString();
            lbl售價2.Text = 售價2.ToString();
            lbl售價3.Text = 售價3.ToString();
            lbl售價4.Text = 售價4.ToString();
            lbl售價5.Text = 售價5.ToString();

           

            arrayPrice = new double[5] {35.0,40.0,45.0,50.0,55.0 };

            arrayTotal = new double[5];

        }

        private void btn杯數1減_Click(object sender, EventArgs e)
        {
            btn杯數1加.Enabled = true;

            if (杯數1 > 0)
            {
                杯數1 -= 1;
            }
            else
            {
                btn杯數1減.Enabled = false;
                MessageBox.Show("已為最小值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb杯數1.Text = 杯數1.ToString();
        }

        private void btn杯數1加_Click(object sender, EventArgs e)
        {           
            if (杯數1 < 99)
            {
                杯數1 += 1;
                btn杯數1減.Enabled = true;
                tb杯數1.Text = 杯數1.ToString();

            }
            else
            {
                btn杯數1加.Enabled = false; 
                MessageBox.Show("以為最大值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            
        }

        private void tb杯數1_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數1.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數1.Text, out 杯數1);

                if ((ifNum == true) && (杯數1 >= 0))
                {
                    //btn杯數1減.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請輸入正確杯數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tb杯數1.Text = "0";
               
            }
            計算總價();
        }

        private void btn杯數2減_Click(object sender, EventArgs e)
        {
            btn杯數2加.Enabled = true;
            if (杯數2 > 0)
            {
                杯數2 -= 1;
            }
            else
            {
                btn杯數2減.Enabled = false;
                MessageBox.Show("已為最小值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb杯數2.Text = 杯數2.ToString();
        }

        private void btn杯數2加_Click(object sender, EventArgs e)
        {
            if (杯數2 < 99)
            {
                杯數2 += 1;
                btn杯數2減.Enabled = true;
                tb杯數2.Text = 杯數2.ToString();

            }
            else
            {
                btn杯數2加.Enabled = false;
                MessageBox.Show("以為最大值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        private void tb杯數2_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數2.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數2.Text, out 杯數2);

                if ((ifNum == true) && (杯數2 >= 0))
                {
                    //btn杯數1減.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請輸入正確杯數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tb杯數2.Text = "0";
            }

            計算總價();
        }

        private void btn杯數3減_Click(object sender, EventArgs e)
        {
            btn杯數3加.Enabled = true;
            if (杯數3 > 0)
            {
                杯數3 -= 1;
            }
            else
            {
                btn杯數3減.Enabled = false;
                MessageBox.Show("已為最小值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb杯數3.Text = 杯數3.ToString();
        }

        private void btn杯數3加_Click(object sender, EventArgs e)
        {
            if (杯數3 < 99)
            {
                杯數3 += 1;
                btn杯數3減.Enabled = true;
                tb杯數3.Text = 杯數3.ToString();
            }
            else
            {
                btn杯數3加.Enabled = false;
                MessageBox.Show("以為最大值!", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb杯數3_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數3.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數3.Text, out 杯數3);

                if ((ifNum == true) && (杯數3 >= 0))
                {
                    //btn杯數1減.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請輸入正確杯數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tb杯數3.Text = "0";
            }
            計算總價();
        }

        private void btn杯數4減_Click(object sender, EventArgs e)
        {
            btn杯數4加.Enabled = true;
            if (杯數4 > 0)
            {
                杯數4 -= 1;
            }
            else
            {
                btn杯數4減.Enabled = false;
                MessageBox.Show("已為最小值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb杯數4.Text = 杯數4.ToString();
        }

        private void btn杯數4加_Click(object sender, EventArgs e)
        {

            if (杯數4 < 99)
            {
                杯數4 += 1;
                btn杯數4減.Enabled = true;
                tb杯數4.Text = 杯數4.ToString();
            }
            else
            {
                btn杯數4加.Enabled = false;
                MessageBox.Show("以為最大值!", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb杯數4_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數4.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數4.Text, out 杯數4);

                if ((ifNum == true) && (杯數4 >= 0))
                {
                    //btn杯數1減.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請輸入正確杯數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tb杯數4.Text = "0";
            }

            計算總價();
        }

        private void btn杯數5減_Click(object sender, EventArgs e)
        {
            btn杯數5加.Enabled = true;
            if (杯數5 > 0)
            {
                杯數5 -= 1;
            }
            else
            {
                btn杯數5減.Enabled = false;
                MessageBox.Show("已為最小值", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb杯數5.Text = 杯數5.ToString();

        }

        private void btn杯數5加_Click(object sender, EventArgs e)
        {
            
            if (杯數5 < 99)
            {
                杯數5 += 1;
                btn杯數5減.Enabled = true;
                tb杯數5.Text = 杯數5.ToString();
            }
            else
            {
                btn杯數5加.Enabled = false;
                MessageBox.Show("已為最大值!", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb杯數5_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數5.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數5.Text, out 杯數5);

                if ((ifNum == true) && (杯數5 >= 0))
                {
                    //btn杯數1減.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請輸入正確杯數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tb杯數5.Text = "0";
            }

            計算總價();
            
        }

        private void tb折數_TextChanged(object sender, EventArgs e)
        {
            if (tb折數.Text != "")
            {
                bool ifNum = System.Double.TryParse(tb折數.Text, out 折數);

                if (ifNum == true)
                {
                    if ((折數 >= 0.0) && (折數 <= 10.0))
                    {
                        //合理折數
                    }
                    else
                    {
                        MessageBox.Show("折數輸入錯誤(0.0-10.0)", "錯誤");
                        tb折數.Text = "";
                        折數 = 10.0;
                    }
                }
               
            }
            else
            {
                折數 = 10.0;
            }

            計算總價();

        }

        private void btn列印訂購單_Click(object sender, EventArgs e)
        {
            DialogResult drResult;

            drResult = MessageBox.Show("您確認送出訂購單?", "訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drResult == DialogResult.No)
            {
                //取消送出
            }
            else
            {
                //確認訂單
                string strOder = "***** HyuGo冷飲店訂購單 *****\n";
                strOder += "\n";

                strOder += "--------------------\n";

                if (杯數1 > 0)
                {
                    strOder += lbl品項1.Text + " : " + lbl售價1.Text + " x " + tb杯數1.Text + " = " + 品項1總價.ToString() + "\n";

                }

                if (杯數2 > 0)
                {
                    strOder += lbl品項2.Text + " : " + lbl售價2.Text + " x " + tb杯數2.Text + " = " + 品項2總價.ToString() + "\n";

                }

                if (杯數3 > 0)
                {
                    strOder += lbl品項3.Text + " : " + lbl售價3.Text + " x " + tb杯數3.Text + " = " + 品項3總價.ToString() + "\n";

                }

                if (杯數4 > 0)
                {
                    strOder += lbl品項4.Text + " : " + lbl售價4.Text + " x " + tb杯數4.Text + " = " + 品項4總價.ToString() + "\n";

                }

                if (杯數5 > 0)
                {
                    strOder += lbl品項5.Text + " : " + lbl售價5.Text + " x " + tb杯數5.Text + " = " + 品項5總價.ToString() + "\n";

                }
                strOder += "-------------------------\n";


                if (折數 < 10)
                {
                    strOder += "折數 :" + string.Format("{0:F2}", 折數) + "\n";
                }

                strOder += "訂單總價 : " + string.Format("{0:F2}", 總價) + "\n";
                strOder += "折扣後總價 : " + string.Format("{0:F2}", lbl折扣總價.Text) + "\n";

                strOder += string.Format("{0:D}", DateTime.Now) + "\n";

                MessageBox.Show(strOder, "訂單明細", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn第二件六折_Click(object sender, EventArgs e)
        {
            arrayCupNum = new int[5] {杯數1,杯數2, 杯數3,杯數4,杯數5 };
            arrayPrice = new double[5] { 售價1, 售價2, 售價3, 售價4, 售價5 };
            double 活動總價1 = 0.0;
            
            for (int i = 0; i <= arrayCupNum.GetUpperBound(0); i++)
            {
                if (arrayCupNum[i] % 2 == 0)
                {
                    活動總價1 += (arrayCupNum[i] / 2) * (arrayPrice[i] * 1.6);
                }
                else
                {
                    活動總價1 += (arrayCupNum[i] / 2) * (arrayPrice[i] * 1.6)+arrayPrice[i];
                }
            }       

            折扣後總價 = 總價 * 折數 / 10.0;

            lbl訂單總價.Text = string.Format("{0:C}", 折扣後總價);
            lbl折扣總價.Text = string.Format("{0:C}", 活動總價1);
        }

        private void btn買三送一_Click(object sender, EventArgs e)
        {
            arrayCupNum = new int[5] { 杯數1, 杯數2, 杯數3, 杯數4, 杯數5 };
            arrayPrice = new double[5] { 售價1, 售價2, 售價3, 售價4, 售價5 };
            double 活動總價 = 0.0;
            double 活動折扣總價 = 0.0; 

            double 比價 = 100;
            int 總杯數 = 杯數1+杯數2+ 杯數3+ 杯數4+ 杯數5;

          

                for (int j = 0; j <= arrayCupNum.GetUpperBound(0); j++)
                {
                    if (arrayCupNum[j] != 0)
                    {
                        if (比價 >= arrayPrice[j])
                        {
                            比價 = arrayPrice[j];
                        }
                    }                       
                }           
           
            for (int i = 0; i <= arrayCupNum.GetUpperBound(0); i++)
            {
                活動總價 += arrayCupNum[i] * arrayPrice[i];
            }


            活動折扣總價 = 活動總價 - (總杯數 / 4) * 比價;

            lbl訂單總價.Text = string.Format("{0:C}", 活動總價);
            lbl折扣總價.Text = string.Format("{0:C}", 活動折扣總價);
        }

        void 計算總價()
        {
            品項1總價 = 售價1 * 杯數1;
            品項2總價 = 售價2 * 杯數2;
            品項3總價 = 售價3 * 杯數3;
            品項4總價 = 售價4 * 杯數4;
            品項5總價 = 售價5 * 杯數5;

            總價 = 品項1總價 + 品項2總價 + 品項3總價 + 品項4總價 + 品項5總價;
            折扣後總價 = 總價 * 折數 / 10.0;


            lbl訂單總價.Text = string.Format("{0:C}", 總價);
            lbl折扣總價.Text = string.Format("{0:C}", 折扣後總價);
        }
    }
}
