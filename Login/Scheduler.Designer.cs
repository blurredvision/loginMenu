namespace Login
{
    partial class Scheduler
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonBox1 = new System.Windows.Forms.ComboBox();
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonBox2 = new System.Windows.Forms.ComboBox();
            this.PersonBox3 = new System.Windows.Forms.ComboBox();
            this.PersonBox4 = new System.Windows.Forms.ComboBox();
            this.PersonBox5 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scheduler Menu";
            // 
            // PersonBox1
            // 
            this.PersonBox1.FormattingEnabled = true;
            this.PersonBox1.Location = new System.Drawing.Point(177, 134);
            this.PersonBox1.Name = "PersonBox1";
            this.PersonBox1.Size = new System.Drawing.Size(121, 21);
            this.PersonBox1.TabIndex = 2;
            this.PersonBox1.Text = "Attendee";
            // 
            // RoomBox
            // 
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(338, 134);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(121, 21);
            this.RoomBox.TabIndex = 3;
            this.RoomBox.Text = "Room";
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(494, 134);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 21);
            this.TimeBox.TabIndex = 4;
            this.TimeBox.Text = "Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // PersonBox2
            // 
            this.PersonBox2.FormattingEnabled = true;
            this.PersonBox2.Location = new System.Drawing.Point(177, 161);
            this.PersonBox2.Name = "PersonBox2";
            this.PersonBox2.Size = new System.Drawing.Size(121, 21);
            this.PersonBox2.TabIndex = 7;
            this.PersonBox2.Text = "Attendee";
            // 
            // PersonBox3
            // 
            this.PersonBox3.FormattingEnabled = true;
            this.PersonBox3.Location = new System.Drawing.Point(177, 188);
            this.PersonBox3.Name = "PersonBox3";
            this.PersonBox3.Size = new System.Drawing.Size(121, 21);
            this.PersonBox3.TabIndex = 8;
            this.PersonBox3.Text = "Attendee";
            // 
            // PersonBox4
            // 
            this.PersonBox4.FormattingEnabled = true;
            this.PersonBox4.Location = new System.Drawing.Point(177, 215);
            this.PersonBox4.Name = "PersonBox4";
            this.PersonBox4.Size = new System.Drawing.Size(121, 21);
            this.PersonBox4.TabIndex = 9;
            this.PersonBox4.Text = "Attendee";
            // 
            // PersonBox5
            // 
            this.PersonBox5.FormattingEnabled = true;
            this.PersonBox5.Location = new System.Drawing.Point(177, 242);
            this.PersonBox5.Name = "PersonBox5";
            this.PersonBox5.Size = new System.Drawing.Size(121, 21);
            this.PersonBox5.TabIndex = 10;
            this.PersonBox5.Text = "Attendee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PersonBox5);
            this.Controls.Add(this.PersonBox4);
            this.Controls.Add(this.PersonBox3);
            this.Controls.Add(this.PersonBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.PersonBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Scheduler";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PersonBox1;
        private System.Windows.Forms.ComboBox RoomBox;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PersonBox2;
        private System.Windows.Forms.ComboBox PersonBox3;
        private System.Windows.Forms.ComboBox PersonBox4;
        private System.Windows.Forms.ComboBox PersonBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}