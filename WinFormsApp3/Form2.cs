using Lab3_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordList activeList = WordList.LoadList(Application.OpenForms["Form1"].Controls["listBox1"].Text);
            foreach(string s in richTextBox1.Lines)
            {
                activeList.Remove(comboBox1.SelectedIndex, s);
            }
            
            activeList.Save();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"Enter words in {comboBox1.Text} on separate lines.";
        }
    }
}
