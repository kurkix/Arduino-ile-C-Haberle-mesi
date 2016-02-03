using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
                
                serialPort1.PortName = "COM5";
                serialPort1.BaudRate = 9600;
            
        }

        private void yak_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("1");
            serialPort1.Close();
        }

        private void sondur_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
        }
    }
}
