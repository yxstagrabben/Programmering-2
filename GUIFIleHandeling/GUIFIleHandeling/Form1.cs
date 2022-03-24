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

namespace GUIFIleHandeling
{
    public partial class Form1 : Form
    {
        string sTextBox;
        string filePath = "data.csv";
        int iLine;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            displayFileContents();
        }
        private void displayFileContents()
        {
            using(var reader = new StreamReader(filePath))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    displayData.Items.Add(values[iLine]);
                    iLine += 1; 
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            try
            {
                sTextBox = inputBox.Text;
                if (sTextBox != null)
                {
                    inputBox.Clear();
                    displayData.Items.Add(sTextBox);
                    csv.AppendLine(sTextBox);
                    File.WriteAllText(filePath, csv.ToString());
                }
                else
                {

                }
            }
            catch(Exception ex)
            {

            }
            finally
            { 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
