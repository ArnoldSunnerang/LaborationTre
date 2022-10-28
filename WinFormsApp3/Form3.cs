using Lab3_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordList activeList = WordList.LoadList(Application.OpenForms["Form1"].Controls["listBox1"].Text);
            string[] translation = new string[textBox1.Lines.Length];
            
            for(int i = 0; i < translation.Length; i++)
            {
                if (i < textBox1.Lines.Length)
                {
                    translation[i] = textBox1.Lines[i];

                }
                else
                {
                    translation[i] = "";
                }
            }
            
            activeList.Add(translation);
            activeList.Save();

            this.Close();
        }
    }
}
                
                



