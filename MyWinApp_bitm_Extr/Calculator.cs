using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp_bitm_Extr
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int firstnum = Convert.ToInt32(FirstNumtextBox.Text);
            int secondnum = Convert.ToInt32(SecondNumtextBox.Text);
            int result = firstnum - secondnum;
            ResulttextBox.Text = result.ToString();
            MessageBox.Show(" "+result);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int firstnum = Convert.ToInt32(FirstNumtextBox.Text);
            int secondnum = Convert.ToInt32(SecondNumtextBox.Text);
            int result = firstnum + secondnum;
            ResulttextBox.Text = result.ToString();
            MessageBox.Show(" " + result);
        }

        private void Multiplybutton_Click(object sender, EventArgs e)
        {
            double firstnum = Convert.ToDouble(FirstNumtextBox.Text);
            double secondnum = Convert.ToDouble(SecondNumtextBox.Text);
            double result = firstnum * secondnum;
            ResulttextBox.Text = result.ToString();
            MessageBox.Show(" " + result);
        }

        private void Dividebutton_Click(object sender, EventArgs e)
        {
            int firstnum = Convert.ToInt32(FirstNumtextBox.Text);
            int secondnum = Convert.ToInt32(SecondNumtextBox.Text);
            double result = firstnum / secondnum;
            ResulttextBox.Text = result.ToString();
            MessageBox.Show(" " + result);
        }
    }
}
