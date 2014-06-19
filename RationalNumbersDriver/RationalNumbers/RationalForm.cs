using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RationalNS
{
    public partial class RationalForm : Form
    {
        public RationalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Rational num1 = new Rational(6,8);
             Rational num2 = new Rational();
             Rational result = new Rational();
             Rational error = new Rational(3,0);
             Rational zero = new Rational();
             Rational num3 = new Rational(2,4);
             Rational num4 = new Rational(5,10);

            num2.Assign(13,4);
            result = num1 * num2;
            txtOutput.Text = "num1 is : " + num1.Fraction +
                "\r\nnum2 is : " + num2.Fraction + "\r\nThe result of " +
                num1.Fraction + " multipliedBy " + num2.Fraction +
                " is " + result.Fraction + " or " + result.MixedFraction;

            result = num1 / num2;
            txtOutput.Text += "\r\n\r\nnum1 is : " + num1.Fraction +
                "\r\nnum2 is : " + num2.Fraction + "\r\nThe result of " + 
                num1.Fraction + " dividedBy " + num2.Fraction +
                " is " + result.Fraction + " or " + result.MixedFraction; 

            result = num1 - num2;
            txtOutput.Text += "\r\n\r\nnum1 is : " + num1.Fraction +
                "\r\nnum2 is : " + num2.Fraction + "\r\nThe result of " +
                num1.Fraction + " subtract " + num2.Fraction +
                " is " + result.Fraction + " or " + result.MixedFraction;

            result = num1 + num2;
            txtOutput.Text += "\r\n\r\nnum1 is : " + num1.Fraction +
                "\r\nnum2 is : " + num2.Fraction + "\r\nThe result of " +
                num1.Fraction + " add " + num2.Fraction +
                " is " + result.Fraction + " or " + result.MixedFraction;

            result = num2 - num1;
            txtOutput.Text += "\r\n\r\nnum1 is : " + num1.Fraction +
                "\r\nnum2 is : " + num2.Fraction + "\r\nThe result of " +
                num2.Fraction + " subtract " + num1.Fraction +
                " is " + result.Fraction + " or " + result.MixedFraction;
            
            txtOutput.Text += "\r\n\r\nnum1 is : " + num1.Fraction +
                "\r\nnum2 is : " + num2.Fraction +"\r\nnum1" +
                (num1 < num2 ? " < " : (num1 == num2 ? " == " : " > ")) + "num2";

            txtOutput.Text += "\r\n\r\nerror is : " + error.Fraction +
                "\r\nzero is : " + zero.Fraction + "\r\nerror" +
                (error < zero ? " < " : (error == zero ? " == " : " > ")) + "zero";

            txtOutput.Text += "\r\n\r\nnum3 is : " + num3.Fraction +
            "\r\nnum4 is : " + num4.Fraction + "\r\nnum3" +
            (num3 < num4 ? " < " : (num3 == num4 ? " == " : " > ")) + "num4";

            //test override of Obj.Equals(obj)
            txtOutput.Text += "\r\n\r\nnum3 is : " + num3.Fraction +
                "\r\nnum4 is : " + num4.Fraction + "\r\nnum3" +
                (num3 < num4 ? " < " : (num3.Equals(num4) ? " Equals " : " > ")) + "num4";

            txtOutput.Text += "\r\n\r\nnum4 is : " + num4.Fraction +
            "\r\nnum3 is : " + num3.Fraction + "\r\nnum4" +
            (num4 < num3 ? " < " : (num4 == num3 ? " == " : " > ")) + "num3";

            txtOutput.Text += "\r\n\r\nnum2 is : " + num2.Fraction +
            "\r\nnum1 is : " + num1.Fraction + "\r\nnum2" +
            (num2 < num1 ? " < " : (num2 == num1 ? " == " : " > ")) + "num1";

            //for completeness, set the objects' pointers to null and 
            //call garbage collection.
            num1 = num2 = num3 = num4 = result = error = zero = null;
            GC.Collect();

        } // end button1_Click

 
      }//end Public Partional Class Form1

    }
