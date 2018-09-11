using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int flag=0,Inst = 1,Determinant;
        int[] a = new int[9];
                   
        
        public Form1()
        {
            InitializeComponent();
            Set();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public void Set()
        { int s, i = 0;
            if (Inst == 1 || Inst % 2 != 0)
            { do
                {
                    flag = 0;
                    while (true)   //Generating random even variable
                    {
                        s = Randomnum();
                        if (s % 2 == 0)
                            break;
                        else
                            continue;
                    }

                    for (int k = 0; k <= i; k++) //Comparing if it is equal to any other number
                        if (s == a[k])
                            flag = 1;
                    if (flag != 1)
                    { a[i] = s;
                        i++;
                    }

                } while (i <= 8);
            }

            if (Inst % 2 == 0)
            {

                do
                {
                    flag = 0;
                    while (true)   //Generating random odd variable
                    {
                        s = Randomnum();
                        if (s % 2 != 0)
                            break;
                        else
                            continue;
                    }

                    for (int k = 0; k <= i; k++) //Comparing if it is equal to any other number
                        if (s == a[k])
                            flag = 1;
                    if (flag != 1)
                    {
                        a[i] = s;
                        i++;
                    }

                } while (i <= 8);

            }
            txt11.Text = Convert.ToString(a[0]);
            txt12.Text = Convert.ToString(a[1]);
            txt13.Text = Convert.ToString(a[2]);
            txt21.Text = Convert.ToString(a[3]);
            txt22.Text = Convert.ToString(a[4]);
            txt23.Text = Convert.ToString(a[5]);
            txt31.Text = Convert.ToString(a[6]);
            txt32.Text = Convert.ToString(a[7]);
            txt33.Text = Convert.ToString(a[8]);

            Inst++;

        }

        public int Deter()
        { int a11 = Convert.ToInt32(txt11.Text), a12 = Convert.ToInt32(txt12.Text), a13 = Convert.ToInt32(txt13.Text);
          int a21 = Convert.ToInt32(txt21.Text), a22 = Convert.ToInt32(txt22.Text), a23 = Convert.ToInt32(txt23.Text);
          int a31 = Convert.ToInt32(txt31.Text), a32 = Convert.ToInt32(txt32.Text), a33 = Convert.ToInt32(txt33.Text);

            Determinant = a11 * (a22 * a33 - a32 * a23) - a12 * (a21 * a33 - a23 * a31) + a13 * (a21 * a32 - a31 * a22);


            return Determinant;
        }

        public int Randomnum()
        { Random random = new Random();
            return random.Next(1, 101);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int a = Deter();
           
            try
            {
                if (a == Convert.ToInt64(txt_ans.Text))
                {
                    new Cong().ShowDialog();
                    label2.Text = "Attempt: " + Inst.ToString();
                    Set();
                    txt_ans.Text = "";
                }
                else
                {
                    new Incorr().ShowDialog();

                }

            }
            
           
            catch (NullReferenceException n)
            {
                Console.WriteLine("Wrong input,try again", n);

            }


            if (Inst == 7)
                new Finish().ShowDialog();

        }

        private void txt_ans_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_ans_Click(object sender, EventArgs e)
        {

         }
        private void txt_ans_Leave(object sender, EventArgs e)
        {
          
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt32_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt33_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
