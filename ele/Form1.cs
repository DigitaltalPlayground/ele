using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountExe()
        {
            this.label2.Text = $"えぇカウント: {this.textBox1.Text.Split(new[] { "えぇ" }, StringSplitOptions.None).Length - 1}回";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => this.CountExe();

        private void textBox1_KeyUp(object sender, KeyEventArgs e) => this.CountExe();

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("えぇ...", "えぇ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            return;
            string str = Clipboard.GetText(TextDataFormat.Text);
            if(str.Split(new[] {"えぇ"}, StringSplitOptions.None).Length - 1 > 0)
            {
                this.textBox1.Text = str;
                this.CountExe();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
