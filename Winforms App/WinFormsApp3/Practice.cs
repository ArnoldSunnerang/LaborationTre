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
    public partial class Practice : Form
    {
        private WordList practiceList;
        private Word practiceWord;
        private int totalAnswers;
        private int correctAnswers;
        private bool endPractice = false;
        public Practice()
        {
            InitializeComponent();
        }

        private void Practice_Load(object sender, EventArgs e)
        {
            GetWord();
            button2.Text = "End practice";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.ToLower() == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
            {
                textBox3.Text = "Correct!";
                correctAnswers++;
                totalAnswers++;
            }
            else
            {
                textBox3.Text = $"Incorrect! The answer is {practiceWord.Translations[practiceWord.ToLanguage]}.";
                totalAnswers++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetWord();

        }

        private void GetWord()
        {
            practiceList = WordList.LoadList(Application.OpenForms["Form1"].Controls["listBox1"].Text);
            practiceWord = practiceList.GetWordToPractice();

            for (int i = 0; i < 100; i++)
            {
                if ((practiceWord.Translations[practiceWord.FromLanguage] != "") && (practiceList.Languages[practiceWord.ToLanguage] != ""))
                {
                    break;
                }
                else
                {
                    practiceWord = practiceList.GetWordToPractice();

                }
            }

            textBox1.Text = practiceWord.Translations[practiceWord.FromLanguage];
            textBox2.Text = practiceList.Languages[practiceWord.ToLanguage];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!endPractice)
            {
                textBox3.Text = $"{correctAnswers}/{totalAnswers} correct answers!";
                button3.Enabled = false;
                button1.Enabled = false;
                button2.Text = "Quit";
                endPractice = true;
            }
            else
            {
                this.Close();
            }

        }

        
        


    }
}

            
