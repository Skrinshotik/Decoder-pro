﻿namespace Decoder_pro
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
            this.DecoderPro_label = new System.Windows.Forms.Label();
            this.cifer_name = new System.Windows.Forms.Label();
            this.sym_button = new System.Windows.Forms.Button();
            this.gallery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DecoderPro_label
            // 
            this.DecoderPro_label.AutoSize = true;
            this.DecoderPro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecoderPro_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DecoderPro_label.Location = new System.Drawing.Point(12, 4);
            this.DecoderPro_label.Name = "DecoderPro_label";
            this.DecoderPro_label.Size = new System.Drawing.Size(218, 42);
            this.DecoderPro_label.TabIndex = 6;
            this.DecoderPro_label.Text = "DecoderPro";
            this.DecoderPro_label.Click += new System.EventHandler(this.DecoderPro_label_Click);
            // 
            // cifer_name
            // 
            this.cifer_name.AutoSize = true;
            this.cifer_name.Font = new System.Drawing.Font("Calibri", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cifer_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cifer_name.Location = new System.Drawing.Point(339, 9);
            this.cifer_name.Name = "cifer_name";
            this.cifer_name.Size = new System.Drawing.Size(595, 91);
            this.cifer_name.TabIndex = 15;
            this.cifer_name.Text = "Тип шифрования";
            // 
            // sym_button
            // 
            this.sym_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sym_button.Font = new System.Drawing.Font("Segoe UI Semibold", 23.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sym_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sym_button.Location = new System.Drawing.Point(285, 271);
            this.sym_button.Name = "sym_button";
            this.sym_button.Size = new System.Drawing.Size(317, 129);
            this.sym_button.TabIndex = 16;
            this.sym_button.Text = "Шифры";
            this.sym_button.UseVisualStyleBackColor = false;
            this.sym_button.Click += new System.EventHandler(this.sym_button_Click);
            // 
            // gallery
            // 
            this.gallery.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gallery.Font = new System.Drawing.Font("Segoe UI Semibold", 23.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gallery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gallery.Location = new System.Drawing.Point(690, 271);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(317, 129);
            this.gallery.TabIndex = 18;
            this.gallery.Text = "Галерея отчисленных";
            this.gallery.UseVisualStyleBackColor = false;
            this.gallery.Click += new System.EventHandler(this.gallery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gallery);
            this.Controls.Add(this.sym_button);
            this.Controls.Add(this.cifer_name);
            this.Controls.Add(this.DecoderPro_label);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DecoderPro_label;
        private Label cifer_name;
        private Button sym_button;
        private Button gallery;
    }
}