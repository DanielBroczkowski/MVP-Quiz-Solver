namespace Quiz_solver
{
    partial class Form3
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
            this.label_zakończony = new System.Windows.Forms.Label();
            this.label_wynik_text = new System.Windows.Forms.Label();
            this.label_wynik_pkt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_zakończony
            // 
            this.label_zakończony.AutoSize = true;
            this.label_zakończony.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zakończony.Location = new System.Drawing.Point(255, 61);
            this.label_zakończony.Name = "label_zakończony";
            this.label_zakończony.Size = new System.Drawing.Size(301, 39);
            this.label_zakończony.TabIndex = 20;
            this.label_zakończony.Text = "Quiz Zakończony";
            // 
            // label_wynik_text
            // 
            this.label_wynik_text.AutoSize = true;
            this.label_wynik_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wynik_text.Location = new System.Drawing.Point(177, 171);
            this.label_wynik_text.Name = "label_wynik_text";
            this.label_wynik_text.Size = new System.Drawing.Size(129, 39);
            this.label_wynik_text.TabIndex = 21;
            this.label_wynik_text.Text = "Wynik:";
            // 
            // label_wynik_pkt
            // 
            this.label_wynik_pkt.AutoSize = true;
            this.label_wynik_pkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wynik_pkt.Location = new System.Drawing.Point(507, 171);
            this.label_wynik_pkt.Name = "label_wynik_pkt";
            this.label_wynik_pkt.Size = new System.Drawing.Size(118, 39);
            this.label_wynik_pkt.TabIndex = 22;
            this.label_wynik_pkt.Text = "Wynik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Zakończ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_wynik_pkt);
            this.Controls.Add(this.label_wynik_text);
            this.Controls.Add(this.label_zakończony);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_zakończony;
        private System.Windows.Forms.Label label_wynik_text;
        private System.Windows.Forms.Label label_wynik_pkt;
        private System.Windows.Forms.Button button1;
    }
}