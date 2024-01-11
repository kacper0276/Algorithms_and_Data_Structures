namespace AiSD_IO2_cw5
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
            stworzwezel = new Button();
            grafPokaz = new Button();
            przeszukanieWszerz = new Button();
            addToBinaryTree = new Button();
            findMinAndMaxValue = new Button();
            findNextAndPreviousValue = new Button();
            deleteValueFromTree = new Button();
            DijsktraAlgorytm = new Button();
            algorytmKruskala = new Button();
            NWPButton = new Button();
            SuspendLayout();
            // 
            // stworzwezel
            // 
            stworzwezel.Location = new Point(89, 72);
            stworzwezel.Name = "stworzwezel";
            stworzwezel.Size = new Size(150, 46);
            stworzwezel.TabIndex = 0;
            stworzwezel.Text = "Pokaż węzeł";
            stworzwezel.UseVisualStyleBackColor = true;
            stworzwezel.Click += stworzwezel_Click;
            // 
            // grafPokaz
            // 
            grafPokaz.Location = new Point(309, 72);
            grafPokaz.Name = "grafPokaz";
            grafPokaz.Size = new Size(150, 46);
            grafPokaz.TabIndex = 1;
            grafPokaz.Text = "Pokaż graf (Szukanie wgłąb)";
            grafPokaz.UseVisualStyleBackColor = true;
            grafPokaz.Click += grafPokaz_Click;
            // 
            // przeszukanieWszerz
            // 
            przeszukanieWszerz.Location = new Point(526, 72);
            przeszukanieWszerz.Name = "przeszukanieWszerz";
            przeszukanieWszerz.Size = new Size(150, 46);
            przeszukanieWszerz.TabIndex = 2;
            przeszukanieWszerz.Text = "Pokaż graf (Szukanie wszerz)";
            przeszukanieWszerz.UseVisualStyleBackColor = true;
            przeszukanieWszerz.Click += przeszukanieWszerz_Click;
            // 
            // addToBinaryTree
            // 
            addToBinaryTree.Location = new Point(89, 196);
            addToBinaryTree.Name = "addToBinaryTree";
            addToBinaryTree.Size = new Size(150, 46);
            addToBinaryTree.TabIndex = 3;
            addToBinaryTree.Text = "Dodaj i znajdz Drzewo Binarne";
            addToBinaryTree.UseVisualStyleBackColor = true;
            addToBinaryTree.Click += addToBinaryTree_Click;
            // 
            // findMinAndMaxValue
            // 
            findMinAndMaxValue.Location = new Point(309, 196);
            findMinAndMaxValue.Name = "findMinAndMaxValue";
            findMinAndMaxValue.Size = new Size(150, 46);
            findMinAndMaxValue.TabIndex = 4;
            findMinAndMaxValue.Text = "Znajdź Min i Max w węźle";
            findMinAndMaxValue.UseVisualStyleBackColor = true;
            findMinAndMaxValue.Click += findMinAndMaxValue_Click;
            // 
            // findNextAndPreviousValue
            // 
            findNextAndPreviousValue.Location = new Point(526, 196);
            findNextAndPreviousValue.Name = "findNextAndPreviousValue";
            findNextAndPreviousValue.Size = new Size(150, 46);
            findNextAndPreviousValue.TabIndex = 5;
            findNextAndPreviousValue.Text = "Wypisz następnik i poprzednik (drzewo)";
            findNextAndPreviousValue.UseVisualStyleBackColor = true;
            findNextAndPreviousValue.Click += findNextAndPreviousValue_Click;
            // 
            // deleteValueFromTree
            // 
            deleteValueFromTree.Location = new Point(89, 294);
            deleteValueFromTree.Name = "deleteValueFromTree";
            deleteValueFromTree.Size = new Size(150, 46);
            deleteValueFromTree.TabIndex = 6;
            deleteValueFromTree.Text = "Usuń wartość z drzewa";
            deleteValueFromTree.UseVisualStyleBackColor = true;
            deleteValueFromTree.Click += deleteValueFromTree_Click;
            // 
            // DijsktraAlgorytm
            // 
            DijsktraAlgorytm.Location = new Point(309, 294);
            DijsktraAlgorytm.Name = "DijsktraAlgorytm";
            DijsktraAlgorytm.Size = new Size(150, 46);
            DijsktraAlgorytm.TabIndex = 7;
            DijsktraAlgorytm.Text = "Algorytm Dijkstry";
            DijsktraAlgorytm.UseVisualStyleBackColor = true;
            DijsktraAlgorytm.Click += DijsktraAlgorytm_Click;
            // 
            // algorytmKruskala
            // 
            algorytmKruskala.Location = new Point(526, 294);
            algorytmKruskala.Name = "algorytmKruskala";
            algorytmKruskala.Size = new Size(150, 46);
            algorytmKruskala.TabIndex = 8;
            algorytmKruskala.Text = "Algorytm Kruskala";
            algorytmKruskala.UseVisualStyleBackColor = true;
            algorytmKruskala.Click += algorytmKruskala_Click;
            // 
            // NWPButton
            // 
            NWPButton.Location = new Point(89, 392);
            NWPButton.Name = "NWPButton";
            NWPButton.Size = new Size(150, 46);
            NWPButton.TabIndex = 9;
            NWPButton.Text = "NWP";
            NWPButton.UseVisualStyleBackColor = true;
            NWPButton.Click += NWPButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NWPButton);
            Controls.Add(algorytmKruskala);
            Controls.Add(DijsktraAlgorytm);
            Controls.Add(deleteValueFromTree);
            Controls.Add(findNextAndPreviousValue);
            Controls.Add(findMinAndMaxValue);
            Controls.Add(addToBinaryTree);
            Controls.Add(przeszukanieWszerz);
            Controls.Add(grafPokaz);
            Controls.Add(stworzwezel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button stworzwezel;
        private Button grafPokaz;
        private Button przeszukanieWszerz;
        private Button addToBinaryTree;
        private Button findMinAndMaxValue;
        private Button findNextAndPreviousValue;
        private Button deleteValueFromTree;
        private Button DijsktraAlgorytm;
        private Button algorytmKruskala;
        private Button NWPButton;
    }
}