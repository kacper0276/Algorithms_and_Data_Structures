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
            textBox1 = new TextBox();
            button1 = new Button();
            wynik = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            generateNumber = new NumericUpDown();
            generateButton = new Button();
            timeLabel = new Label();
            sortInsert = new Button();
            button5 = new Button();
            quickSortButton = new Button();
            separatorSelected = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)generateNumber).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(221, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "SB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // wynik
            // 
            wynik.Location = new Point(165, 274);
            wynik.Name = "wynik";
            wynik.Size = new Size(100, 23);
            wynik.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(140, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "SS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(316, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lewa strona aktywna";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // generateNumber
            // 
            generateNumber.Location = new Point(458, 143);
            generateNumber.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            generateNumber.Name = "generateNumber";
            generateNumber.Size = new Size(120, 23);
            generateNumber.TabIndex = 5;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(458, 193);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(120, 23);
            generateButton.TabIndex = 6;
            generateButton.Text = "Generuj";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(382, 277);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(34, 15);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Czas:";
            // 
            // sortInsert
            // 
            sortInsert.Location = new Point(302, 351);
            sortInsert.Name = "sortInsert";
            sortInsert.Size = new Size(75, 23);
            sortInsert.TabIndex = 8;
            sortInsert.Text = "SI";
            sortInsert.UseVisualStyleBackColor = true;
            sortInsert.Click += sortInsert_Click;
            // 
            // button5
            // 
            button5.Location = new Point(383, 351);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "SM";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // quickSortButton
            // 
            quickSortButton.Location = new Point(464, 351);
            quickSortButton.Name = "quickSortButton";
            quickSortButton.Size = new Size(75, 23);
            quickSortButton.TabIndex = 10;
            quickSortButton.Text = "SQ";
            quickSortButton.UseVisualStyleBackColor = true;
            quickSortButton.Click += quickSortButton_Click;
            // 
            // separatorSelected
            // 
            separatorSelected.FormattingEnabled = true;
            separatorSelected.Items.AddRange(new object[] { ";", ",", "spacja" });
            separatorSelected.Location = new Point(316, 46);
            separatorSelected.Name = "separatorSelected";
            separatorSelected.Size = new Size(121, 23);
            separatorSelected.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 28);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 12;
            label2.Text = "Wybierz separator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(separatorSelected);
            Controls.Add(quickSortButton);
            Controls.Add(button5);
            Controls.Add(sortInsert);
            Controls.Add(timeLabel);
            Controls.Add(generateButton);
            Controls.Add(generateNumber);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(wynik);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)generateNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button quickSortButton;
        private ComboBox separatorSelected;
        private Label label2;
    }
}