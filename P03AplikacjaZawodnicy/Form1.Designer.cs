﻿namespace P02AplikacjaZawodnicy
{
    partial class Form1
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
            this.lblDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDaraUr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKrajZawodnika = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnGenerujPDF = new System.Windows.Forms.Button();
            this.wbPrzegladrka = new System.Windows.Forms.WebBrowser();
            this.btnOtworzFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDane
            // 
            this.lblDane.FormattingEnabled = true;
            this.lblDane.Location = new System.Drawing.Point(12, 109);
            this.lblDane.Name = "lblDane";
            this.lblDane.Size = new System.Drawing.Size(329, 238);
            this.lblDane.TabIndex = 0;
            this.lblDane.SelectedIndexChanged += new System.EventHandler(this.lblDane_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(89, 84);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(107, 29);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(234, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(107, 76);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(234, 20);
            this.txtKraj.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kraj";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtWaga);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWzrost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDaraUr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKrajZawodnika);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNazwisko);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtImie);
            this.groupBox1.Location = new System.Drawing.Point(361, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Waga";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(6, 252);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(193, 20);
            this.txtWaga.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Wzrost";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(6, 212);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(193, 20);
            this.txtWzrost.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data urodzenia";
            // 
            // txtDaraUr
            // 
            this.txtDaraUr.Location = new System.Drawing.Point(6, 168);
            this.txtDaraUr.Name = "txtDaraUr";
            this.txtDaraUr.Size = new System.Drawing.Size(193, 20);
            this.txtDaraUr.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kraj";
            // 
            // txtKrajZawodnika
            // 
            this.txtKrajZawodnika.Location = new System.Drawing.Point(6, 126);
            this.txtKrajZawodnika.Name = "txtKrajZawodnika";
            this.txtKrajZawodnika.Size = new System.Drawing.Size(193, 20);
            this.txtKrajZawodnika.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(6, 85);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(193, 20);
            this.txtNazwisko.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(6, 44);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(193, 20);
            this.txtImie.TabIndex = 0;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(485, 324);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnGenerujPDF
            // 
            this.btnGenerujPDF.Location = new System.Drawing.Point(367, 324);
            this.btnGenerujPDF.Name = "btnGenerujPDF";
            this.btnGenerujPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGenerujPDF.TabIndex = 13;
            this.btnGenerujPDF.Text = "PDF";
            this.btnGenerujPDF.UseVisualStyleBackColor = true;
            this.btnGenerujPDF.Click += new System.EventHandler(this.btnGenerujPDF_Click);
            // 
            // wbPrzegladrka
            // 
            this.wbPrzegladrka.Location = new System.Drawing.Point(581, 76);
            this.wbPrzegladrka.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPrzegladrka.Name = "wbPrzegladrka";
            this.wbPrzegladrka.Size = new System.Drawing.Size(250, 250);
            this.wbPrzegladrka.TabIndex = 14;
            // 
            // btnOtworzFolder
            // 
            this.btnOtworzFolder.Location = new System.Drawing.Point(581, 43);
            this.btnOtworzFolder.Name = "btnOtworzFolder";
            this.btnOtworzFolder.Size = new System.Drawing.Size(250, 23);
            this.btnOtworzFolder.TabIndex = 15;
            this.btnOtworzFolder.Text = "Otwórz folder";
            this.btnOtworzFolder.UseVisualStyleBackColor = true;
            this.btnOtworzFolder.Click += new System.EventHandler(this.btnOtworzFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 369);
            this.Controls.Add(this.btnOtworzFolder);
            this.Controls.Add(this.wbPrzegladrka);
            this.Controls.Add(this.btnGenerujPDF);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lblDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDaraUr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKrajZawodnika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnGenerujPDF;
        private System.Windows.Forms.WebBrowser wbPrzegladrka;
        private System.Windows.Forms.Button btnOtworzFolder;
    }
}

