﻿namespace ClashSinicizationToolUpgrade
{
    partial class UpgradeMainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ContentLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RunButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ContentLabel, 2);
            this.ContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLabel.Location = new System.Drawing.Point(3, 0);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(186, 45);
            this.ContentLabel.TabIndex = 3;
            this.ContentLabel.Text = "Label";
            this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RunButton, 2);
            this.RunButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunButton.Location = new System.Drawing.Point(50, 50);
            this.RunButton.Margin = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(92, 26);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "启动程序";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // UpgradeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 81);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpgradeMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clash 汉化工具升级程序";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpgradeMainForm_FormClosed);
            this.Load += new System.EventHandler(this.UpgradeMainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button RunButton;
        private Label ContentLabel;
    }
}