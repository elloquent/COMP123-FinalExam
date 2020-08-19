using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    // Author Name Richard Elridge
    // Student number 301107264
    // modify 20/08/2020
    // This program is use to interact with different windows form
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this.generatenames();
        }
        //method to randomly select a name from a list box and display it in a textbox
        public void generatenames()
        {

            var random = new Random();

            int index = random.Next(0, listBox1.Items.Count);
            LastNameTextBox.Text = listBox1.Items[index].ToString();
            Program.character.Lastname = listBox1.Items[index].ToString();

            int inde = random.Next(0, FirstNameListBox.Items.Count);
            firstnametextBox.Text = FirstNameListBox.Items[inde].ToString();
            Program.character.Firstname = FirstNameListBox.Items[inde].ToString();
        }
        //this method call the generatname method and assign the value store in the properties to the relevant textboes
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.generatenames();
            firstnametextBox.Text = Program.character.Firstname;
            LastNameTextBox.Text = Program.character.Lastname;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abil = new AbilityGeneratorForm();
            abil.Show();
            this.Hide();
        }

        private void NameListGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
