using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            guessNumLabel.Text = "Number of Guesses: " + Form1.guessList.Count;
            guessLabel.Text = "Guesses: ";
            guessOrderLabel.Text = "Guesses In Order: ";

            for(int i=0;i<Form1.guessList.Count;i++)
            {
                guessLabel.Text += Convert.ToString(Form1.guessList[i]);

                if (i!=Form1.guessList.Count - 1)
                {
                    guessLabel.Text += " ,";
                }
            }

            Form1.guessList.Sort();

            for (int i = 0; i < Form1.guessList.Count; i++)
            {
                guessOrderLabel.Text += Convert.ToString(Form1.guessList[i]);
                if (i != Form1.guessList.Count - 1)
                {
                    guessOrderLabel.Text += " ,";
                }
            }
        }
    }
}
