using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpuScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void FCFS_CheckedChanged(object sender, EventArgs e)
        {
            preemtionBox();
        }

        private void SJF_CheckedChanged(object sender, EventArgs e)
        {
            preemtionBox();
        }

        private void Priority_CheckedChanged(object sender, EventArgs e)
        {
            preemtionBox();
        }

        private void RoundRobin_CheckedChanged(object sender, EventArgs e)
        {
            preemtionBox();
        }
        private void Preemtive_CheckedChanged(object sender, EventArgs e)
        {
            Attributes();
        }

        private void NonPreemtive_CheckedChanged(object sender, EventArgs e)
        {
            Attributes();
        }

        private void preemtionBox()
        {
            if (Priority.Checked == false) { PriorityBox.Enabled = false; }
            if (SJF.Checked == true || Priority.Checked == true)
            {
                Preemtion.Enabled = true;

            }
            else
            {
                Preemtion.Enabled = false;

            }
            if (FCFS.Checked == true)
            {
                NonPreemtive.Checked = true;
            }
            else
            {
                NonPreemtive.Checked = false;
            }
            if (RoundRobin.Checked == true) { Preemtive.Checked = true; RoundTimeBox.Enabled = true; }
            else { Preemtive.Checked = false; RoundTimeBox.Enabled = false; }

        }
        private void Attributes()
        {
            if (Preemtive.Checked == true || NonPreemtive.Checked == true)
            {
                ProcessAttributes.Enabled = true;
                Add.Enabled = true;
                if (Priority.Checked == true)
                {
                    PriorityBox.Enabled = true;
                }
                else
                {
                    PriorityBox.Enabled = false;
                }
            }
            else { ProcessAttributes.Enabled = false; PriorityBox.Enabled = false; Add.Enabled = false; }

        }


        static DataTable T = new DataTable();
        
        static int id = 1;
        private void Add_Click(object sender, EventArgs e)
        {
            Delete.Enabled = true;
            SchedulingType.Enabled = false;
            Preemtion.Enabled = false;
            RoundTimeBox.Enabled = false;
            Run.Enabled = true;
            if (id == 1)
            {
                T.Columns.Add("PID", typeof(int));
                T.Columns.Add("Arrival Time", typeof(float));
                T.Columns.Add("Burst Time", typeof(float));
                T.Columns.Add("Priority", typeof(int));
                dataGridView1.Height += 21;
            }
            if (Priority.Checked == true) T.Rows.Add(id, ArrivalTime.Value, BurstTime.Value, PriorityInput.Value);
            else T.Rows.Add(id, ArrivalTime.Value, BurstTime.Value);
            dataGridView1.Height += 21;
            dataGridView1.DataSource = T;
            process p = new process(id, (float)ArrivalTime.Value, (float)BurstTime.Value,(int) PriorityInput.Value);
            Global.inputs.Add(p);
            id++;


        }

        private void Run_Click(object sender, EventArgs e)
        {
            
            Reset.Enabled = false;
            CPUTime.Visible = true;
            Run.Enabled = false;
            Add.Enabled = false;
            Delete.Enabled = false;
            if (FCFS.Checked == true) { FCFSCalculate(); }
            else if (SJF.Checked == true && NonPreemtive.Checked==true) { SJFCalculate(); }
            else if (SJF.Checked == true && Preemtive.Checked == true) { PreSJFCalculate(); }
            else if (Priority.Checked == true && NonPreemtive.Checked==true) { PriorityCalculate(); }
            else if (Priority.Checked == true && Preemtive.Checked == true) { PrePriorityCalculate(); }
            else if (RoundRobin.Checked == true) { RRCalculate(); }
            Reset.Enabled=true;
            
        }
        public void FCFSCalculate()
        {
            Global.inputs.Sort();
            float Time = 0f;
            float waitingTime = 0f;
            float turnAroundTime = 0f;
            foreach (process p in Global.inputs)
            {
                if (Time < p.arrivalTime)
                {
                    Global.intervals.Add(new interval(Time,p.arrivalTime));
                    Global.ids.Add(-1);
                    Time = p.arrivalTime;
                }
                waitingTime += (Time - p.arrivalTime);
                Global.intervals.Add(new interval(Time, Time+p.burstTime));
                Global.ids.Add(p.id);
                Time = Time + p.burstTime;
                turnAroundTime += Time - p.arrivalTime;

            }
            float averageWaitingTime = waitingTime / Global.inputs.Count;
            float averageTurnAroundTime = turnAroundTime / Global.inputs.Count;
            Print();
            AvgWaitingTime.Text = averageWaitingTime.ToString();
            AvgTurnAroundTime.Text = averageTurnAroundTime.ToString();
        }
        public void SJFCalculate()
        {
            Comparison<process> burstComparer = new Comparison<process>(burstTimeCompare);
            Global.inputs.Sort(burstComparer);
            for(int i=0;i<Global.inputs.Count;i++)
            {
                Global.inputs[i].priority = i+1;
            }
            PriorityCalculate();
        }
        private static int burstTimeCompare(process a, process b)
        {
            return a.burstTime.CompareTo(b.burstTime);
        }
        public void PreSJFCalculate()
        {
            Comparison<process> burstComparer = new Comparison<process>(burstTimeCompare);
            Global.inputs.Sort(burstComparer);
            for (int i = 0; i < Global.inputs.Count; i++)
            {
                Global.inputs[i].priority = i + 1;
            }
            PrePriorityCalculate();
        }
        public void PriorityCalculate()
        {

            Global.inputs.Sort();
            int CO=Global.inputs.Count;
            float Time = 0f;
            float waitingTime = 0f;
            float turnAroundTime = 0f;
            int index;
            int min;
            while(Global.inputs.Count!=0) 
            {
                
                min = Global.inputs[0].priority;
                index = 0;
                for(int j=1;j<Global.inputs.Count;j++)
                {
                    
                    if (Global.inputs[j].arrivalTime > Time) break;
                    int m = Global.inputs[j].priority;
                    if (m < min) 
                    {
                        min=m;
                        index = j;
                    }

                }
                if (Time < Global.inputs[index].arrivalTime)
                {
                    Global.intervals.Add(new interval(Time, Global.inputs[index].arrivalTime));
                    Global.ids.Add(-1);
                    Time = Global.inputs[index].arrivalTime;
                }
                else 
                {
                    waitingTime += (Time - Global.inputs[index].arrivalTime);
                    Global.intervals.Add(new interval(Time, Time + Global.inputs[index].burstTime));
                    Global.ids.Add(Global.inputs[index].id);
                    Time = Time + Global.inputs[index].burstTime;
                    turnAroundTime += Time - Global.inputs[index].arrivalTime;
                    Global.inputs.RemoveAt(index);
                }
            }
            Print();
            AvgWaitingTime.Text = (waitingTime / (float)CO).ToString();
            AvgTurnAroundTime.Text = (turnAroundTime / (float)CO).ToString();
        }
        public void PrePriorityCalculate()
        {
            Global.inputs.Sort();
            int CO = Global.inputs.Count;
            float Time = 0f;
            float waitingTime = 0f;
            float turnAroundTime = 0f;
            int index;
            int index1;
            int min;
            while (Global.inputs.Count != 0)
            {

                min = Global.inputs[0].priority;
                index = 0;
                for (int j = 1; j < Global.inputs.Count; j++)
                {

                    if (Global.inputs[j].arrivalTime > Time) break;
                    int m = Global.inputs[j].priority;
                    if (m < min)
                    {
                        min = m;
                        index = j;
                    }

                }

                if (Time < Global.inputs[index].arrivalTime)
                {
                    Global.intervals.Add(new interval(Time, Global.inputs[index].arrivalTime));
                    Global.ids.Add(-1);
                    Time = Global.inputs[index].arrivalTime;
                }
                else
                {
                    index1 = Global.inputs.FindIndex(p => p.priority < Global.inputs[index].priority);
                    if (index1 != -1) 
                    {
                        if (Global.inputs[index1].arrivalTime >= (Time + Global.inputs[index].timeLeft) ) 
                        {
                            Global.intervals.Add(new interval(Time, Time + Global.inputs[index].timeLeft));
                            Global.ids.Add(Global.inputs[index].id);
                            Time += Global.inputs[index].timeLeft;
                            waitingTime += (Time - Global.inputs[index].arrivalTime - Global.inputs[index].burstTime);
                            turnAroundTime += (Time - Global.inputs[index].arrivalTime);
                            Global.inputs.RemoveAt(index);
                        }
                        else 
                        {
                            float sliceTime = Global.inputs[index1].arrivalTime - Time;
                            Global.inputs[index].timeLeft -= sliceTime;
                            float sum = (Time + sliceTime);
                            Global.intervals.Add(new interval(Time, sum));
                            Global.ids.Add(Global.inputs[index].id);
                            Time += sliceTime;
                        }
                    }
                    else 
                    {

                        Global.intervals.Add(new interval(Time, Time + Global.inputs[index].timeLeft));
                        Global.ids.Add(Global.inputs[index].id);
                        Time += Global.inputs[index].timeLeft;
                        waitingTime += (Time - Global.inputs[index].arrivalTime - Global.inputs[index].burstTime);
                        turnAroundTime += (Time - Global.inputs[index].arrivalTime);
                        Global.inputs.RemoveAt(index);
                    }
                   
                }


            }

            Print();
            AvgWaitingTime.Text = (waitingTime / (float)CO).ToString();
            AvgTurnAroundTime.Text = (turnAroundTime / (float)CO).ToString();


        }
        public  void RRCalculate()
        {
            float sliceTime=(float)RoundTime.Value;
            int size = Global.inputs.Count;
            Global.inputs.Sort();
            float Time=0f;
            float waitingTime = 0f;
            float turnAroundTime = 0f;
            Queue<process> QP=new Queue<process>(50);
            while( (Global.inputs.Count!=0) || (QP.Count!=0) )
            {
                
                while (Global.inputs.Count != 0) 
                {
                    float t = 0f;
                    if ((QP.Count == 0) && (Global.inputs[0].arrivalTime > Time))
                    {
                        Global.intervals.Add(new interval(Time, Global.inputs[0].arrivalTime));
                        Global.ids.Add(-1);
                        Time = Global.inputs[0].arrivalTime;
                    }
                    if (QP.Count != 0) 
                    {
                        t = Math.Min(sliceTime, QP.Peek().timeLeft);
                    }
                    if (Global.inputs[0].arrivalTime > (Time+t)) break;
                    else 
                    {
                        QP.Enqueue(Global.inputs[0]);
                        Global.inputs.RemoveAt(0);
                    }

                }

                process p = QP.Dequeue();
                if (p.timeLeft <= sliceTime)
                {
                    Global.intervals.Add(new interval(Time, Time + p.timeLeft));
                    Global.ids.Add(p.id);
                    Time += p.timeLeft;
                    waitingTime += (Time - p.arrivalTime - p.burstTime);
                    turnAroundTime += (Time - p.arrivalTime);
                }
                else
                {
                    p.timeLeft -= sliceTime;
                    Global.intervals.Add(new interval(Time, Time + sliceTime));
                    Global.ids.Add(p.id);
                    Time += sliceTime;
                    QP.Enqueue(p);
                }
            }
            Print();
            AvgWaitingTime.Text = (waitingTime / (float)size).ToString();
            AvgTurnAroundTime.Text = (turnAroundTime / (float)size).ToString();
            
        }
        public void Print() 
        {
            DataTable K = new DataTable();
            string s,s0,s1,s2;
            for (int i = 0; i < Global.intervals.Count; i++) 
            {
                if (Global.ids[i] == -1) 
                {
                    s1 = "idle";
                }
                else 
                {
                    s1 = "P" + Global.ids[i].ToString();
                }
                s2 = Global.intervals[i].Begin.ToString()+" -----------------> "+Global.intervals[i].End.ToString();
                s0 = new string(' ', ((s2.Length)/2));
                s = s0 + s1 +"\n\n"+ s2;
                K.Columns.Add(s, typeof(string));
                TimeLine.Width +=  (4* s2.Length);
            }
            TimeLine.DataSource = K;
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            CPUTime.Visible = false;
            Delete.Enabled = false;
            Add.Enabled = false;
            Preemtion.Enabled = false;
            RoundTimeBox.Enabled = false;
            PriorityBox.Enabled = false;
            Run.Enabled = false;
            ProcessAttributes.Enabled = false;
            FCFS.Checked = false;
            SJF.Checked = false;
            Priority.Checked = false;
            RoundRobin.Checked = false;
            SchedulingType.Enabled = true;
            dataGridView1.Height = 0;
            TimeLine.Width = 0;
            id = 1;
            T.Clear();
            T.Columns.Clear();
            dataGridView1.DataSource = T;
            TimeLine.DataSource = T;
            Global.ids.Clear();
            Global.inputs.Clear();
            Global.intervals.Clear();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            id--;
            Global.inputs.RemoveAt(id-1);
            if (id == 1) 
            {
                Delete.Enabled = false;
                T.Clear();
                T.Columns.Clear();
                dataGridView1.DataSource = T;
                dataGridView1.Height = 0;
                Run.Enabled = false;

            }
            else 
            {
                T.Rows.RemoveAt(id-1);
                dataGridView1.DataSource = T;
                dataGridView1.Height -=21 ;
            }
        }


        

        

       
        

    }
    class interval 
    {
        private float begin;

        public float Begin
        {
            get { return begin; }
            set { begin = value; }
        }
        private float end;

        public float End
        {
            get { return end; }
            set { end = value; }
        }
        public interval()
        {
            begin = 0f;
            end = 0f;
        }
        public interval(float b, float e)
        {
            begin = b;
            end = e;
        }
        
    }
    static class Global
    {
        public static List<process> inputs=new List<process>(50);
        public static List<interval> intervals =new List<interval>(50);
        public static List<int> ids = new List<int>(50);

    }
    class process : IComparable<process>
    {
        public int id;
        public float arrivalTime;
        public float burstTime;
        public int priority;
        public float timeLeft;
        public process()
        {
            id = 0;
            arrivalTime = 0f;
            burstTime = 0f;
            priority = 1;
            timeLeft = 0;
        }
        public process(int i, float a, float b, int p)
        {
            id = i;
            arrivalTime = a;
            burstTime = b;
            priority = p;
            timeLeft = b;
        }
        public int CompareTo(process other) 
        {
            return this.arrivalTime.CompareTo(other.arrivalTime);
        }
    }

    
    
    
}
