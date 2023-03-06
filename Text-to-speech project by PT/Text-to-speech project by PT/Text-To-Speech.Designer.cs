namespace Text_to_speech_project_by_PT
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
            this.rtspeak = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtspeak
            // 
            this.rtspeak.Location = new System.Drawing.Point(41, 130);
            this.rtspeak.Name = "rtspeak";
            this.rtspeak.Size = new System.Drawing.Size(904, 285);
            this.rtspeak.TabIndex = 0;
            this.rtspeak.Text = "";
            this.rtspeak.TextChanged += new System.EventHandler(this.rtspeak_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(99, 104);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(8, 8);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(57, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(286, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(749, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 89);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(522, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 89);
            this.button4.TabIndex = 4;
            this.button4.Text = "Resume";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text-To-Speech Vr1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rtspeak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtspeak;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

