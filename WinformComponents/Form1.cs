using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Both;

            textBox1.KeyPress += TextBox1_KeyPress;

            textBox1.LostFocus += TextBox1_LostFocus;
            textBox1.GotFocus += TextBox1_GotFocus;

            numericUpDown1.LostFocus += NumericUpDown1_LostFocus;
            numericUpDown1.GotFocus += NumericUpDown1_GotFocus;

            label1.LostFocus += Label1_LostFocus;
            label1.GotFocus += Label1_GotFocus;

            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;

            listBox1.SelectedIndexChanged += ListBox1_Index;

            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
        }
        private void ListBox1_Index(object sender, System.EventArgs e)
        {
            String a = listBox1.SelectedIndex.ToString();
            logger("ListBox1 Index: " + a);
        }

        private void PictureBox1_MouseEnter(object sender, System.EventArgs e)
        {
            logger("PictureBox1_MouseEnter");
        }
        private void PictureBox1_MouseLeave(object sender, System.EventArgs e)
        {
            logger("PictureBox1_MouseLeave");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClick(EventArgs e)
        {
            logger("OnClick");
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            logger("OnDoubleClick");
        }

        
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            messagesTextBox.AppendText($"KeyPress keychar: {e.KeyChar}" + "\r\n");
        }

        //Focus -----------
        private void TextBox1_LostFocus(object sender, System.EventArgs e)
        {
            logger("TextBox1_LostFocus");
        }
        private void TextBox1_GotFocus(object sender, System.EventArgs e)
        {
            logger("TextBox1_GotFocus");
        }
        private void NumericUpDown1_LostFocus(object sender, System.EventArgs e)
        {
            logger("NumericUpDown1_LostFocus");
        }

        private void NumericUpDown1_GotFocus(object sender, System.EventArgs e)
        {
            logger("NumericUpDown1_GotFocus");
        }

        private void Label1_GotFocus(object sender, System.EventArgs e)
        {
            logger("Label1_GotFocus");
        }
        private void Label1_LostFocus(object sender, System.EventArgs e)
        {
            logger("NumericUpDown1_LostFocus");
        }


        //End Focus ---------------

        private void NumericUpDown1_ValueChanged(Object sender, EventArgs e)
        {
            String a = numericUpDown1.Value.ToString();
            logger("NumericUpDown1_ValueChanged to " + a);
        }

        public void logger(String evento)
        {
            //messagesTextBox.Text = (evento + Environment.NewLine);
            messagesTextBox.Text += System.Environment.NewLine + evento;
            //MessageBox.Show("You are in the Control.GotFocus event.");
        }
    }
}
