using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_solver
{
    public partial class Form2 : Form, IView
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region inferfejsu
        public decimal points { get; set; }
        public bool end_of_test { get; set; }
        public string pytanie
        {
            set
            {
                textBoxQuestion.Text = value;
            }
        }

        public string odp1
        {
            set
            {
                textBoxA.Text = value;

            }
        }
        public string odp2
        {
            set
            {
                textBoxB.Text = value;
            }
        }
        public string odp3
        {
            set
            {
                textBoxC.Text = value;

            }
        }
        public string odp4
        {
            set
            {
                textBoxD.Text = value;
            }
        }

        public decimal num1
        {
            get; set;
           
        }
        public decimal num2
        {
            get; set;
        }
        public decimal num3
        {
            get; set;
        }
        public decimal num4
        {
            get; set;
        }
        public decimal time
        {
            get
            {
                return Decimal.Parse(label_time.Text);
            }
            set
            {
                label_time.Text = value.ToString();
            }
        }
        #endregion

        public event Action New_Question;
        public event Action Points_summary;

        private void button_next_Click(object sender, EventArgs e)
        {
            check_answers();
            Points_summary?.Invoke();
            timer1.Stop();
            textBoxC.Visible = false;
            checkBoxC.Visible = false;
            textBoxD.Visible = false;
            checkBoxD.Visible = false;
            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxA.Enabled = true;
            checkBoxB.Enabled = true;
            checkBoxC.Enabled = true;
            checkBoxD.Enabled = true;

            if (end_of_test == true)
            {
                this.Hide();
                var form3 = new Form3(points);
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                next_question_for_both_functions();
            }
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            next_question_for_both_functions();
        }

        private void next_question_for_both_functions()
        {
            New_Question?.Invoke();
            if (textBoxC.Text != "")
            {
                textBoxC.Visible = true;
                checkBoxC.Visible = true;
            }
            if (textBoxD.Text != "")
            {
                textBoxD.Visible = true;
                checkBoxD.Visible = true;
            }
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                timer1.Stop();
                checkBoxA.Enabled = false;
                checkBoxB.Enabled = false;
                checkBoxC.Enabled = false;
                checkBoxD.Enabled = false;
            }
            label_time.Text = time.ToString();
        }

        private void check_answers()
        {
            if (checkBoxA.Checked == false)
            {
                num1 = 0;
            }
            if (checkBoxB.Checked == false)
            {
                num2 = 0;
            }
            if (checkBoxC.Checked == false)
            {
                num3 = 0;
            }
            if (checkBoxD.Checked == false)
            {
                num4 = 0;
            }
        }

    }
}
