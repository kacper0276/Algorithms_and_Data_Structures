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
            this.stworzwezel = new System.Windows.Forms.Button();
            this.grafPokaz = new System.Windows.Forms.Button();
            this.przeszukanieWszerz = new System.Windows.Forms.Button();
            this.addToBinaryTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stworzwezel
            // 
            this.stworzwezel.Location = new System.Drawing.Point(89, 72);
            this.stworzwezel.Name = "stworzwezel";
            this.stworzwezel.Size = new System.Drawing.Size(150, 46);
            this.stworzwezel.TabIndex = 0;
            this.stworzwezel.Text = "Pokaż węzeł";
            this.stworzwezel.UseVisualStyleBackColor = true;
            this.stworzwezel.Click += new System.EventHandler(this.stworzwezel_Click);
            // 
            // grafPokaz
            // 
            this.grafPokaz.Location = new System.Drawing.Point(309, 72);
            this.grafPokaz.Name = "grafPokaz";
            this.grafPokaz.Size = new System.Drawing.Size(150, 46);
            this.grafPokaz.TabIndex = 1;
            this.grafPokaz.Text = "Pokaż graf (Szukanie wgłąb)";
            this.grafPokaz.UseVisualStyleBackColor = true;
            this.grafPokaz.Click += new System.EventHandler(this.grafPokaz_Click);
            // 
            // przeszukanieWszerz
            // 
            this.przeszukanieWszerz.Location = new System.Drawing.Point(526, 72);
            this.przeszukanieWszerz.Name = "przeszukanieWszerz";
            this.przeszukanieWszerz.Size = new System.Drawing.Size(150, 46);
            this.przeszukanieWszerz.TabIndex = 2;
            this.przeszukanieWszerz.Text = "Pokaż graf (Szukanie wszerz)";
            this.przeszukanieWszerz.UseVisualStyleBackColor = true;
            this.przeszukanieWszerz.Click += new System.EventHandler(this.przeszukanieWszerz_Click);
            // 
            // addToBinaryTree
            // 
            this.addToBinaryTree.Location = new System.Drawing.Point(89, 196);
            this.addToBinaryTree.Name = "addToBinaryTree";
            this.addToBinaryTree.Size = new System.Drawing.Size(150, 46);
            this.addToBinaryTree.TabIndex = 3;
            this.addToBinaryTree.Text = "Dodaj do drzewa binarnego";
            this.addToBinaryTree.UseVisualStyleBackColor = true;
            this.addToBinaryTree.Click += new System.EventHandler(this.addToBinaryTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addToBinaryTree);
            this.Controls.Add(this.przeszukanieWszerz);
            this.Controls.Add(this.grafPokaz);
            this.Controls.Add(this.stworzwezel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button stworzwezel;
        private Button grafPokaz;
        private Button przeszukanieWszerz;
        private Button addToBinaryTree;
    }
}