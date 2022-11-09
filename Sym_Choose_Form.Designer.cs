namespace Decoder_pro
{
    partial class Sym_Choose_Form
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
            this.Vigenere_button = new System.Windows.Forms.Button();
            this.XOR_button = new System.Windows.Forms.Button();
            this.DES_button = new System.Windows.Forms.Button();
            this.RC5_button = new System.Windows.Forms.Button();
            this.BlowFish_button = new System.Windows.Forms.Button();
            this.AES_button = new System.Windows.Forms.Button();
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
            this.cifer_name.Location = new System.Drawing.Point(254, 9);
            this.cifer_name.Name = "cifer_name";
            this.cifer_name.Size = new System.Drawing.Size(807, 91);
            this.cifer_name.TabIndex = 15;
            this.cifer_name.Text = "Симметричные шифры";
            // 
            // Vigenere_button
            // 
            this.Vigenere_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Vigenere_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vigenere_button.Location = new System.Drawing.Point(121, 227);
            this.Vigenere_button.Name = "Vigenere_button";
            this.Vigenere_button.Size = new System.Drawing.Size(152, 87);
            this.Vigenere_button.TabIndex = 16;
            this.Vigenere_button.Text = "виженер";
            this.Vigenere_button.UseVisualStyleBackColor = false;
            this.Vigenere_button.Click += new System.EventHandler(this.Vigenere_button_Click);
            // 
            // XOR_button
            // 
            this.XOR_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.XOR_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.XOR_button.Location = new System.Drawing.Point(523, 227);
            this.XOR_button.Name = "XOR_button";
            this.XOR_button.Size = new System.Drawing.Size(152, 87);
            this.XOR_button.TabIndex = 17;
            this.XOR_button.Text = "XOR";
            this.XOR_button.UseVisualStyleBackColor = false;
            this.XOR_button.Click += new System.EventHandler(this.XOR_button_Click);
            // 
            // DES_button
            // 
            this.DES_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DES_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DES_button.Location = new System.Drawing.Point(909, 227);
            this.DES_button.Name = "DES_button";
            this.DES_button.Size = new System.Drawing.Size(152, 87);
            this.DES_button.TabIndex = 18;
            this.DES_button.Text = "DES";
            this.DES_button.UseVisualStyleBackColor = false;
            this.DES_button.Click += new System.EventHandler(this.DES_button_Click);
            // 
            // RC5_button
            // 
            this.RC5_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RC5_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RC5_button.Location = new System.Drawing.Point(121, 378);
            this.RC5_button.Name = "RC5_button";
            this.RC5_button.Size = new System.Drawing.Size(152, 87);
            this.RC5_button.TabIndex = 19;
            this.RC5_button.Text = "RC5";
            this.RC5_button.UseVisualStyleBackColor = false;
            this.RC5_button.Click += new System.EventHandler(this.RC5_button_Click);
            // 
            // BlowFish_button
            // 
            this.BlowFish_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BlowFish_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BlowFish_button.Location = new System.Drawing.Point(523, 378);
            this.BlowFish_button.Name = "BlowFish_button";
            this.BlowFish_button.Size = new System.Drawing.Size(152, 87);
            this.BlowFish_button.TabIndex = 20;
            this.BlowFish_button.Text = "BlowFish";
            this.BlowFish_button.UseVisualStyleBackColor = false;
            this.BlowFish_button.Click += new System.EventHandler(this.BlowFish_button_Click);
            // 
            // AES_button
            // 
            this.AES_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AES_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AES_button.Location = new System.Drawing.Point(909, 391);
            this.AES_button.Name = "AES_button";
            this.AES_button.Size = new System.Drawing.Size(152, 87);
            this.AES_button.TabIndex = 21;
            this.AES_button.Text = "AES";
            this.AES_button.UseVisualStyleBackColor = false;
            this.AES_button.Click += new System.EventHandler(this.AES_button_Click);
            // 
            // Sym_Choose_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AES_button);
            this.Controls.Add(this.BlowFish_button);
            this.Controls.Add(this.RC5_button);
            this.Controls.Add(this.DES_button);
            this.Controls.Add(this.XOR_button);
            this.Controls.Add(this.Vigenere_button);
            this.Controls.Add(this.cifer_name);
            this.Controls.Add(this.DecoderPro_label);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Sym_Choose_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DecoderPro_label;
        private Label cifer_name;
        private Button Vigenere_button;
        private Button XOR_button;
        private Button DES_button;
        private Button RC5_button;
        private Button BlowFish_button;
        private Button AES_button;
    }
}