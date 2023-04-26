namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOne = new System.Windows.Forms.Button();
            this.panelTwo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputOne = new System.Windows.Forms.TextBox();
            this.inputTwo = new System.Windows.Forms.TextBox();
            this.panelTwo11 = new WindowsFormsApp1.panelTwo1();
            this.panelOne11 = new WindowsFormsApp1.panelOne1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTwo);
            this.panel1.Controls.Add(this.panelOne);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 686);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inputTwo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.inputOne);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(831, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 686);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(252, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Control Panel Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelOne
            // 
            this.panelOne.Location = new System.Drawing.Point(55, 228);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(118, 54);
            this.panelOne.TabIndex = 3;
            this.panelOne.Text = "Panel One";
            this.panelOne.UseVisualStyleBackColor = true;
            this.panelOne.Click += new System.EventHandler(this.panelOne_Click);
            // 
            // panelTwo
            // 
            this.panelTwo.Location = new System.Drawing.Point(55, 326);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(118, 54);
            this.panelTwo.TabIndex = 4;
            this.panelTwo.Text = "Panel Two";
            this.panelTwo.UseVisualStyleBackColor = true;
            this.panelTwo.Click += new System.EventHandler(this.panelTwo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input One:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input Two:";
            // 
            // inputOne
            // 
            this.inputOne.Location = new System.Drawing.Point(23, 165);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(177, 26);
            this.inputOne.TabIndex = 3;
            // 
            // inputTwo
            // 
            this.inputTwo.Location = new System.Drawing.Point(23, 250);
            this.inputTwo.Name = "inputTwo";
            this.inputTwo.Size = new System.Drawing.Size(177, 26);
            this.inputTwo.TabIndex = 4;
            // 
            // panelTwo11
            // 
            this.panelTwo11.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelTwo11.Location = new System.Drawing.Point(239, 95);
            this.panelTwo11.Name = "panelTwo11";
            this.panelTwo11.Size = new System.Drawing.Size(578, 495);
            this.panelTwo11.TabIndex = 4;
            // 
            // panelOne11
            // 
            this.panelOne11.BackColor = System.Drawing.Color.Moccasin;
            this.panelOne11.Location = new System.Drawing.Point(239, 95);
            this.panelOne11.Name = "panelOne11";
            this.panelOne11.Size = new System.Drawing.Size(578, 495);
            this.panelOne11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 686);
            this.Controls.Add(this.panelTwo11);
            this.Controls.Add(this.panelOne11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panelTwo;
        private System.Windows.Forms.Button panelOne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private panelOne1 panelOne11;
        private panelTwo1 panelTwo11;
    }
}

