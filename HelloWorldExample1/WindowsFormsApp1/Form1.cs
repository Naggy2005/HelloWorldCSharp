using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelloWorldExample;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make a car
            Car myBMW = new Car("BMW", "325xi", 2006, "WA200522", "Red", "Leather");
            //show info about the car on the label
            label1.Text = myBMW.make.ToString();
            List<Car> list = new List<Car>();
        }
    }
}
