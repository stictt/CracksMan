using CracksMan.Models;

namespace CracksMan
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lableScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(55, 172);
            this.numericX.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(56, 23);
            this.numericX.TabIndex = 2;
            this.numericX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Доска";
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(165, 172);
            this.numericY.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(56, 23);
            this.numericY.TabIndex = 4;
            this.numericY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "На";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Счет";
            // 
            // lableScore
            // 
            this.lableScore.AutoSize = true;
            this.lableScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lableScore.Location = new System.Drawing.Point(120, 81);
            this.lableScore.Name = "lableScore";
            this.lableScore.Size = new System.Drawing.Size(35, 30);
            this.lableScore.TabIndex = 7;
            this.lableScore.Text = "54";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(283, 269);
            this.Controls.Add(this.lableScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(299, 308);
            this.MinimumSize = new System.Drawing.Size(299, 308);
            this.Name = "MainForm";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private NumericUpDown numericX;
        private Label label1;
        private NumericUpDown numericY;
        private Label label2;
        private Label label3;
        private Label lableScore;
    }
}