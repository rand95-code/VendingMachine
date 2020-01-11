using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        int depositAmount = 0;  
        int deductAmount = 0;
        int returnAmount = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        //START DENOMINATIONS 
        private void button1_Click(object sender, EventArgs e)
        {
            depositAmount += 1;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            depositAmount += 5;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button3_Click(object sender, EventArgs e)
        {
            depositAmount += 10;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button6_Click(object sender, EventArgs e)
        {
            depositAmount += 20;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button5_Click(object sender, EventArgs e)
        {
            depositAmount += 50;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button4_Click(object sender, EventArgs e)
        {
            depositAmount += 100;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button8_Click(object sender, EventArgs e)
        {
            depositAmount += 500;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }

        private void button7_Click(object sender, EventArgs e)
        {
            depositAmount += 1000;                             //Add amount to the current deposit amount
            depositLabel.Text = depositAmount.ToString();   //Display the deposit amount in the deposit label
        }
        //END DENOMINATIONS

        private void button10_Click(object sender, EventArgs e)
        {
            if (depositAmount >= 10)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 10;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 10;
                depositLabel.Text = depositAmount.ToString();
                
            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (depositAmount >= 10)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 10;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 10;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (depositAmount >= 22)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 22;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 22;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (depositAmount >= 10)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 10;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 10;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (depositAmount >= 10)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 10;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 10;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (depositAmount >= 22)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 22;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 22;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (deductAmount > 0)
            {
                returnLabel.Text = depositAmount.ToString();
          
                depositAmount = 0;
                deductAmount = 0;
                depositLabel.Text = "0";
                deductLabel.Text = "0";
                string message = "Items purchased successfully. Change returned.\nDone!";
                MessageBox.Show(message);
                returnAmount = 0;
                depositAmount = 0;
                deductAmount = 0;

                returnLabel.Text = "0";
                depositLabel.Text = "0";
                deductLabel.Text = "0";
              
            }
            else
            {
                string message = "Please choose items first.";
                MessageBox.Show(message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            returnAmount = depositAmount + deductAmount;
            returnLabel.Text = returnAmount.ToString();
            depositLabel.Text = "0";
            deductLabel.Text = "0";

            returnAmount = 0;
            depositAmount = 0;
            deductAmount = 0;
            string message = "Order cancelled.";
            MessageBox.Show(message);
            returnAmount = 0;
            depositAmount = 0;
            deductAmount = 0;

            returnLabel.Text = "0";
            depositLabel.Text = "0";
            deductLabel.Text = "0";
            
        }



        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int price = 22;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            int price = 25;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
        {

            if (depositAmount >= 20)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += 20;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= 20;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }


        }

        private void button20_Click(object sender, EventArgs e)
        {
            int price = 45;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int price = 24;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int price = 22;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int price = 10;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int price = 45;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int price = 55;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int price = 60;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int price = 65;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int price = 35;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int price = 50;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int price = 10;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int price = 10;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int price = 10;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int price = 10;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int price = 10;
            if (depositAmount >= price)
            {
                string message = "Ok.";
                MessageBox.Show(message);

                deductAmount += price;
                deductLabel.Text = deductAmount.ToString();
                depositAmount -= price;
                depositLabel.Text = depositAmount.ToString();

            }
            else
            {
                string message = "Not enough cash. Please recharge.";
                MessageBox.Show(message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
