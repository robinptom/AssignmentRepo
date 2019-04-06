using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo folder = new DirectoryInfo(FBD.SelectedPath);
                FileInfo[] allTxtFiles = folder.GetFiles("*.txt");
                listBox1.Items.Add(FBD.SelectedPath);

                string contents;
                string[] words;

                foreach (FileInfo txtFile in allTxtFiles)
                {
                    contents = File.ReadAllText(txtFile.FullName);
                    words = contents.Split('\n', '\r', ' ');
                    Array.Sort(words);
                    int wordCount = words.Length;

                    string currWord;
                    string nextWord;
                    int repeatCounter = 1;
                    List<string> sortedWords;
                    sortedWords = new List<string>();

                    for (int i = 0; i < wordCount; i++)
                    {
                        currWord = words[i];
                        if (i<wordCount-1)
                        {
                            nextWord = words[i + 1];
                            if (currWord == nextWord)
                            {
                                repeatCounter++;
                                sortedWords.Add(currWord + "," + repeatCounter);
                                continue;
                            }
                            else
                            {
                                sortedWords.Add(currWord);
                            }
                            repeatCounter = 1;
                        }
                        sortedWords.Add(currWord);                                     
                    
                    }
                    sortedWords.ToArray();
                    File.WriteAllText(Path.Combine(FBD.SelectedPath, "sorted" + txtFile.Name), string.Join(Environment.NewLine, sortedWords));
                    MessageBox.Show("Sorting Completed");
                }

            }

        }
    }
}
