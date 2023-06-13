namespace exam2018
{
    partial class Form1
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
            comboBox_Region = new ComboBox();
            label1 = new Label();
            listBox_Circonscription = new ListBox();
            radioButton_Croissant = new RadioButton();
            radioButton_Decroissant = new RadioButton();
            SuspendLayout();
            // 
            // comboBox_Region
            // 
            comboBox_Region.FormattingEnabled = true;
            comboBox_Region.Location = new Point(277, 20);
            comboBox_Region.Name = "comboBox_Region";
            comboBox_Region.Size = new Size(121, 23);
            comboBox_Region.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // listBox_Circonscription
            // 
            listBox_Circonscription.FormattingEnabled = true;
            listBox_Circonscription.ItemHeight = 15;
            listBox_Circonscription.Location = new Point(280, 84);
            listBox_Circonscription.Name = "listBox_Circonscription";
            listBox_Circonscription.Size = new Size(120, 94);
            listBox_Circonscription.TabIndex = 2;
            // 
            // radioButton_Croissant
            // 
            radioButton_Croissant.AutoSize = true;
            radioButton_Croissant.Location = new Point(463, 88);
            radioButton_Croissant.Name = "radioButton_Croissant";
            radioButton_Croissant.Size = new Size(74, 19);
            radioButton_Croissant.TabIndex = 3;
            radioButton_Croissant.TabStop = true;
            radioButton_Croissant.Text = "Croissant";
            radioButton_Croissant.UseVisualStyleBackColor = true;
            // 
            // radioButton_Decroissant
            // 
            radioButton_Decroissant.AutoSize = true;
            radioButton_Decroissant.Location = new Point(463, 126);
            radioButton_Decroissant.Name = "radioButton_Decroissant";
            radioButton_Decroissant.Size = new Size(86, 19);
            radioButton_Decroissant.TabIndex = 3;
            radioButton_Decroissant.TabStop = true;
            radioButton_Decroissant.Text = "Decroissant";
            radioButton_Decroissant.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton_Decroissant);
            Controls.Add(radioButton_Croissant);
            Controls.Add(listBox_Circonscription);
            Controls.Add(label1);
            Controls.Add(comboBox_Region);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Region;
        private Label label1;
        private ListBox listBox_Circonscription;
        private RadioButton radioButton_Croissant;
        private RadioButton radioButton_Decroissant;
    }
}