using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSecurity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int key = (Convert.ToInt16(textBox2.Text)) % 26;
            int base_line1 = 97;
            int base_line2 = 110;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                int ascii_delet = Convert.ToInt16(textBox1.Text.ToCharArray()[i]);
                if (textBox1.Text[i] <= 'm' && textBox1.Text[i] >= 'a')
                {
                    ascii_delet -= base_line1;
                    int block = (ascii_delet + key) % 13;
                    textBox3.Text += (Char)(block + base_line2);
                }
                if (textBox1.Text[i] <= 'z' && textBox1.Text[i] >= 'n')
                {
                    ascii_delet -= base_line1;
                    int block = (ascii_delet + key) % 13;
                   
                    textBox3.Text += (Char)(block + base_line1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         int key = (Convert.ToInt16(textBox2.Text)) % 26;
            int base_line1 = 97;
            int base_line2 = 110;

            for (int i = 0; i < textBox1.TextLength; i++)
            {
                int ascii_delet = Convert.ToInt16(textBox1.Text.ToCharArray()[i]);
                
            if (textBox1.Text[i] <= 'm' && textBox1.Text[i] >= 'a')
                    {
                    
                    ascii_delet -= base_line1;
                    int block = (ascii_delet - key) % 13;
                    if (block < 0)
                    {
                        block += 13;
                    }
                    textBox3.Text += (Char)(block + base_line2);
                }


                if (textBox1.Text[i] <= 'z' && textBox1.Text[i] >= 'n')
                {
                    ascii_delet -= base_line2;
                    int block = (ascii_delet - key) % 13;
                    if (block<0)
                    {
                        block += 13;
                    }
                    textBox3.Text += (Char)(block + base_line1);

                }
            }
        }
    }
}
