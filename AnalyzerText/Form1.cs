using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyzerText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AnalyzerBtn_Click(object sender, EventArgs e)
        {
            alphabetTB.Text = String.Join(Environment.NewLine,GetAlphaWords());
            palindromeTB.Text = String.Join(Environment.NewLine,GetPalindrome());
        }

        private List<String> GetPalindrome()
        {
            List<String> words = new List<String>(GetOnlyTextWithoutSymbols().Split());
            List<String> palindrome = new List<String>();

            bool flag;

            for (int i = 0; i < words.Count; i++)
            {
                flag = true;
                for (int j = 0; j < words[i].Length / 2; j++)
                {
                    string word = words[i];
                    if (word[j] != word[word.Length - j - 1])
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    palindrome.Add(words[i]);
                }
            }

            return palindrome;
        }

        private List<String> GetAlphaWords()
        {
            List<String> words = new List<String>(GetOnlyTextWithoutSymbols().Split());
            words =  words.Distinct().ToList();
            words.Sort();
            return words;
        }
        
        private String GetOnlyTextWithoutSymbols()
        {
            string text = inputTB.Text;
            var newText = Regex.Replace(text, "[-.?!)(,:\n\r]", "");

            return newText;
        }
    }
}
