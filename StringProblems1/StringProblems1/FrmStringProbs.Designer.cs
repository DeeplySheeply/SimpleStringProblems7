
namespace StringProblems1
{
    partial class FrmVowelCount
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
            this.TxtVowels = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnCountVowels = new System.Windows.Forms.Button();
            this.BtnThe = new System.Windows.Forms.Button();
            this.BtnMiddle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtVowels
            // 
            this.TxtVowels.Location = new System.Drawing.Point(350, 194);
            this.TxtVowels.Name = "TxtVowels";
            this.TxtVowels.Size = new System.Drawing.Size(100, 20);
            this.TxtVowels.TabIndex = 0;
            this.TxtVowels.TextChanged += new System.EventHandler(this.TxtVowels_TextChanged);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(329, 145);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(143, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Enter a string of letters below";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // BtnCountVowels
            // 
            this.BtnCountVowels.Location = new System.Drawing.Point(340, 253);
            this.BtnCountVowels.Name = "BtnCountVowels";
            this.BtnCountVowels.Size = new System.Drawing.Size(121, 23);
            this.BtnCountVowels.TabIndex = 2;
            this.BtnCountVowels.Text = "Count Vowels";
            this.BtnCountVowels.UseVisualStyleBackColor = true;
            this.BtnCountVowels.Click += new System.EventHandler(this.BtnCountVowels_Click);
            // 
            // BtnThe
            // 
            this.BtnThe.Location = new System.Drawing.Point(340, 296);
            this.BtnThe.Name = "BtnThe";
            this.BtnThe.Size = new System.Drawing.Size(121, 23);
            this.BtnThe.TabIndex = 3;
            this.BtnThe.Text = "Count \"the\"";
            this.BtnThe.UseVisualStyleBackColor = true;
            this.BtnThe.Click += new System.EventHandler(this.BtnThe_Click);
            // 
            // BtnMiddle
            // 
            this.BtnMiddle.Location = new System.Drawing.Point(340, 339);
            this.BtnMiddle.Name = "BtnMiddle";
            this.BtnMiddle.Size = new System.Drawing.Size(121, 23);
            this.BtnMiddle.TabIndex = 4;
            this.BtnMiddle.Text = "Middle Character";
            this.BtnMiddle.UseVisualStyleBackColor = true;
            this.BtnMiddle.Click += new System.EventHandler(this.BtnMiddle_Click);
            // 
            // FrmVowelCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMiddle);
            this.Controls.Add(this.BtnThe);
            this.Controls.Add(this.BtnCountVowels);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtVowels);
            this.Name = "FrmVowelCount";
            this.Text = "Count the vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtVowels;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnCountVowels;
        private System.Windows.Forms.Button BtnThe;
        private System.Windows.Forms.Button BtnMiddle;
    }
}

