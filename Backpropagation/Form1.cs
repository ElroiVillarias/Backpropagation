using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//extra libraries
using Backprop;
using Backpropagation;

namespace Backpropagation
{
    public partial class Form1 : Form
    {

        NeuralNet net;

        public Form1()
        {
            InitializeComponent();
        }

        //Generate Neural Net
        private void button1_Click(object sender, EventArgs e)
        {
            net = new NeuralNet(4, 32, 1);
        }

        //Train Neural Net
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 512; i++)
            {
                net.setInputs(0, 0.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 0.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 0.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 0.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 0.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 0.0);
                net.learn();

                net.setInputs(0, 1.0);
                net.setInputs(1, 1.0);
                net.setInputs(2, 1.0);
                net.setInputs(3, 1.0);
                net.setDesiredOutput(0, 1.0);
                net.learn();
            }

        }

        //Test Neural Net
        private void button3_Click(object sender, EventArgs e)
        {
            net.setInputs(0, Convert.ToDouble(textBox1.Text));
            net.setInputs(1, Convert.ToDouble(textBox2.Text));
            net.setInputs(2, Convert.ToDouble(textBox3.Text));
            net.setInputs(3, Convert.ToDouble(textBox4.Text));
            net.run();

            textBox5.Text = "" + net.getOuputData(0);
        }
    }
}
