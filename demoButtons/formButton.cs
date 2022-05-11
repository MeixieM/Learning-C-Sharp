using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoButtons
{
    public partial class Form1 : Form
    {
        int theIncrementingNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_Hover(object sender, EventArgs e)
        {
            theIncrementingNumber++;
            Button buttonThatYouPoint = (Button)sender;
            buttonThatYouPoint.Text = theIncrementingNumber.ToString();
            buttonThatYouPoint.BackColor = Color.Red;
        }

        private void button_Leaves(object sender, EventArgs e)
        {
            Button buttonThatYouLeft = (Button)sender;
            buttonThatYouLeft.BackColor = Color.LightGray;
            buttonThatYouLeft.ForeColor = Color.Black;

        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button buttonThatYouClicked = (Button)sender;
            buttonThatYouClicked.BackColor = Color.Black;
            buttonThatYouClicked.ForeColor = Color.White;
            buttonThatYouClicked.Text = "UwU";
        }

    }
}
