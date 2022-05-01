namespace IC8_KS_MonthTranslator
{
    partial class MonthTranslatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.swedishRadioButton = new System.Windows.Forms.RadioButton();
            this.deutschRadioButton = new System.Windows.Forms.RadioButton();
            this.translateButton = new System.Windows.Forms.Button();
            this.translateLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(162, 104);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(137, 20);
            this.monthTextBox.TabIndex = 1;
            // 
            // swedishRadioButton
            // 
            this.swedishRadioButton.AutoSize = true;
            this.swedishRadioButton.Location = new System.Drawing.Point(54, 26);
            this.swedishRadioButton.Name = "swedishRadioButton";
            this.swedishRadioButton.Size = new System.Drawing.Size(65, 17);
            this.swedishRadioButton.TabIndex = 3;
            this.swedishRadioButton.TabStop = true;
            this.swedishRadioButton.Text = "Swedish";
            this.swedishRadioButton.UseVisualStyleBackColor = true;
            // 
            // deutschRadioButton
            // 
            this.deutschRadioButton.AutoSize = true;
            this.deutschRadioButton.Location = new System.Drawing.Point(54, 59);
            this.deutschRadioButton.Name = "deutschRadioButton";
            this.deutschRadioButton.Size = new System.Drawing.Size(65, 17);
            this.deutschRadioButton.TabIndex = 4;
            this.deutschRadioButton.TabStop = true;
            this.deutschRadioButton.Text = "Deutsch";
            this.deutschRadioButton.UseVisualStyleBackColor = true;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(194, 327);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Location = new System.Drawing.Point(116, 385);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(224, 54);
            this.translateLabel.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(91, 477);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(286, 476);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swedishRadioButton);
            this.groupBox1.Controls.Add(this.deutschRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(140, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translate Into:";
            // 
            // MonthTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MonthTranslatorForm";
            this.Text = "Month Translator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.RadioButton swedishRadioButton;
        private System.Windows.Forms.RadioButton deutschRadioButton;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

