using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayı1 = Convert.ToInt16(textBox1.Text);
                int sayı2 = Convert.ToInt16(textBox2.Text);
                int toplam = sayı1 + sayı2;
                MessageBox.Show("Toplam: " + toplam);
            }
            catch (Exception)
            {

                MessageBox.Show("düzgün değer gir");
                Console.Read();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
    
}
