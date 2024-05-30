namespace CoinFlip
{
    partial class MainForm
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
            this.FlipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FlipCountTextBox = new System.Windows.Forms.TextBox();
            this.HighestHeadLabel = new System.Windows.Forms.Label();
            this.HighestTailsLabel = new System.Windows.Forms.Label();
            this.NewHeadRecordLabel = new System.Windows.Forms.Label();
            this.OldHeadRecordLabel = new System.Windows.Forms.Label();
            this.NewTailRecordLabel = new System.Windows.Forms.Label();
            this.OldTailRecordLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlipButton
            // 
            this.FlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FlipButton.Location = new System.Drawing.Point(300, 203);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(193, 50);
            this.FlipButton.TabIndex = 0;
            this.FlipButton.Text = "Flip The Coin!";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(184, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many times you want to flip? (0 - 1000)";
            // 
            // FlipCountTextBox
            // 
            this.FlipCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FlipCountTextBox.Location = new System.Drawing.Point(344, 141);
            this.FlipCountTextBox.Name = "FlipCountTextBox";
            this.FlipCountTextBox.Size = new System.Drawing.Size(100, 38);
            this.FlipCountTextBox.TabIndex = 2;
            // 
            // HighestHeadLabel
            // 
            this.HighestHeadLabel.AutoSize = true;
            this.HighestHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.HighestHeadLabel.Location = new System.Drawing.Point(102, 287);
            this.HighestHeadLabel.Name = "HighestHeadLabel";
            this.HighestHeadLabel.Size = new System.Drawing.Size(0, 26);
            this.HighestHeadLabel.TabIndex = 1;
            // 
            // HighestTailsLabel
            // 
            this.HighestTailsLabel.AutoSize = true;
            this.HighestTailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.HighestTailsLabel.Location = new System.Drawing.Point(102, 324);
            this.HighestTailsLabel.Name = "HighestTailsLabel";
            this.HighestTailsLabel.Size = new System.Drawing.Size(0, 26);
            this.HighestTailsLabel.TabIndex = 1;
            // 
            // NewHeadRecordLabel
            // 
            this.NewHeadRecordLabel.AutoSize = true;
            this.NewHeadRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NewHeadRecordLabel.Location = new System.Drawing.Point(102, 371);
            this.NewHeadRecordLabel.Name = "NewHeadRecordLabel";
            this.NewHeadRecordLabel.Size = new System.Drawing.Size(0, 26);
            this.NewHeadRecordLabel.TabIndex = 1;
            // 
            // OldHeadRecordLabel
            // 
            this.OldHeadRecordLabel.AutoSize = true;
            this.OldHeadRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.OldHeadRecordLabel.Location = new System.Drawing.Point(102, 408);
            this.OldHeadRecordLabel.Name = "OldHeadRecordLabel";
            this.OldHeadRecordLabel.Size = new System.Drawing.Size(0, 26);
            this.OldHeadRecordLabel.TabIndex = 1;
            // 
            // NewTailRecordLabel
            // 
            this.NewTailRecordLabel.AutoSize = true;
            this.NewTailRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NewTailRecordLabel.Location = new System.Drawing.Point(102, 453);
            this.NewTailRecordLabel.Name = "NewTailRecordLabel";
            this.NewTailRecordLabel.Size = new System.Drawing.Size(0, 26);
            this.NewTailRecordLabel.TabIndex = 1;
            // 
            // OldTailRecordLabel
            // 
            this.OldTailRecordLabel.AutoSize = true;
            this.OldTailRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.OldTailRecordLabel.Location = new System.Drawing.Point(102, 490);
            this.OldTailRecordLabel.Name = "OldTailRecordLabel";
            this.OldTailRecordLabel.Size = new System.Drawing.Size(0, 26);
            this.OldTailRecordLabel.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ExitButton.Location = new System.Drawing.Point(546, 203);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 50);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FlipCountTextBox);
            this.Controls.Add(this.OldTailRecordLabel);
            this.Controls.Add(this.NewTailRecordLabel);
            this.Controls.Add(this.OldHeadRecordLabel);
            this.Controls.Add(this.NewHeadRecordLabel);
            this.Controls.Add(this.HighestTailsLabel);
            this.Controls.Add(this.HighestHeadLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlipButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Flip The Coin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FlipCountTextBox;
        private System.Windows.Forms.Label HighestHeadLabel;
        private System.Windows.Forms.Label HighestTailsLabel;
        private System.Windows.Forms.Label NewHeadRecordLabel;
        private System.Windows.Forms.Label OldHeadRecordLabel;
        private System.Windows.Forms.Label NewTailRecordLabel;
        private System.Windows.Forms.Label OldTailRecordLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

