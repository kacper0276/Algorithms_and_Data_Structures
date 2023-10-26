namespace AiSD_IO2_cw4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.generateNumber = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.sortInsert = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.separatorSelected = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generateNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(165, 274);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 23);
            this.wynik.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "SS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(316, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Lewa strona aktywna";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // generateNumber
            // 
            this.generateNumber.Location = new System.Drawing.Point(458, 143);
            this.generateNumber.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.generateNumber.Name = "generateNumber";
            this.generateNumber.Size = new System.Drawing.Size(120, 23);
            this.generateNumber.TabIndex = 5;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(458, 193);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(120, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generuj";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(382, 277);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 15);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Czas:";
            // 
            // sortInsert
            // 
            this.sortInsert.Location = new System.Drawing.Point(302, 351);
            this.sortInsert.Name = "sortInsert";
            this.sortInsert.Size = new System.Drawing.Size(75, 23);
            this.sortInsert.TabIndex = 8;
            this.sortInsert.Text = "SI";
            this.sortInsert.UseVisualStyleBackColor = true;
            this.sortInsert.Click += new System.EventHandler(this.sortInsert_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(383, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "SM";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(464, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "SQ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // separatorSelected
            // 
            this.separatorSelected.FormattingEnabled = true;
            this.separatorSelected.Items.AddRange(new object[] {
            ";",
            ",",
            "spacja"});
            this.separatorSelected.Location = new System.Drawing.Point(316, 46);
            this.separatorSelected.Name = "separatorSelected";
            this.separatorSelected.Size = new System.Drawing.Size(121, 23);
            this.separatorSelected.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wybierz separator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separatorSelected);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.sortInsert);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.generateNumber);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generateNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox wynik;
        private Button button2;
        private CheckBox checkBox1;
        private NumericUpDown generateNumber;
        private Button generateButton;
        private Label timeLabel;
        private Button sortInsert;
        private Button button5;
        private Button button6;
        private ComboBox separatorSelected;
        private Label label2;
    }
}