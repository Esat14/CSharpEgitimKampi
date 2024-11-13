using System;
using System.Windows.Forms;

namespace Expection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s1 * s2;
                label1.Text = sonuc.ToString();
                
            }
            catch (Exception)
            {

                throw;
            }
                Console.Read();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
