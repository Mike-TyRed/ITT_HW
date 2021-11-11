using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SubProcesos
{
    public partial class Form1 : Form
    {
        public int counter = 0;
        public int counter1 = 0;
        public int counter2 = 0;
        public int counter3 = 0;

         
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Start();

            IniciarProgressbar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void IniciarProgressbar()
        {
            pgb1.Step = 1;
            pgb2.Step = 1;
            pgb3.Step = 1;
            pgb1.Value = 0;
            pgb2.Value = 0;
            pgb3.Value = 0;
            pgb1.Maximum = 100;
            pgb2.Maximum = 100;
            pgb3.Maximum = 100;
            pgb1.Minimum = 0;
            pgb2.Minimum = 0;
            pgb3.Minimum = 0;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ThreadStart newThread1 = new ThreadStart(thread1);
            Thread t1 = new Thread(newThread1);
            t1.Start();
            ThreadStart newThread2 = new ThreadStart(thread2);
            Thread t2 = new Thread(newThread2);
            t2.Start();
            ThreadStart newThread3 = new ThreadStart(thread3);
            Thread t3 = new Thread(newThread3);
            t3.Start();
        }
        private void thread1()
        {
            for(int i = 0; counter1 < 1000000000; i++)
            {
                counter1++;
            }
        }
        private void thread2()
        {
            for (int i = 0; counter2 < 1000000000; i++)
            {
                counter2 += 2;
            }
        }
        private void thread3()
        {
            for (int i = 0; counter3 < 1000000000; i++)
            {
                counter3 += 4;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double tmp = 0.00;
            counter++;
            txtb4.Text = counter.ToString();
            txtb1.Text = counter1.ToString();
            txtb2.Text = counter2.ToString();
            txtb3.Text = counter3.ToString();

            if (counter1 > 1)
            {
                tmp = ((double)counter1 / 1000000000) * 100;
                pgb1.Value = (int)tmp;
                tmp = ((double)counter2 / 1000000000) * 100;
                pgb2.Value = (int)tmp;
                tmp = ((double)counter3 / 1000000000) * 100;
                pgb3.Value = (int)tmp;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            ThreadStart newThread1 = new ThreadStart(thread1);
            Thread t1 = new Thread(newThread1);

            ThreadStart newThread2 = new ThreadStart(thread2);
            Thread t2 = new Thread(newThread2);

            ThreadStart newThread3 = new ThreadStart(thread3);
            Thread t3 = new Thread(newThread3);

            if (btnDetener.Text == "Suspender")
            {
                timer1.Stop();
                t1.Interrupt();
                t2.Interrupt();
                t3.Interrupt();

                btnDetener.Text = "Reanudar";
            }
            else if(btnDetener.Text == "Reanudar")
            {
                timer1.Start();
               // ThreadStart newThread1 = new ThreadStart(thread1);
                //Thread t1 = new Thread(newThread1);
                t1.Start();
                //ThreadStart newThread2 = new ThreadStart(thread2);
                //Thread t2 = new Thread(newThread2);
                t2.Start();
                //ThreadStart newThread3 = new ThreadStart(thread3);
                //Thread t3 = new Thread(newThread3);
                t3.Start();
                btnDetener.Text = "Suspender";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ThreadStart newThread1 = new ThreadStart(thread1);
            Thread t1 = new Thread(newThread1);

            ThreadStart newThread2 = new ThreadStart(thread2);
            Thread t2 = new Thread(newThread2);

            ThreadStart newThread3 = new ThreadStart(thread3);
            Thread t3 = new Thread(newThread3);
            t1.Interrupt();
            t2.Interrupt();
            t3.Interrupt();
            Close();
        }
    }
}