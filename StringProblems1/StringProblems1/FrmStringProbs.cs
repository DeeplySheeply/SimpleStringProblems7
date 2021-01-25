using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringProblems1
{
    public partial class FrmVowelCount : Form
    {
        public FrmVowelCount()
        {
            InitializeComponent();
        }

        public string input;

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void TxtVowels_TextChanged(object sender, EventArgs e)
        {
            input = TxtVowels.Text;
        }

        // Question 1
        private void BtnCountVowels_Click(object sender, EventArgs e)
        {
            FrmVowelCount.Increment(input);
        }

        // Question 2
        private void BtnThe_Click(object sender, EventArgs e)
        {
            FrmVowelCount.CountWord(input);
        }

        // Question 3
        private void BtnMiddle_Click(object sender, EventArgs e)
        {
            FrmVowelCount.CheckMiddle(input);
        }
        
        // Question 1
        public static void Increment(String input)
        {
            int vowel = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.ToLower(input[i]) == 'a' || char.ToLower(input[i]) == 'e' || char.ToLower(input[i]) == 'i' || char.ToLower(input[i]) == 'o' || char.ToLower(input[i]) == 'u')
                {
                    vowel++;
                }
            }

            MessageBox.Show(vowel.ToString(), "Vowel Count");
        }

        // Question 2
        public static void CountWord(String input)
        {
            int count = 0;
            string word;

            for (int i = 0; i < input.Length -2; i++)
            {
                word = input.Substring(i, 3);
                if (word.ToLower() == "the")
                {
                    count++;
                }
            }

            MessageBox.Show(count.ToString(), "Word Count");
        }

        // Question 3
        public static void CheckMiddle(String input)
        {
            if (input.Length % 2 == 0)
            {
                MessageBox.Show("This string has even numbers and thus no middle character");
            }
            else
            {
                double midBase = Math.Floor(input.Length/2.0);
                int mid = input.Length / 2;
                char middle = input[mid];
                MessageBox.Show("The middle character is: " +  middle.ToString());
            }
        }

        
    }
}
