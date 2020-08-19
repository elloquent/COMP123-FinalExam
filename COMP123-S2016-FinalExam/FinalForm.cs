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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // populating the textboxes when the form loads
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Character character = Program.character;

             StrengthTextBox.Text = character.Strength;
              DexterityTextBox.Text = character.Dexterity;
              ConstitutionTextBox.Text = character.Constitution;
              IntelligenceTextBox.Text = character.Intelligence;
              WisdomTextBox.Text = character.Wisdom;
              CharismaTextBox.Text = character.Charisma;
            radiotextBox.Text = Program.character.Race;
           firsttextBox.Text = Program.character.Firstname;
            LastNameTextBox.Text = Program.character.Lastname;

        }
    }
}
