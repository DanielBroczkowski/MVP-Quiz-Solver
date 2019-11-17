namespace Quiz_solver
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.button_next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(17, 135);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(122, 13);
            this.labelA.TabIndex = 38;
            this.labelA.Text = "Wprowadź odpowiedź A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(17, 175);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(122, 13);
            this.labelB.TabIndex = 37;
            this.labelB.Text = "Wprowadź odpowiedź B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(17, 220);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(122, 13);
            this.labelC.TabIndex = 36;
            this.labelC.Text = "Wprowadź odpowiedź C";
            this.labelC.Visible = false;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(17, 261);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(123, 13);
            this.labelD.TabIndex = 35;
            this.labelD.Text = "Wprowadź odpowiedź D";
            this.labelD.Visible = false;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(154, 261);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ReadOnly = true;
            this.textBoxD.Size = new System.Drawing.Size(620, 20);
            this.textBoxD.TabIndex = 34;
            this.textBoxD.Visible = false;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(154, 175);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(620, 20);
            this.textBoxB.TabIndex = 33;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(154, 220);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(620, 20);
            this.textBoxC.TabIndex = 32;
            this.textBoxC.Visible = false;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(154, 135);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(620, 20);
            this.textBoxA.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pytanie";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(154, 91);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(620, 20);
            this.textBoxQuestion.TabIndex = 29;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_time.Location = new System.Drawing.Point(697, 9);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(57, 63);
            this.label_time.TabIndex = 39;
            this.label_time.Text = "0";
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(780, 137);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxA.TabIndex = 40;
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(780, 177);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB.TabIndex = 41;
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(780, 219);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(15, 14);
            this.checkBoxC.TabIndex = 42;
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.Visible = false;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(780, 263);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(15, 14);
            this.checkBoxD.TabIndex = 43;
            this.checkBoxD.UseVisualStyleBackColor = true;
            this.checkBoxD.Visible = false;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(409, 340);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 44;
            this.button_next.Text = "Dalej";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Timer timer1;
    }
}