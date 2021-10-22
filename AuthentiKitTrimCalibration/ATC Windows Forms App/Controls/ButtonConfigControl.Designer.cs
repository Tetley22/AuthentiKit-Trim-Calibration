﻿
namespace ATC_Windows_Forms_App.Controls
{
    partial class ButtonConfigControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlButtonConfig = new System.Windows.Forms.Panel();
            this.tbMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOutput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInputA = new System.Windows.Forms.ComboBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.pnlButtonConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtonConfig
            // 
            this.pnlButtonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtonConfig.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonConfig.Controls.Add(this.tbMultiplier);
            this.pnlButtonConfig.Controls.Add(this.label3);
            this.pnlButtonConfig.Controls.Add(this.cbOutput);
            this.pnlButtonConfig.Controls.Add(this.label1);
            this.pnlButtonConfig.Controls.Add(this.cbInputA);
            this.pnlButtonConfig.Controls.Add(this.lblMultiplier);
            this.pnlButtonConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonConfig.Name = "pnlButtonConfig";
            this.pnlButtonConfig.Size = new System.Drawing.Size(407, 256);
            this.pnlButtonConfig.TabIndex = 4;
            // 
            // tbMultiplier
            // 
            this.tbMultiplier.Location = new System.Drawing.Point(19, 154);
            this.tbMultiplier.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbMultiplier.Name = "tbMultiplier";
            this.tbMultiplier.Size = new System.Drawing.Size(360, 23);
            this.tbMultiplier.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Virtual Output Button";
            // 
            // cbOutput
            // 
            this.cbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.Location = new System.Drawing.Point(19, 91);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(360, 23);
            this.cbOutput.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input Button";
            // 
            // cbInputA
            // 
            this.cbInputA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInputA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputA.FormattingEnabled = true;
            this.cbInputA.Location = new System.Drawing.Point(19, 33);
            this.cbInputA.Name = "cbInputA";
            this.cbInputA.Size = new System.Drawing.Size(360, 23);
            this.cbInputA.TabIndex = 8;
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(18, 135);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(209, 15);
            this.lblMultiplier.TabIndex = 2;
            this.lblMultiplier.Text = "Multipler (pulses out per button press)";
            // 
            // ButtonConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlButtonConfig);
            this.Name = "ButtonConfigControl";
            this.Size = new System.Drawing.Size(407, 256);
            this.pnlButtonConfig.ResumeLayout(false);
            this.pnlButtonConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonConfig;
        private System.Windows.Forms.NumericUpDown tbMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInputA;
        private System.Windows.Forms.Label lblMultiplier;
    }
}