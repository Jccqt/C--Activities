using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {   
        static ArrayList wordToGuess = new ArrayList();
        static Random randomWord = new Random();
        static StringBuilder wordShuffle = new StringBuilder();
        static StringBuilder correctWord = new StringBuilder();
        static StringBuilder playerAnswer = new StringBuilder();
        static string lastword = "";

        public frmGuessWord()
        {
            InitializeComponent();

            wordToGuess.Add("C-o-m-p-u-t-e-r");
            wordToGuess.Add("I-n-f-o-r-m-a-t-i-o-n");
            wordToGuess.Add("M-a-c-h-i-n-e");
            wordToGuess.Add("D-i-c-t-i-o-n-a-r-y");
            wordToGuess.Add("S-t-a-r- -R-a-i-l");

            shuffleWord();

            wordToGuessLabel.Text = wordShuffle.ToString();
        }

        private void resetWordBtn_Click(object sender, EventArgs e)
        {
            lastword = correctWord.ToString();

            // will shuffle while the last word is same as the current correct word
            while (lastword.Equals(correctWord.ToString()))
            {
                shuffleWord();
            }
            wordToGuessLabel.Text = wordShuffle.ToString();
            wrongGuessListBox.Items.Clear(); // will clear wrongGuessListBox if the word reset
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {   
            playerAnswer.Clear();
            playerAnswer.Append(wordGuessBox.Text.ToString());

            if (wordGuessBox.Text.Equals(""))
            {
                MessageBox.Show("The answer box is empty!");
            }
            else if(playerAnswer.Equals(correctWord))
            {
                MessageBox.Show("Correct Guess!");
                lastword = correctWord.ToString();

                // will shuffle while the last word is same as the current correct word
                while (lastword.Equals(correctWord.ToString()))
                {
                    shuffleWord();
                }
                wordToGuessLabel.Text = wordShuffle.ToString();
                wrongGuessListBox.Items.Clear(); // will clear wrongGuessListBox if the guess is correct
            }
            else
            {
                MessageBox.Show("Incorrect Guess!" +
                    "\nTry Again!");
                wrongGuessListBox.Items.Add(playerAnswer.ToString()); // will add player's wrong guess to list box
                wordGuessBox.Clear(); // will clear text box
            }
        }

        public void shuffleWord()
        {
            // will clear everytime the word got shuffled
            wordShuffle.Clear();
            correctWord.Clear();
            wordGuessBox.Clear();

            int randomNum = randomWord.Next(0, wordToGuess.Count);

            string[] word = wordToGuess[randomNum].ToString().Split('-');

            for (int i = 0; i < word.Length; i++)
            {
                correctWord.Append(word[i]);
            }

            for (int i = 1; i < word.Length - 2; i++)
            {
                word[i] = "?";
            }

            for (int i = 0; i < word.Length; i++)
            {
                wordShuffle.Append(word[i]);
            }

            Array.Clear(word, 0, word.Length); // will clear the word array
        }
    }
}
