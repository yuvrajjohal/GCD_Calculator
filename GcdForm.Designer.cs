namespace EuclideanGcdVersusBruteForceGcd
{
    partial class GcdForm
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
            this.Num1TextBox = new System.Windows.Forms.TextBox();
            this.Num2TextBox = new System.Windows.Forms.TextBox();
            this.GcdLabel = new System.Windows.Forms.Label();
            this.EuclideanGcdOverload1Button = new System.Windows.Forms.Button();
            this.BruteForceGcdOverload1Button = new System.Windows.Forms.Button();
            this.BruteForceGcdOverload2Button = new System.Windows.Forms.Button();
            this.EuclideanGcdOverload2Button = new System.Windows.Forms.Button();
            this.ExecutionTimeLabel = new System.Windows.Forms.Label();
            this.BruteForceGCDBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ComputingInBackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1TextBox
            // 
            this.Num1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1TextBox.Location = new System.Drawing.Point(13, 67);
            this.Num1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Num1TextBox.MaxLength = 19;
            this.Num1TextBox.Name = "Num1TextBox";
            this.Num1TextBox.Size = new System.Drawing.Size(193, 26);
            this.Num1TextBox.TabIndex = 0;
            this.Num1TextBox.Text = "2145678903";
            // 
            // Num2TextBox
            // 
            this.Num2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2TextBox.Location = new System.Drawing.Point(214, 67);
            this.Num2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Num2TextBox.MaxLength = 19;
            this.Num2TextBox.Name = "Num2TextBox";
            this.Num2TextBox.Size = new System.Drawing.Size(193, 26);
            this.Num2TextBox.TabIndex = 1;
            this.Num2TextBox.Text = "1234567890";
            // 
            // GcdLabel
            // 
            this.GcdLabel.AutoSize = true;
            this.GcdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GcdLabel.ForeColor = System.Drawing.Color.Blue;
            this.GcdLabel.Location = new System.Drawing.Point(8, 202);
            this.GcdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GcdLabel.Name = "GcdLabel";
            this.GcdLabel.Size = new System.Drawing.Size(90, 25);
            this.GcdLabel.TabIndex = 2;
            this.GcdLabel.Text = "gcd label";
            // 
            // EuclideanGcdOverload1Button
            // 
            this.EuclideanGcdOverload1Button.Location = new System.Drawing.Point(13, 112);
            this.EuclideanGcdOverload1Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EuclideanGcdOverload1Button.Name = "EuclideanGcdOverload1Button";
            this.EuclideanGcdOverload1Button.Size = new System.Drawing.Size(123, 65);
            this.EuclideanGcdOverload1Button.TabIndex = 3;
            this.EuclideanGcdOverload1Button.Text = "Euclidean GCD Overload 1 (returns \'int\')";
            this.EuclideanGcdOverload1Button.UseVisualStyleBackColor = true;
            this.EuclideanGcdOverload1Button.Click += new System.EventHandler(this.EuclideanGcdOverload1Button_Click);
            // 
            // BruteForceGcdOverload1Button
            // 
            this.BruteForceGcdOverload1Button.Location = new System.Drawing.Point(271, 112);
            this.BruteForceGcdOverload1Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BruteForceGcdOverload1Button.Name = "BruteForceGcdOverload1Button";
            this.BruteForceGcdOverload1Button.Size = new System.Drawing.Size(128, 65);
            this.BruteForceGcdOverload1Button.TabIndex = 4;
            this.BruteForceGcdOverload1Button.Text = "Brute-Force GCD Overload 1 (returns \'int\')";
            this.BruteForceGcdOverload1Button.UseVisualStyleBackColor = true;
            this.BruteForceGcdOverload1Button.Click += new System.EventHandler(this.BruteForceGcdOverload1Button_Click);
            // 
            // BruteForceGcdOverload2Button
            // 
            this.BruteForceGcdOverload2Button.Location = new System.Drawing.Point(407, 112);
            this.BruteForceGcdOverload2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BruteForceGcdOverload2Button.Name = "BruteForceGcdOverload2Button";
            this.BruteForceGcdOverload2Button.Size = new System.Drawing.Size(129, 65);
            this.BruteForceGcdOverload2Button.TabIndex = 6;
            this.BruteForceGcdOverload2Button.Text = "Brute-Force GCD  Overload 2 (returns \'long\')";
            this.BruteForceGcdOverload2Button.UseVisualStyleBackColor = true;
            this.BruteForceGcdOverload2Button.Click += new System.EventHandler(this.BruteForceGcdOverload2Button_Click);
            // 
            // EuclideanGcdOverload2Button
            // 
            this.EuclideanGcdOverload2Button.Location = new System.Drawing.Point(144, 112);
            this.EuclideanGcdOverload2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EuclideanGcdOverload2Button.Name = "EuclideanGcdOverload2Button";
            this.EuclideanGcdOverload2Button.Size = new System.Drawing.Size(119, 65);
            this.EuclideanGcdOverload2Button.TabIndex = 5;
            this.EuclideanGcdOverload2Button.Text = "Euclidean GCD Overload 2 (returns \'long\')";
            this.EuclideanGcdOverload2Button.UseVisualStyleBackColor = true;
            this.EuclideanGcdOverload2Button.Click += new System.EventHandler(this.EuclideanGcdOverload2Button_Click);
            // 
            // ExecutionTimeLabel
            // 
            this.ExecutionTimeLabel.AutoSize = true;
            this.ExecutionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecutionTimeLabel.ForeColor = System.Drawing.Color.Blue;
            this.ExecutionTimeLabel.Location = new System.Drawing.Point(9, 244);
            this.ExecutionTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExecutionTimeLabel.Name = "ExecutionTimeLabel";
            this.ExecutionTimeLabel.Size = new System.Drawing.Size(178, 24);
            this.ExecutionTimeLabel.TabIndex = 7;
            this.ExecutionTimeLabel.Text = "execution time label";
            // 
            // BruteForceGCDBackgroundWorker
            // 
            this.BruteForceGCDBackgroundWorker.WorkerReportsProgress = true;
            this.BruteForceGCDBackgroundWorker.WorkerSupportsCancellation = true;
            this.BruteForceGCDBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BruteForceGCDBackgroundWorker_DoWork);
            this.BruteForceGCDBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BruteForceGCDBackgroundWorker_RunWorkerCompleted);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(544, 112);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(143, 65);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel Brute-Force Computation of GCD";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ComputingInBackgroundTimer
            // 
            this.ComputingInBackgroundTimer.Interval = 750;
            this.ComputingInBackgroundTimer.Tick += new System.EventHandler(this.ComputingInBackgroundTimer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "This app shows the importance of choosing algorithms. The Euclidean algorithm for" +
    " computing the greatest common divisor of two integers is clearly much more effi" +
    "cient than any brute-force method. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GcdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExecutionTimeLabel);
            this.Controls.Add(this.BruteForceGcdOverload2Button);
            this.Controls.Add(this.EuclideanGcdOverload2Button);
            this.Controls.Add(this.BruteForceGcdOverload1Button);
            this.Controls.Add(this.EuclideanGcdOverload1Button);
            this.Controls.Add(this.GcdLabel);
            this.Controls.Add(this.Num2TextBox);
            this.Controls.Add(this.Num1TextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GcdForm";
            this.Text = "Comparing Execution Time of Euclidean and Brute-Force GCD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1TextBox;
        private System.Windows.Forms.TextBox Num2TextBox;
        private System.Windows.Forms.Label GcdLabel;
        private System.Windows.Forms.Button EuclideanGcdOverload1Button;
        private System.Windows.Forms.Button BruteForceGcdOverload1Button;
        private System.Windows.Forms.Button BruteForceGcdOverload2Button;
        private System.Windows.Forms.Button EuclideanGcdOverload2Button;
        private System.Windows.Forms.Label ExecutionTimeLabel;
        private System.ComponentModel.BackgroundWorker BruteForceGCDBackgroundWorker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Timer ComputingInBackgroundTimer;
        private System.Windows.Forms.Label label1;
    }
}

