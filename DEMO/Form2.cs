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
namespace DEMO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("E:/mosquito/pajaro/langosta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Delete("E:/mosquito/pajaro");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create("E:/mosquito/hola.txt");
        }
    }
}
