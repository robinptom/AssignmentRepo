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

namespace Assignment_Sort_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                lblSelectedFolders.Show();
                // Creating an instance of the FolderBrowserDialog//    
                DirectoryInfo folder = new DirectoryInfo(FBD.SelectedPath);
                // Get all .txt files//
                FileInfo[] allTxtFiles = folder.GetFiles("*.txt");

                // Creating an index number to search the text files by the folder//
                int dirIndex = listBox1.Items.Count;
                // Insert the selected folder in to listbox at specified index//
                listBox1.Items.Insert(dirIndex, FBD.SelectedPath);
                listBox1.Show();

                string contents;
                string[] words;
                List<string> listOfFiles = new List<string>();

                foreach (FileInfo txtFile in allTxtFiles)
                {
                    contents = File.ReadAllText(txtFile.FullName);
                    listOfFiles.Add(txtFile.Name);
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
                        if (i < wordCount - 1)
                        {
                            nextWord = words[i + 1];
                            if (currWord == nextWord)
                            {
                                repeatCounter++;
                                continue;
                            }
                        }
                        if (repeatCounter > 1)
                        {
                            sortedWords.Add(currWord + "," + repeatCounter);
                        }
                        else
                        {
                            sortedWords.Add(currWord);
                        }
                        repeatCounter = 1;
                    }

                    sortedWords.ToArray();
                    File.WriteAllText(Path.Combine(FBD.SelectedPath, "sorted" + txtFile.Name), string.Join(Environment.NewLine, sortedWords));
                    listBox2.Items.Add(txtFile.Name);
                    lblTextFiles.Show();
                    listBox2.Show();

                }
                lblMessage.Text = " SORTING COMPLETED! SELECT ANOTHER FOLDER ";
                
                //MessageBox.Show("Sorting Completed");

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
