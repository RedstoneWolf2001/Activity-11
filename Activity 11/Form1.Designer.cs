namespace Activity_11
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
            this.RollBTN = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.ErrorProvider(this.components);
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Finish)).BeginInit();
            this.SuspendLayout();
            // 
            // RollBTN
            // 
            this.RollBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollBTN.Location = new System.Drawing.Point(13, 13);
            this.RollBTN.Name = "RollBTN";
            this.RollBTN.Size = new System.Drawing.Size(100, 100);
            this.RollBTN.TabIndex = 0;
            this.RollBTN.Text = "Roll Dice";
            this.RollBTN.UseVisualStyleBackColor = true;
            this.RollBTN.Click += new System.EventHandler(this.RollBTN_Click);
            // 
            // Finish
            // 
            this.Finish.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Finish.ContainerControl = this;
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.Black;
            this.Num1.ForeColor = System.Drawing.Color.White;
            this.Num1.Location = new System.Drawing.Point(137, 26);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(75, 75);
            this.Num1.TabIndex = 1;
            this.Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.Black;
            this.Num2.ForeColor = System.Drawing.Color.White;
            this.Num2.Location = new System.Drawing.Point(218, 26);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(75, 75);
            this.Num2.TabIndex = 2;
            this.Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(332, 132);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.RollBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Finish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RollBTN;
        private System.Windows.Forms.ErrorProvider Finish;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
    }
}

