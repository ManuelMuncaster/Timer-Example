namespace Timer_Example
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
            this.components = new System.ComponentModel.Container();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.milliLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countTimer
            // 
            this.countTimer.Interval = 10;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(96, 110);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // milliLabel
            // 
            this.milliLabel.AutoSize = true;
            this.milliLabel.Location = new System.Drawing.Point(168, 42);
            this.milliLabel.Name = "milliLabel";
            this.milliLabel.Size = new System.Drawing.Size(35, 13);
            this.milliLabel.TabIndex = 1;
            this.milliLabel.Text = "label1";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(110, 42);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(35, 13);
            this.secLabel.TabIndex = 2;
            this.secLabel.Text = "label1";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(46, 42);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(35, 13);
            this.minLabel.TabIndex = 3;
            this.minLabel.Text = "label1";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(96, 154);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.milliLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label milliLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

