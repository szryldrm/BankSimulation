using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace ConsAssig4
{
    public partial class Form1 : MetroForm
    {

        static Queue<Jobs> jobsQ = new Queue<Jobs>();
        static Queue<Jobs> jobsQLonger = new Queue<Jobs>();
        static Queue<Jobs> jobsQShortest = new Queue<Jobs>();
        static List<Jobs> arrJobs = new List<Jobs>();
        static List<Jobs> forList = new List<Jobs>();
        static int isDone = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void createJob(Queue<Jobs> tempQu, Queue<Jobs> tempQuLonger, Queue<Jobs> tempQuShortest, List<Jobs> tempArrJobs, List<Jobs> tempForList, int JobsCount)
        {
            btnEnabled(false);
            metroProgressBar1.Maximum = JobsCount;
            int lbl8 = 100 / JobsCount;
            for (int i = 1; i <= JobsCount; i++)
            {
                Jobs tempJb = new Jobs("Jobs" + i);
                tempQu.Enqueue(tempJb);
                tempArrJobs.Add(tempJb);
                tempForList.Add(tempJb);
                listBox1.Items.Add(tempJb.Job + ". Will Take " + tempJb.Time + " Seconds.");
                metroProgressBar1.Value++;
                if (metroProgressBar1.Value >= 95 && metroProgressBar1.Value <= 100)
                {
                    metroProgressBar1.Value = 100;
                }
                Thread.Sleep(500);
            }

            tempArrJobs = tempArrJobs.OrderByDescending(x => x.Time).ToList();

            foreach (Jobs i in tempArrJobs)
            {
                tempQuLonger.Enqueue(i);
            }

            tempArrJobs = tempArrJobs.OrderBy(x => x.Time).ToList();

            foreach (Jobs i in tempArrJobs)
            {
                tempQuShortest.Enqueue(i);
            }
            btnEnabled(true);
        }

        void processThread(Queue<Jobs> tempQu, String vezNum, Button btn, MetroLabel mLabel)
        {
            Jobs tempJb = new Jobs();
            btn.BackColor = Color.Lime;
            Thread.Sleep(300);
            if (tempQu.Count != 0)
            {
                if (listBox1.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(0);
                }
                tempJb = tempQu.Dequeue();
                btn.BackColor = Color.Red;
                mLabel.Text = tempJb.Job;
                Thread.Sleep(tempJb.Time * 1000);
                processThread(tempQu, vezNum, btn, mLabel);
            }
            else
            {
                isDone++;
            }
            if (isDone == 4)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                btnEnabled(true);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(fifoMlblSecond.Text) < 9)
            {
                fifoMlblSecond.Text = "0" + (int.Parse(fifoMlblSecond.Text) + 1).ToString();
            }
            else
            {
                fifoMlblSecond.Text = (int.Parse(fifoMlblSecond.Text) + 1).ToString();
            }
            if (int.Parse(fifoMlblSecond.Text) == 60)
            {
                fifoMlblSecond.Text = "00";
                if (int.Parse(fifoMlblMinute.Text) < 9)
                {
                    fifoMlblMinute.Text = "0" + (int.Parse(fifoMlblMinute.Text) + 1).ToString();
                }
                else
                {
                    fifoMlblMinute.Text = (int.Parse(fifoMlblMinute.Text) + 1).ToString();
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            isDone = 0;
            btnEnabled(false);
            clearListBox();
            foreach (Jobs i in forList)
            {
                listBox1.Items.Add(i.Job + ". Will Take " + i.Time + " Seconds.");
            }
            Thread th1 = new Thread(() => processThread(jobsQ, "1", btnVezne1, metroLabel1));
            Thread th2 = new Thread(() => processThread(jobsQ, "2", btnVezne2, metroLabel2));
            Thread th3 = new Thread(() => processThread(jobsQ, "3", btnVezne3, metroLabel3));
            Thread th4 = new Thread(() => processThread(jobsQ, "4", btnVezne4, metroLabel4));
            timer1.Start();
            th1.Start();
            Thread.Sleep(500);
            th2.Start();
            Thread.Sleep(500);
            th3.Start();
            Thread.Sleep(500);
            th4.Start();
            Thread.Sleep(500);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            isDone = 0;
            btnEnabled(false);
            clearListBox();
            arrJobs = arrJobs.OrderByDescending(x => x.Time).ToList();
            foreach (Jobs i in arrJobs)
            {
                listBox1.Items.Add(i.Job + ". Will Take " + i.Time + " Seconds.");
            }
            Thread th1 = new Thread(() => processThread(jobsQLonger, "1", btnVezne1, metroLabel1));
            Thread th2 = new Thread(() => processThread(jobsQLonger, "2", btnVezne2, metroLabel2));
            Thread th3 = new Thread(() => processThread(jobsQLonger, "3", btnVezne3, metroLabel3));
            Thread th4 = new Thread(() => processThread(jobsQLonger, "4", btnVezne4, metroLabel4));
            timer2.Start();
            th1.Start();
            Thread.Sleep(500);
            th2.Start();
            Thread.Sleep(500);
            th3.Start();
            Thread.Sleep(500);
            th4.Start();
            Thread.Sleep(500);
            metroButton2.Enabled = false;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (mTxtJobsCount.Text == "")
            {
                MetroMessageBox.Show(this, "Please, Fill the Jobs Count!", "An Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }

            else if (Convert.ToInt32(mTxtJobsCount.Text) <= 0 || Convert.ToInt32(mTxtJobsCount.Text) > 100)
            {
                MetroMessageBox.Show(this, "Count Should Be Between 1 to 100!", "An Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
            else
            {
                createJob(jobsQ, jobsQLonger, jobsQShortest, arrJobs, forList, Convert.ToInt32(mTxtJobsCount.Text));
                metroButton4.Enabled = false;
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            isDone = 0;
            btnEnabled(false);
            clearListBox();
            arrJobs = arrJobs.OrderBy(x => x.Time).ToList();
            foreach (Jobs i in arrJobs)
            {
                listBox1.Items.Add(i.Job + ". Will Take " + i.Time + " Seconds.");
            }
            Thread th1 = new Thread(() => processThread(jobsQShortest, "1", btnVezne1, metroLabel1));
            Thread th2 = new Thread(() => processThread(jobsQShortest, "2", btnVezne2, metroLabel2));
            Thread th3 = new Thread(() => processThread(jobsQShortest, "3", btnVezne3, metroLabel3));
            Thread th4 = new Thread(() => processThread(jobsQShortest, "4", btnVezne4, metroLabel4));
            timer3.Start();
            th1.Start();
            Thread.Sleep(500);
            th2.Start();
            Thread.Sleep(500);
            th3.Start();
            Thread.Sleep(500);
            th4.Start();
            Thread.Sleep(500);
            metroButton3.Enabled = false;
        }

        private void mTxtJobsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void btnEnabled(bool state)
        {
            metroButton1.Enabled = state;
            metroButton2.Enabled = state;
            metroButton3.Enabled = state;
            metroButton4.Enabled = state;
            mTxtJobsCount.Enabled = state;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (int.Parse(sjfMlblSecond.Text) < 9)
            {
                sjfMlblSecond.Text = "0" + (int.Parse(sjfMlblSecond.Text) + 1).ToString();
            }
            else
            {
                sjfMlblSecond.Text = (int.Parse(sjfMlblSecond.Text) + 1).ToString();
            }
            if (int.Parse(sjfMlblSecond.Text) == 60)
            {
                sjfMlblSecond.Text = "00";
                if (int.Parse(sjfMlblMinute.Text) < 9)
                {
                    sjfMlblMinute.Text = "0" + (int.Parse(sjfMlblMinute.Text) + 1).ToString();
                }
                else
                {
                    sjfMlblMinute.Text = (int.Parse(sjfMlblMinute.Text) + 1).ToString();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (int.Parse(ljfMlblSecond.Text) < 9)
            {
                ljfMlblSecond.Text = "0" + (int.Parse(ljfMlblSecond.Text) + 1).ToString();
            }
            else
            {
                ljfMlblSecond.Text = (int.Parse(ljfMlblSecond.Text) + 1).ToString();
            }
            if (int.Parse(ljfMlblSecond.Text) == 60)
            {
                ljfMlblSecond.Text = "00";
                if (int.Parse(ljfMlblMinute.Text) < 9)
                {
                    ljfMlblMinute.Text = "0" + (int.Parse(ljfMlblMinute.Text) + 1).ToString();
                }
                else
                {
                    ljfMlblMinute.Text = (int.Parse(ljfMlblMinute.Text) + 1).ToString();
                }
            }
        }

        void clearListBox()
        {
            while (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
            }
        }
    }
}
