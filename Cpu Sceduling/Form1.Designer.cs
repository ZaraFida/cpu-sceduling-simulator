
using CpuScheduling;


    namespace CpuScheduling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_Browse = new Button();
            openFileDialog1 = new OpenFileDialog();
            bt_OK = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            groubBox3 = new GroupBox();
            groupBox3 = new GroupBox();
            tb_quantum = new TextBox();
            rd_bt_rr = new RadioButton();
            rd_bt_pp = new RadioButton();
            rd_bt_pn = new RadioButton();
            rd_bt_sjfp = new RadioButton();
            rd_bt_sjfn = new RadioButton();
            rd_bt_fcfs = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groubBox3.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // bt_Browse
            // 
            bt_Browse.Location = new Point(15, 327);
            bt_Browse.Margin = new Padding(3, 2, 3, 2);
            bt_Browse.Name = "bt_Browse";
            bt_Browse.Size = new Size(94, 41);
            bt_Browse.TabIndex = 0;
            bt_Browse.Text = "Browse";
            bt_Browse.UseVisualStyleBackColor = true;
            bt_Browse.Click += bt_Browse_Click;
            // 
            // bt_OK
            // 
            bt_OK.Location = new Point(330, 111);
            bt_OK.Margin = new Padding(3, 2, 3, 2);
            bt_OK.Name = "bt_OK";
            bt_OK.Size = new Size(75, 24);
            bt_OK.TabIndex = 2;
            bt_OK.Text = "OK";
            bt_OK.UseVisualStyleBackColor = true;
            bt_OK.Click += bt_OK_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 15);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(389, 306);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(8, 19);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(452, 322);
            dataGridView2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(bt_Browse);
            groupBox1.Location = new Point(18, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(405, 375);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Process";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(429, 21);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(487, 641);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Simulation";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.Location = new Point(6, 379);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(379, 261);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Conclusion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 233);
            textBox1.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(6, 19);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(466, 355);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gantt Chart";
            // 
            // groubBox3
            // 
            groubBox3.Controls.Add(groupBox3);
            groubBox3.Controls.Add(bt_OK);
            groubBox3.Location = new Point(18, 401);
            groubBox3.Margin = new Padding(3, 2, 3, 2);
            groubBox3.Name = "groubBox3";
            groubBox3.Padding = new Padding(3, 2, 3, 2);
            groubBox3.Size = new Size(405, 261);
            groubBox3.TabIndex = 8;
            groubBox3.TabStop = false;
            groubBox3.Text = "cpu scheduling algorithms";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb_quantum);
            groupBox3.Controls.Add(rd_bt_rr);
            groupBox3.Controls.Add(rd_bt_pp);
            groupBox3.Controls.Add(rd_bt_pn);
            groupBox3.Controls.Add(rd_bt_sjfp);
            groupBox3.Controls.Add(rd_bt_sjfn);
            groupBox3.Controls.Add(rd_bt_fcfs);
            groupBox3.Location = new Point(20, 28);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(276, 190);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Algorithms";
            // 
            // tb_quantum
            // 
            tb_quantum.Enabled = false;
            tb_quantum.Location = new Point(142, 152);
            tb_quantum.Margin = new Padding(3, 2, 3, 2);
            tb_quantum.Name = "tb_quantum";
            tb_quantum.Size = new Size(44, 22);
            tb_quantum.TabIndex = 9;
            // 
            // rd_bt_rr
            // 
            rd_bt_rr.AutoSize = true;
            rd_bt_rr.Location = new Point(17, 155);
            rd_bt_rr.Margin = new Padding(3, 2, 3, 2);
            rd_bt_rr.Name = "rd_bt_rr";
            rd_bt_rr.Size = new Size(86, 17);
            rd_bt_rr.TabIndex = 8;
            rd_bt_rr.TabStop = true;
            rd_bt_rr.Text = "Round-Robin";
            rd_bt_rr.UseVisualStyleBackColor = true;
            rd_bt_rr.CheckedChanged += rd_bt_rr_CheckedChanged;
            // 
            // rd_bt_pp
            // 
            rd_bt_pp.AutoSize = true;
            rd_bt_pp.Location = new Point(17, 131);
            rd_bt_pp.Margin = new Padding(3, 2, 3, 2);
            rd_bt_pp.Name = "rd_bt_pp";
            rd_bt_pp.Size = new Size(110, 17);
            rd_bt_pp.TabIndex = 7;
            rd_bt_pp.TabStop = true;
            rd_bt_pp.Text = "Priority-Preemtive";
            rd_bt_pp.UseVisualStyleBackColor = true;
            // 
            // rd_bt_pn
            // 
            rd_bt_pn.AutoSize = true;
            rd_bt_pn.Location = new Point(17, 106);
            rd_bt_pn.Margin = new Padding(3, 2, 3, 2);
            rd_bt_pn.Name = "rd_bt_pn";
            rd_bt_pn.Size = new Size(130, 17);
            rd_bt_pn.TabIndex = 6;
            rd_bt_pn.TabStop = true;
            rd_bt_pn.Text = "Priority-Nonpreemtive";
            rd_bt_pn.UseVisualStyleBackColor = true;
            // 
            // rd_bt_sjfp
            // 
            rd_bt_sjfp.AutoSize = true;
            rd_bt_sjfp.Location = new Point(17, 83);
            rd_bt_sjfp.Margin = new Padding(3, 2, 3, 2);
            rd_bt_sjfp.Name = "rd_bt_sjfp";
            rd_bt_sjfp.Size = new Size(157, 17);
            rd_bt_sjfp.TabIndex = 5;
            rd_bt_sjfp.TabStop = true;
            rd_bt_sjfp.Text = "Shortest-Jop-First-Preemtive";
            rd_bt_sjfp.UseVisualStyleBackColor = true;
            // 
            // rd_bt_sjfn
            // 
            rd_bt_sjfn.AutoSize = true;
            rd_bt_sjfn.Location = new Point(17, 59);
            rd_bt_sjfn.Margin = new Padding(3, 2, 3, 2);
            rd_bt_sjfn.Name = "rd_bt_sjfn";
            rd_bt_sjfn.Size = new Size(171, 17);
            rd_bt_sjfn.TabIndex = 4;
            rd_bt_sjfn.TabStop = true;
            rd_bt_sjfn.Text = "Shortest-Job-First-Nopreemtive";
            rd_bt_sjfn.UseVisualStyleBackColor = true;
            // 
            // rd_bt_fcfs
            // 
            rd_bt_fcfs.AutoSize = true;
            rd_bt_fcfs.Location = new Point(17, 37);
            rd_bt_fcfs.Margin = new Padding(3, 2, 3, 2);
            rd_bt_fcfs.Name = "rd_bt_fcfs";
            rd_bt_fcfs.Size = new Size(132, 17);
            rd_bt_fcfs.TabIndex = 3;
            rd_bt_fcfs.TabStop = true;
            rd_bt_fcfs.Text = "First-Come,First-Served";
            rd_bt_fcfs.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(913, 720);
            Controls.Add(groubBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "CPU Scheduling Simulator";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groubBox3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bt_Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groubBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_bt_fcfs;
        private System.Windows.Forms.RadioButton rd_bt_sjfn;
        private System.Windows.Forms.RadioButton rd_bt_rr;
        private System.Windows.Forms.RadioButton rd_bt_pp;
        private System.Windows.Forms.RadioButton rd_bt_pn;
        private System.Windows.Forms.RadioButton rd_bt_sjfp;
        private System.Windows.Forms.TextBox tb_quantum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


