
using System.Data;
using System.Windows.Forms;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.IO;
    ﻿
    namespace CpuScheduling
{
    public partial class Form1 : Form
    {
        List<Process> processList;
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        void reset()
        {

            // tb_process.Text = File.ReadAllText(filename);
            try
            {
                StreamReader strR = new StreamReader(filename);
                string line = "";
                line = strR.ReadLine();
                processList = new List<Process>();


                while ((line = strR.ReadLine()) != null)
                {
                    string[] word = Algo.SpritString(line);
                    processList.Add(new Process(word[0], Convert.ToInt32(word[1]), Convert.ToInt32(word[2]), Convert.ToInt32(word[3])));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select Process List Files");
            }

        }

        private void bt_Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {


                filename = openFileDialog1.FileName;
                reset();

                dataGridView1.DataSource = GetResultTable();



            }


        }

        public DataTable GetResultTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Process Name", typeof(String));
            table.Columns.Add("Arrival Time", typeof(int));
            table.Columns.Add("Burst Time", typeof(int));
            table.Columns.Add("Priority", typeof(int));


            foreach (Process p in processList)
            {
                table.Rows.Add(p.name, p.arriveTime, p.burstTime, p.priority);

            }
            return table;

        }



        private void bt_OK_Click(object sender, EventArgs e)
        {
            Algo algo = new Algo(textBox1);

            try
            {
                reset();
                if (rd_bt_fcfs.Checked)
                {
                    algo.FCFS(processList);
                }
                else if (rd_bt_sjfn.Checked)
                {

                    algo.SJFN(processList);
                }
                else if (rd_bt_sjfp.Checked)
                {
                    algo.preemtiveSJF(processList);
                }
                else if (rd_bt_pn.Checked)
                {
                    algo.nonPreemtivePriority(processList);
                }
                else if (rd_bt_pp.Checked)
                {
                    algo.preemtivePriority(processList);
                }
                else if (rd_bt_rr.Checked)
                {
                    int quantum = Convert.ToInt32(tb_quantum.Text);
                    algo.RR(processList, quantum);
                }
                dataGridView2.DataSource = algo.showGanttChart();

            }
            catch (Exception ex)
            {

            }








        }

        private void rd_bt_rr_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_bt_rr.Checked)
            {
                tb_quantum.Enabled = true;
            }
            else
                tb_quantum.Enabled = false;
        }
    }
}

