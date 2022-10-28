using Lab3_Class_Library;
using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private WordList activeList;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void searchAndRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            string[] languages = new string[listBox3.Items.Count];
            
            listBox3.Items.CopyTo(languages, 0);
            (form2.Controls["comboBox1"] as ComboBox).Items.AddRange(languages);
            form2.ShowDialog();

            UpdateWords();
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            string[] languages = new string[listBox3.Items.Count];

            listBox3.Items.CopyTo(languages, 0);
            (form3.Controls["textBox1"] as TextBox).PlaceholderText = String.Join("\n", languages);
            form3.ShowDialog();

            UpdateWords();

        }
        
        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(WordList.GetLists());
            UpdateWords();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practice practice = new Practice();
            listBox2.Items.Clear();
            practice.ShowDialog();

            UpdateWords();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeList = WordList.LoadList(listBox1.Text);
            List<string> showLanguages = activeList.Languages.ToList();

            listBox3.Items.Clear();
            listBox3.Items.AddRange(showLanguages.ToArray());
            try
            {
                listBox3.SelectedIndex = 0;

            }
            catch
            {

            }

            UpdateWords();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(WordList.GetLists());
            activeList = WordList.LoadList(listBox1.Text);
            UpdateWords();
        }
            
        private void removeWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            activeList.Remove(0, listBox2.Text.Split("; ")[0]);
            activeList.Save();

            UpdateWords();

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWords();

        }

        private void removeSelectedWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            activeList.Remove(0, listBox2.Text.Split("; ")[0]);
            activeList.Save();

            UpdateWords();

        }
        private void UpdateWords()
        {
            listBox2.Items.Clear();
            activeList = WordList.LoadList(listBox1.Text);
            List<string> showWords = new List<string>();
            activeList.List(listBox3.SelectedIndex, x => showWords.Add(String.Join("; ", x)));
            listBox2.Items.AddRange(showWords.ToArray());
            textBox1.Text = $"List containing {activeList.Count()} words, sorted by {listBox3.Text}.";
        }

    }
}






        
