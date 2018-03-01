//Feb 28 2018
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky is #99";

            outputLabel.Text = playerName;  // Displays Wayne Gretzky



        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double Pi, radius;
            double product, area;
            Pi = 3.14;
            radius = 15;
            product = Pi * radius;
            area = product * product;

            outputLabel.Text = "\nThe area of a circle is" + area + "cm^2";

        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            //8.5 m by 6 m if the carpet has a price of 19.95 per square meter. 
            double area, price;
            double side1, side2, totalArea;
            double product;
            side1 = 8.5;
            side2 = 6;
            totalArea = side1 * side2;
            area = 51;
            price = 19.95;
            product = area * price;

            outputLabel.Text = "\nThe area of the carpet is" + totalArea + "cm^2";

            outputLabel.Text += "\nThe price of the carpet is" + product;
            
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            //• A shirt was purchased for $12.49 and was paid with a $20 bill.
            //• Calculate taxes, (HST = 13 %), total bill, and change.
            //Output the entire bill showing purchased price, taxes, total, and change.
            double shirt, taxes, taxeincluded;
            double bill, change, total;
            shirt = 12.49;
            bill = 20.00;
            taxes = 0.13;
            taxeincluded = shirt * taxes;
            total = bill - taxeincluded;

            outputLabel.Text = "The taxe on the shirt is" + taxeincluded;
            outputLabel.Text = "\nThe total change due is " + total;



        }
    }
}
