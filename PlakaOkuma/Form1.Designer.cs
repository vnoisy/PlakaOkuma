﻿namespace PlakaTanima
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
            this.label2 = new System.Windows.Forms.Label();
            this.aracFoto = new System.Windows.Forms.PictureBox();
            this.aracPlaka = new System.Windows.Forms.PictureBox();
            this.plakaBul = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.plakaYaz = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aracFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracPlaka)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.label2.Location = new System.Drawing.Point(670, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Plaka Resmi:";
            // 
            // aracFoto
            // 
            this.aracFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aracFoto.Location = new System.Drawing.Point(10, 12);
            this.aracFoto.Name = "aracFoto";
            this.aracFoto.Size = new System.Drawing.Size(653, 501);
            this.aracFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracFoto.TabIndex = 12;
            this.aracFoto.TabStop = false;
            // 
            // aracPlaka
            // 
            this.aracPlaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aracPlaka.Location = new System.Drawing.Point(670, 268);
            this.aracPlaka.Name = "aracPlaka";
            this.aracPlaka.Size = new System.Drawing.Size(294, 117);
            this.aracPlaka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracPlaka.TabIndex = 11;
            this.aracPlaka.TabStop = false;
            // 
            // plakaBul
            // 
            this.plakaBul.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.plakaBul.Location = new System.Drawing.Point(669, 12);
            this.plakaBul.Name = "plakaBul";
            this.plakaBul.Size = new System.Drawing.Size(291, 37);
            this.plakaBul.TabIndex = 10;
            this.plakaBul.Text = "Araç Resmi Ekle";
            this.plakaBul.UseVisualStyleBackColor = true;
            this.plakaBul.Click += new System.EventHandler(this.plakaBul_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.label1.Location = new System.Drawing.Point(670, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plaka Yazısı:";
            // 
            // plakaYaz
            // 
            this.plakaYaz.Font = new System.Drawing.Font("Lucida Sans Typewriter", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plakaYaz.Location = new System.Drawing.Point(669, 129);
            this.plakaYaz.Name = "plakaYaz";
            this.plakaYaz.ReadOnly = true;
            this.plakaYaz.ShowSelectionMargin = true;
            this.plakaYaz.Size = new System.Drawing.Size(295, 94);
            this.plakaYaz.TabIndex = 22;
            this.plakaYaz.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 522);
            this.Controls.Add(this.plakaYaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aracFoto);
            this.Controls.Add(this.aracPlaka);
            this.Controls.Add(this.plakaBul);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Araç Plaka Tespit";
            ((System.ComponentModel.ISupportInitialize)(this.aracFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracPlaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox aracFoto;
        private System.Windows.Forms.PictureBox aracPlaka;
        private System.Windows.Forms.Button plakaBul;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox plakaYaz;
    }
}

