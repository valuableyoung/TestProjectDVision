namespace WinFormsLetter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bodytb = new System.Windows.Forms.TextBox();
            this.Subjecttb = new System.Windows.Forms.TextBox();
            this.Totb = new System.Windows.Forms.TextBox();
            this.Sendertb = new System.Windows.Forms.TextBox();
            this.Datetb = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bodytb
            // 
            this.Bodytb.Location = new System.Drawing.Point(176, 107);
            this.Bodytb.Multiline = true;
            this.Bodytb.Name = "Bodytb";
            this.Bodytb.Size = new System.Drawing.Size(559, 227);
            this.Bodytb.TabIndex = 0;
            // 
            // Subjecttb
            // 
            this.Subjecttb.Location = new System.Drawing.Point(185, 12);
            this.Subjecttb.Name = "Subjecttb";
            this.Subjecttb.Size = new System.Drawing.Size(240, 23);
            this.Subjecttb.TabIndex = 1;
            // 
            // Totb
            // 
            this.Totb.Location = new System.Drawing.Point(185, 51);
            this.Totb.Name = "Totb";
            this.Totb.Size = new System.Drawing.Size(240, 23);
            this.Totb.TabIndex = 2;
            // 
            // Sendertb
            // 
            this.Sendertb.Location = new System.Drawing.Point(502, 54);
            this.Sendertb.Name = "Sendertb";
            this.Sendertb.Size = new System.Drawing.Size(233, 23);
            this.Sendertb.TabIndex = 3;
            this.Sendertb.TextChanged += new System.EventHandler(this.Sendertb_TextChanged);
            // 
            // Datetb
            // 
            this.Datetb.Location = new System.Drawing.Point(502, 9);
            this.Datetb.Name = "Datetb";
            this.Datetb.Size = new System.Drawing.Size(233, 23);
            this.Datetb.TabIndex = 4;
            this.Datetb.TextChanged += new System.EventHandler(this.Datetb_TextChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(12, 12);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(82, 75);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.Datetb);
            this.Controls.Add(this.Sendertb);
            this.Controls.Add(this.Totb);
            this.Controls.Add(this.Subjecttb);
            this.Controls.Add(this.Bodytb);
            this.Name = "Form1";
            this.Text = "Letter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Bodytb;
        private TextBox Subjecttb;
        private TextBox Totb;
        private TextBox Sendertb;
        private TextBox Datetb;
        private Button SendBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}