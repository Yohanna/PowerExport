namespace PowerExport
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
            this.aboutButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.officeVersionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(318, 197);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 27;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.AutoSize = true;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(167, 193);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 28);
            this.changeButton.TabIndex = 26;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // officeVersionComboBox
            // 
            this.officeVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeVersionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeVersionComboBox.FormattingEnabled = true;
            this.officeVersionComboBox.Items.AddRange(new object[] {
            "2013",
            "2010",
            "2007",
            "2003"});
            this.officeVersionComboBox.Location = new System.Drawing.Point(256, 132);
            this.officeVersionComboBox.Name = "officeVersionComboBox";
            this.officeVersionComboBox.Size = new System.Drawing.Size(59, 26);
            this.officeVersionComboBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 54);
            this.label5.TabIndex = 23;
            this.label5.Text = "default selection should display current version of office or an error if nothing" +
    " found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Office Version:";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(256, 39);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(46, 18);
            this.currentLabel.TabIndex = 22;
            this.currentLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Current Resolution:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "dpi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose required resolution:";
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DisplayMember = "1";
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resolutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "96",
            "100",
            "150",
            "200",
            "250",
            "300"});
            this.resolutionComboBox.Location = new System.Drawing.Point(256, 84);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(59, 26);
            this.resolutionComboBox.TabIndex = 18;
            this.resolutionComboBox.ValueMember = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.officeVersionComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolutionComboBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ComboBox officeVersionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox resolutionComboBox;
    }
}

