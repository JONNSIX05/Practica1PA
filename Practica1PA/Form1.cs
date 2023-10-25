using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Practica1PA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SerialPort ps;

        private void Form1_Load(object sender, EventArgs e)
        {
            ps = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            ps.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ENCENDIDO")
            {
                button1.ForeColor = Color.Firebrick;
                ps.Write("start");
                button1.Text = "APAGADO";

            }
            else
            {
                button1.ForeColor = Color.LightGreen;
                ps.Write("stop");
                button1.Text = "ENCENDIDO";
            }
        }
    }
}
