namespace CpuScheduler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FCFS = new System.Windows.Forms.RadioButton();
            this.SJF = new System.Windows.Forms.RadioButton();
            this.Priority = new System.Windows.Forms.RadioButton();
            this.RoundRobin = new System.Windows.Forms.RadioButton();
            this.NonPreemtive = new System.Windows.Forms.RadioButton();
            this.Preemtive = new System.Windows.Forms.RadioButton();
            this.SchedulingType = new System.Windows.Forms.GroupBox();
            this.Preemtion = new System.Windows.Forms.GroupBox();
            this.RoundTimeBox = new System.Windows.Forms.GroupBox();
            this.RoundTime = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProcessAttributes = new System.Windows.Forms.GroupBox();
            this.BurstTimeLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeLabel = new System.Windows.Forms.Label();
            this.BurstTime = new System.Windows.Forms.NumericUpDown();
            this.ArrivalTime = new System.Windows.Forms.NumericUpDown();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityInput = new System.Windows.Forms.NumericUpDown();
            this.PriorityBox = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Run = new System.Windows.Forms.Button();
            this.TimeLine = new System.Windows.Forms.DataGridView();
            this.Reset = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AvgWaitingTime = new System.Windows.Forms.TextBox();
            this.CPUTime = new System.Windows.Forms.GroupBox();
            this.AvgTurnAroundTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WaitingTimeLabel = new System.Windows.Forms.Label();
            this.SchedulingType.SuspendLayout();
            this.Preemtion.SuspendLayout();
            this.RoundTimeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoundTime)).BeginInit();
            this.ProcessAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BurstTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityInput)).BeginInit();
            this.PriorityBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine)).BeginInit();
            this.CPUTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // FCFS
            // 
            this.FCFS.AutoSize = true;
            this.FCFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FCFS.Location = new System.Drawing.Point(6, 50);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(63, 21);
            this.FCFS.TabIndex = 0;
            this.FCFS.TabStop = true;
            this.FCFS.Text = "FCFS";
            this.FCFS.UseVisualStyleBackColor = true;
            this.FCFS.CheckedChanged += new System.EventHandler(this.FCFS_CheckedChanged);
            // 
            // SJF
            // 
            this.SJF.AutoSize = true;
            this.SJF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SJF.Location = new System.Drawing.Point(6, 77);
            this.SJF.Name = "SJF";
            this.SJF.Size = new System.Drawing.Size(53, 21);
            this.SJF.TabIndex = 1;
            this.SJF.TabStop = true;
            this.SJF.Text = "SJF";
            this.SJF.UseVisualStyleBackColor = true;
            this.SJF.CheckedChanged += new System.EventHandler(this.SJF_CheckedChanged);
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Priority.Location = new System.Drawing.Point(6, 104);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(73, 21);
            this.Priority.TabIndex = 2;
            this.Priority.TabStop = true;
            this.Priority.Text = "Priority";
            this.Priority.UseVisualStyleBackColor = true;
            this.Priority.CheckedChanged += new System.EventHandler(this.Priority_CheckedChanged);
            // 
            // RoundRobin
            // 
            this.RoundRobin.AutoSize = true;
            this.RoundRobin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoundRobin.Location = new System.Drawing.Point(6, 131);
            this.RoundRobin.Name = "RoundRobin";
            this.RoundRobin.Size = new System.Drawing.Size(112, 21);
            this.RoundRobin.TabIndex = 3;
            this.RoundRobin.TabStop = true;
            this.RoundRobin.Text = "Round Robin";
            this.RoundRobin.UseVisualStyleBackColor = true;
            this.RoundRobin.CheckedChanged += new System.EventHandler(this.RoundRobin_CheckedChanged);
            // 
            // NonPreemtive
            // 
            this.NonPreemtive.AutoSize = true;
            this.NonPreemtive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NonPreemtive.Location = new System.Drawing.Point(6, 67);
            this.NonPreemtive.Name = "NonPreemtive";
            this.NonPreemtive.Size = new System.Drawing.Size(123, 21);
            this.NonPreemtive.TabIndex = 4;
            this.NonPreemtive.TabStop = true;
            this.NonPreemtive.Text = "Non-Preemtive";
            this.NonPreemtive.UseVisualStyleBackColor = true;
            this.NonPreemtive.CheckedChanged += new System.EventHandler(this.NonPreemtive_CheckedChanged);
            // 
            // Preemtive
            // 
            this.Preemtive.AutoSize = true;
            this.Preemtive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Preemtive.Location = new System.Drawing.Point(6, 40);
            this.Preemtive.Name = "Preemtive";
            this.Preemtive.Size = new System.Drawing.Size(92, 21);
            this.Preemtive.TabIndex = 5;
            this.Preemtive.TabStop = true;
            this.Preemtive.Text = "Preemtive";
            this.Preemtive.UseVisualStyleBackColor = true;
            this.Preemtive.CheckedChanged += new System.EventHandler(this.Preemtive_CheckedChanged);
            // 
            // SchedulingType
            // 
            this.SchedulingType.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SchedulingType.Controls.Add(this.FCFS);
            this.SchedulingType.Controls.Add(this.SJF);
            this.SchedulingType.Controls.Add(this.Priority);
            this.SchedulingType.Controls.Add(this.RoundRobin);
            this.SchedulingType.ForeColor = System.Drawing.Color.Black;
            this.SchedulingType.Location = new System.Drawing.Point(26, 35);
            this.SchedulingType.Name = "SchedulingType";
            this.SchedulingType.Size = new System.Drawing.Size(207, 168);
            this.SchedulingType.TabIndex = 6;
            this.SchedulingType.TabStop = false;
            this.SchedulingType.Text = "Scheduling Type";
            // 
            // Preemtion
            // 
            this.Preemtion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Preemtion.Controls.Add(this.Preemtive);
            this.Preemtion.Controls.Add(this.NonPreemtive);
            this.Preemtion.Enabled = false;
            this.Preemtion.Location = new System.Drawing.Point(264, 35);
            this.Preemtion.Name = "Preemtion";
            this.Preemtion.Size = new System.Drawing.Size(200, 100);
            this.Preemtion.TabIndex = 4;
            this.Preemtion.TabStop = false;
            this.Preemtion.Text = "Preemtion";
            // 
            // RoundTimeBox
            // 
            this.RoundTimeBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RoundTimeBox.Controls.Add(this.RoundTime);
            this.RoundTimeBox.Enabled = false;
            this.RoundTimeBox.Location = new System.Drawing.Point(264, 150);
            this.RoundTimeBox.Name = "RoundTimeBox";
            this.RoundTimeBox.Size = new System.Drawing.Size(200, 53);
            this.RoundTimeBox.TabIndex = 6;
            this.RoundTimeBox.TabStop = false;
            this.RoundTimeBox.Text = "Round Time ";
            // 
            // RoundTime
            // 
            this.RoundTime.DecimalPlaces = 1;
            this.RoundTime.Location = new System.Drawing.Point(6, 21);
            this.RoundTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RoundTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoundTime.Name = "RoundTime";
            this.RoundTime.Size = new System.Drawing.Size(120, 22);
            this.RoundTime.TabIndex = 7;
            this.RoundTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProcessAttributes
            // 
            this.ProcessAttributes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProcessAttributes.Controls.Add(this.BurstTimeLabel);
            this.ProcessAttributes.Controls.Add(this.ArrivalTimeLabel);
            this.ProcessAttributes.Controls.Add(this.BurstTime);
            this.ProcessAttributes.Controls.Add(this.ArrivalTime);
            this.ProcessAttributes.Enabled = false;
            this.ProcessAttributes.Location = new System.Drawing.Point(26, 225);
            this.ProcessAttributes.Name = "ProcessAttributes";
            this.ProcessAttributes.Size = new System.Drawing.Size(286, 79);
            this.ProcessAttributes.TabIndex = 7;
            this.ProcessAttributes.TabStop = false;
            this.ProcessAttributes.Text = "Process Attributes";
            // 
            // BurstTimeLabel
            // 
            this.BurstTimeLabel.AutoSize = true;
            this.BurstTimeLabel.Location = new System.Drawing.Point(156, 21);
            this.BurstTimeLabel.Name = "BurstTimeLabel";
            this.BurstTimeLabel.Size = new System.Drawing.Size(80, 17);
            this.BurstTimeLabel.TabIndex = 4;
            this.BurstTimeLabel.Text = "Burst Time ";
            // 
            // ArrivalTimeLabel
            // 
            this.ArrivalTimeLabel.AutoSize = true;
            this.ArrivalTimeLabel.Location = new System.Drawing.Point(7, 22);
            this.ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            this.ArrivalTimeLabel.Size = new System.Drawing.Size(83, 17);
            this.ArrivalTimeLabel.TabIndex = 3;
            this.ArrivalTimeLabel.Text = "Arrival Time";
            // 
            // BurstTime
            // 
            this.BurstTime.DecimalPlaces = 1;
            this.BurstTime.Location = new System.Drawing.Point(156, 45);
            this.BurstTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BurstTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BurstTime.Name = "BurstTime";
            this.BurstTime.Size = new System.Drawing.Size(120, 22);
            this.BurstTime.TabIndex = 1;
            this.BurstTime.Tag = "";
            this.BurstTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DecimalPlaces = 1;
            this.ArrivalTime.Location = new System.Drawing.Point(6, 45);
            this.ArrivalTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(120, 22);
            this.ArrivalTime.TabIndex = 0;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(6, 21);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(52, 17);
            this.PriorityLabel.TabIndex = 5;
            this.PriorityLabel.Text = "Priority";
            // 
            // PriorityInput
            // 
            this.PriorityInput.Location = new System.Drawing.Point(0, 45);
            this.PriorityInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriorityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriorityInput.Name = "PriorityInput";
            this.PriorityInput.Size = new System.Drawing.Size(120, 22);
            this.PriorityInput.TabIndex = 2;
            this.PriorityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PriorityBox
            // 
            this.PriorityBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PriorityBox.Controls.Add(this.PriorityLabel);
            this.PriorityBox.Controls.Add(this.PriorityInput);
            this.PriorityBox.Enabled = false;
            this.PriorityBox.Location = new System.Drawing.Point(332, 225);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(132, 79);
            this.PriorityBox.TabIndex = 8;
            this.PriorityBox.TabStop = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkKhaki;
            this.Add.Enabled = false;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Add.FlatAppearance.BorderSize = 20000;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(470, 260);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(83, 44);
            this.Add.TabIndex = 9;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(590, 35);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(380, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(380, 0);
            this.dataGridView1.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.SpringGreen;
            this.Run.Enabled = false;
            this.Run.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Run.FlatAppearance.BorderSize = 20000;
            this.Run.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(26, 334);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(83, 44);
            this.Run.TabIndex = 11;
            this.Run.Text = "RUN";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // TimeLine
            // 
            this.TimeLine.AllowUserToAddRows = false;
            this.TimeLine.AllowUserToDeleteRows = false;
            this.TimeLine.AllowUserToResizeColumns = false;
            this.TimeLine.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TimeLine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TimeLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TimeLine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TimeLine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TimeLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeLine.GridColor = System.Drawing.SystemColors.Control;
            this.TimeLine.Location = new System.Drawing.Point(26, 397);
            this.TimeLine.MaximumSize = new System.Drawing.Size(944, 100);
            this.TimeLine.Name = "TimeLine";
            this.TimeLine.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLine.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TimeLine.RowHeadersVisible = false;
            this.TimeLine.RowTemplate.Height = 24;
            this.TimeLine.RowTemplate.ReadOnly = true;
            this.TimeLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLine.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TimeLine.Size = new System.Drawing.Size(0, 85);
            this.TimeLine.TabIndex = 12;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Reset.FlatAppearance.BorderSize = 20000;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(470, 42);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(83, 44);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Enabled = false;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Delete.FlatAppearance.BorderSize = 20000;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(470, 159);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(83, 44);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "DEL.";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AvgWaitingTime
            // 
            this.AvgWaitingTime.Enabled = false;
            this.AvgWaitingTime.Location = new System.Drawing.Point(197, 44);
            this.AvgWaitingTime.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.AvgWaitingTime.MaxLength = 999999999;
            this.AvgWaitingTime.Multiline = true;
            this.AvgWaitingTime.Name = "AvgWaitingTime";
            this.AvgWaitingTime.ReadOnly = true;
            this.AvgWaitingTime.Size = new System.Drawing.Size(141, 29);
            this.AvgWaitingTime.TabIndex = 15;
            // 
            // CPUTime
            // 
            this.CPUTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CPUTime.Controls.Add(this.AvgTurnAroundTime);
            this.CPUTime.Controls.Add(this.label1);
            this.CPUTime.Controls.Add(this.WaitingTimeLabel);
            this.CPUTime.Controls.Add(this.AvgWaitingTime);
            this.CPUTime.Location = new System.Drawing.Point(26, 555);
            this.CPUTime.Name = "CPUTime";
            this.CPUTime.Size = new System.Drawing.Size(872, 114);
            this.CPUTime.TabIndex = 16;
            this.CPUTime.TabStop = false;
            this.CPUTime.Text = "CPU Time Evaluation";
            this.CPUTime.Visible = false;
            // 
            // AvgTurnAroundTime
            // 
            this.AvgTurnAroundTime.Enabled = false;
            this.AvgTurnAroundTime.Location = new System.Drawing.Point(230, 79);
            this.AvgTurnAroundTime.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.AvgTurnAroundTime.MaxLength = 999999999;
            this.AvgTurnAroundTime.Multiline = true;
            this.AvgTurnAroundTime.Name = "AvgTurnAroundTime";
            this.AvgTurnAroundTime.ReadOnly = true;
            this.AvgTurnAroundTime.Size = new System.Drawing.Size(108, 29);
            this.AvgTurnAroundTime.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Average Turn Around Time = ";
            // 
            // WaitingTimeLabel
            // 
            this.WaitingTimeLabel.AutoSize = true;
            this.WaitingTimeLabel.Location = new System.Drawing.Point(28, 51);
            this.WaitingTimeLabel.Name = "WaitingTimeLabel";
            this.WaitingTimeLabel.Size = new System.Drawing.Size(163, 17);
            this.WaitingTimeLabel.TabIndex = 16;
            this.WaitingTimeLabel.Text = "Average Waiting Time = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.CPUTime);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.TimeLine);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.ProcessAttributes);
            this.Controls.Add(this.RoundTimeBox);
            this.Controls.Add(this.Preemtion);
            this.Controls.Add(this.SchedulingType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CPU Scheduler";
            this.SchedulingType.ResumeLayout(false);
            this.SchedulingType.PerformLayout();
            this.Preemtion.ResumeLayout(false);
            this.Preemtion.PerformLayout();
            this.RoundTimeBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoundTime)).EndInit();
            this.ProcessAttributes.ResumeLayout(false);
            this.ProcessAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BurstTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityInput)).EndInit();
            this.PriorityBox.ResumeLayout(false);
            this.PriorityBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine)).EndInit();
            this.CPUTime.ResumeLayout(false);
            this.CPUTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton FCFS;
        private System.Windows.Forms.RadioButton SJF;
        private System.Windows.Forms.RadioButton Priority;
        private System.Windows.Forms.RadioButton RoundRobin;
        private System.Windows.Forms.RadioButton NonPreemtive;
        private System.Windows.Forms.RadioButton Preemtive;
        private System.Windows.Forms.GroupBox SchedulingType;
        private System.Windows.Forms.GroupBox Preemtion;
        private System.Windows.Forms.GroupBox RoundTimeBox;
        private System.Windows.Forms.NumericUpDown RoundTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox ProcessAttributes;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label BurstTimeLabel;
        private System.Windows.Forms.Label ArrivalTimeLabel;
        private System.Windows.Forms.NumericUpDown PriorityInput;
        private System.Windows.Forms.NumericUpDown BurstTime;
        private System.Windows.Forms.NumericUpDown ArrivalTime;
        private System.Windows.Forms.GroupBox PriorityBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.DataGridView TimeLine;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox AvgWaitingTime;
        private System.Windows.Forms.GroupBox CPUTime;
        private System.Windows.Forms.TextBox AvgTurnAroundTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WaitingTimeLabel;
    }
}

