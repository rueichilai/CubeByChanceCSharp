namespace CubeByChance
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
            this.comboboxRound = new System.Windows.Forms.ComboBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtCompetitorsNum = new System.Windows.Forms.TextBox();
            this.lblCompetitorsNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompetitorName = new System.Windows.Forms.Label();
            this.txtCompetitorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompetitorTime = new System.Windows.Forms.Label();
            this.txtCompetitorTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoundNumber = new System.Windows.Forms.TextBox();
            this.btnRoundNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboboxRound
            // 
            this.comboboxRound.FormattingEnabled = true;
            this.comboboxRound.Location = new System.Drawing.Point(17, 172);
            this.comboboxRound.Name = "comboboxRound";
            this.comboboxRound.Size = new System.Drawing.Size(252, 21);
            this.comboboxRound.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(690, 403);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 35);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Exit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // txtCompetitorsNum
            // 
            this.txtCompetitorsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorsNum.Location = new System.Drawing.Point(320, 7);
            this.txtCompetitorsNum.Multiline = true;
            this.txtCompetitorsNum.Name = "txtCompetitorsNum";
            this.txtCompetitorsNum.Size = new System.Drawing.Size(50, 37);
            this.txtCompetitorsNum.TabIndex = 2;
            this.txtCompetitorsNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCompetitorsNum
            // 
            this.lblCompetitorsNum.AutoSize = true;
            this.lblCompetitorsNum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorsNum.Location = new System.Drawing.Point(12, 12);
            this.lblCompetitorsNum.Name = "lblCompetitorsNum";
            this.lblCompetitorsNum.Size = new System.Drawing.Size(306, 26);
            this.lblCompetitorsNum.TabIndex = 3;
            this.lblCompetitorsNum.Text = "Enter the amount of Competitors:";
            this.lblCompetitorsNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter";
            // 
            // lblCompetitorName
            // 
            this.lblCompetitorName.AutoSize = true;
            this.lblCompetitorName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorName.Location = new System.Drawing.Point(63, 55);
            this.lblCompetitorName.Name = "lblCompetitorName";
            this.lblCompetitorName.Size = new System.Drawing.Size(185, 26);
            this.lblCompetitorName.TabIndex = 5;
            this.lblCompetitorName.Text = "Competitor\'s Name:";
            // 
            // txtCompetitorName
            // 
            this.txtCompetitorName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorName.Location = new System.Drawing.Point(246, 53);
            this.txtCompetitorName.Name = "txtCompetitorName";
            this.txtCompetitorName.Size = new System.Drawing.Size(217, 30);
            this.txtCompetitorName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter";
            // 
            // lblCompetitorTime
            // 
            this.lblCompetitorTime.AutoSize = true;
            this.lblCompetitorTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorTime.Location = new System.Drawing.Point(65, 95);
            this.lblCompetitorTime.Name = "lblCompetitorTime";
            this.lblCompetitorTime.Size = new System.Drawing.Size(177, 26);
            this.lblCompetitorTime.TabIndex = 8;
            this.lblCompetitorTime.Text = "Competitor\'s Time:";
            // 
            // txtCompetitorTime
            // 
            this.txtCompetitorTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorTime.Location = new System.Drawing.Point(238, 94);
            this.txtCompetitorTime.Name = "txtCompetitorTime";
            this.txtCompetitorTime.Size = new System.Drawing.Size(225, 30);
            this.txtCompetitorTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Round Number:";
            // 
            // txtRoundNumber
            // 
            this.txtRoundNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundNumber.Location = new System.Drawing.Point(156, 135);
            this.txtRoundNumber.Multiline = true;
            this.txtRoundNumber.Name = "txtRoundNumber";
            this.txtRoundNumber.Size = new System.Drawing.Size(41, 31);
            this.txtRoundNumber.TabIndex = 11;
            this.txtRoundNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRoundNext
            // 
            this.btnRoundNext.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundNext.Location = new System.Drawing.Point(203, 135);
            this.btnRoundNext.Name = "btnRoundNext";
            this.btnRoundNext.Size = new System.Drawing.Size(76, 31);
            this.btnRoundNext.TabIndex = 12;
            this.btnRoundNext.Text = "Next";
            this.btnRoundNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRoundNext.UseVisualStyleBackColor = true;
            this.btnRoundNext.Click += new System.EventHandler(this.btnRoundNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRoundNext);
            this.Controls.Add(this.txtRoundNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompetitorTime);
            this.Controls.Add(this.lblCompetitorTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompetitorName);
            this.Controls.Add(this.lblCompetitorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompetitorsNum);
            this.Controls.Add(this.txtCompetitorsNum);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.comboboxRound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxRound;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtCompetitorsNum;
        private System.Windows.Forms.Label lblCompetitorsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompetitorName;
        private System.Windows.Forms.TextBox txtCompetitorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompetitorTime;
        private System.Windows.Forms.TextBox txtCompetitorTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoundNumber;
        private System.Windows.Forms.Button btnRoundNext;
    }
}

