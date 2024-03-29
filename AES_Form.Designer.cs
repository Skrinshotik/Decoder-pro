﻿namespace Decoder_pro
{
    partial class AES_Form
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
            this.key_label = new System.Windows.Forms.Label();
            this.message_label = new System.Windows.Forms.Label();
            this.encrypted_label = new System.Windows.Forms.Label();
            this.key_text = new System.Windows.Forms.TextBox();
            this.message_text = new System.Windows.Forms.TextBox();
            this.encrypted_text = new System.Windows.Forms.RichTextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.cifer_name = new System.Windows.Forms.Label();
            this.error_text = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
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
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_label.Location = new System.Drawing.Point(20, 219);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(106, 45);
            this.key_label.TabIndex = 7;
            this.key_label.Text = "Ключ";
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message_label.Location = new System.Drawing.Point(20, 311);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(208, 45);
            this.message_label.TabIndex = 8;
            this.message_label.Text = "Сообщение";
            // 
            // encrypted_label
            // 
            this.encrypted_label.AutoSize = true;
            this.encrypted_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encrypted_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrypted_label.Location = new System.Drawing.Point(20, 396);
            this.encrypted_label.Name = "encrypted_label";
            this.encrypted_label.Size = new System.Drawing.Size(313, 45);
            this.encrypted_label.TabIndex = 9;
            this.encrypted_label.Text = "Шифр-сообщение";
            // 
            // key_text
            // 
            this.key_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.key_text.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_text.Location = new System.Drawing.Point(234, 219);
            this.key_text.Name = "key_text";
            this.key_text.Size = new System.Drawing.Size(317, 50);
            this.key_text.TabIndex = 10;
            this.key_text.TextChanged += new System.EventHandler(this.key_text_TextChanged);
            this.key_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_text_KeyPress);
            // 
            // message_text
            // 
            this.message_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.message_text.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message_text.Location = new System.Drawing.Point(234, 311);
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(317, 50);
            this.message_text.TabIndex = 11;
            this.message_text.TextChanged += new System.EventHandler(this.message_text_TextChanged);
            // 
            // encrypted_text
            // 
            this.encrypted_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.encrypted_text.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encrypted_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrypted_text.Location = new System.Drawing.Point(29, 456);
            this.encrypted_text.Name = "encrypted_text";
            this.encrypted_text.Size = new System.Drawing.Size(522, 195);
            this.encrypted_text.TabIndex = 12;
            this.encrypted_text.Text = "";
            // 
            // decrypt_button
            // 
            this.decrypt_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.decrypt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decrypt_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decrypt_button.Location = new System.Drawing.Point(591, 456);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(433, 78);
            this.decrypt_button.TabIndex = 13;
            this.decrypt_button.Text = "Расшифровать!";
            this.decrypt_button.UseVisualStyleBackColor = false;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.encrypt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encrypt_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrypt_button.Location = new System.Drawing.Point(591, 573);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(433, 78);
            this.encrypt_button.TabIndex = 14;
            this.encrypt_button.Text = "Зашифровать!";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // cifer_name
            // 
            this.cifer_name.AutoSize = true;
            this.cifer_name.Font = new System.Drawing.Font("Calibri", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cifer_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cifer_name.Location = new System.Drawing.Point(339, 9);
            this.cifer_name.Name = "cifer_name";
            this.cifer_name.Size = new System.Drawing.Size(155, 91);
            this.cifer_name.TabIndex = 15;
            this.cifer_name.Text = "AES";
            this.cifer_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.error_text.Location = new System.Drawing.Point(234, 193);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(72, 19);
            this.error_text.TabIndex = 18;
            this.error_text.Text = "*ошибка";
            this.error_text.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(591, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(433, 321);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 104);
            this.label1.TabIndex = 20;
            this.label1.Text = "1. Для работы с шифром нужно вписать ключ, размер которого 16 букв на русском - а" +
    "нглийском языках в поле \"Ключ\", не используя цифры и спецсимволы.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 104);
            this.label2.TabIndex = 21;
            this.label2.Text = "2. Для шифрования может использоваться сообщение как на русском, так и на английс" +
    "ком языках, введённое в поле \"Сообщение\".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 104);
            this.label3.TabIndex = 22;
            this.label3.Text = "3. Зашифрованное и расшифрованное сообщение выводится в поле \"Шифр-сообщение\", по" +
    "сле нажатия на кнопку с соответствующим названием.";
            // 
            // AES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1054, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.cifer_name);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypted_text);
            this.Controls.Add(this.message_text);
            this.Controls.Add(this.key_text);
            this.Controls.Add(this.encrypted_label);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.DecoderPro_label);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1070, 720);
            this.Name = "AES_Form";
            this.Text = "AES";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DecoderPro_label;
        private Label key_label;
        private Label message_label;
        private Label encrypted_label;
        private TextBox key_text;
        private TextBox message_text;
        private RichTextBox encrypted_text;
        private Button decrypt_button;
        private Button encrypt_button;
        private Label cifer_name;
        private Label error_text;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}