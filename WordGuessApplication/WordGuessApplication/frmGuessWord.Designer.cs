namespace WordGuessApplication
{
    partial class frmGuessWord
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
            this.wordGuessBox = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wrongGuessListBox = new System.Windows.Forms.ListBox();
            this.resetWordBtn = new System.Windows.Forms.Button();
            this.wordToGuessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordGuessBox
            // 
            this.wordGuessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordGuessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordGuessBox.Location = new System.Drawing.Point(41, 92);
            this.wordGuessBox.Name = "wordGuessBox";
            this.wordGuessBox.Size = new System.Drawing.Size(266, 29);
            this.wordGuessBox.TabIndex = 1;
            // 
            // guessBtn
            // 
            this.guessBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.guessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessBtn.ForeColor = System.Drawing.Color.White;
            this.guessBtn.Location = new System.Drawing.Point(136, 127);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(81, 28);
            this.guessBtn.TabIndex = 2;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = false;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wrong Guess";
            // 
            // wrongGuessListBox
            // 
            this.wrongGuessListBox.FormattingEnabled = true;
            this.wrongGuessListBox.Location = new System.Drawing.Point(373, 36);
            this.wrongGuessListBox.Name = "wrongGuessListBox";
            this.wrongGuessListBox.Size = new System.Drawing.Size(120, 121);
            this.wrongGuessListBox.TabIndex = 4;
            // 
            // resetWordBtn
            // 
            this.resetWordBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.resetWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetWordBtn.ForeColor = System.Drawing.Color.White;
            this.resetWordBtn.Location = new System.Drawing.Point(128, 161);
            this.resetWordBtn.Name = "resetWordBtn";
            this.resetWordBtn.Size = new System.Drawing.Size(96, 28);
            this.resetWordBtn.TabIndex = 5;
            this.resetWordBtn.Text = "Reset the Word";
            this.resetWordBtn.UseVisualStyleBackColor = false;
            this.resetWordBtn.Click += new System.EventHandler(this.resetWordBtn_Click);
            // 
            // wordToGuessLabel
            // 
            this.wordToGuessLabel.AutoSize = true;
            this.wordToGuessLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.wordToGuessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordToGuessLabel.ForeColor = System.Drawing.Color.White;
            this.wordToGuessLabel.Location = new System.Drawing.Point(107, 26);
            this.wordToGuessLabel.Name = "wordToGuessLabel";
            this.wordToGuessLabel.Size = new System.Drawing.Size(135, 24);
            this.wordToGuessLabel.TabIndex = 6;
            this.wordToGuessLabel.Text = "Word to Guess";
            // 
            // frmGuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 203);
            this.Controls.Add(this.wordToGuessLabel);
            this.Controls.Add(this.resetWordBtn);
            this.Controls.Add(this.wrongGuessListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.wordGuessBox);
            this.Name = "frmGuessWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox wordGuessBox;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wrongGuessListBox;
        private System.Windows.Forms.Button resetWordBtn;
        private System.Windows.Forms.Label wordToGuessLabel;
    }
}

