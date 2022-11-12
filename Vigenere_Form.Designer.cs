namespace Decoder_pro
{
    partial class Vigenere_Form
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
            this.cifer_name = new System.Windows.Forms.Label();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.encrypted_text = new System.Windows.Forms.RichTextBox();
            this.message_text = new System.Windows.Forms.TextBox();
            this.key_text = new System.Windows.Forms.TextBox();
            this.encrypted_label = new System.Windows.Forms.Label();
            this.message_label = new System.Windows.Forms.Label();
            this.key_label = new System.Windows.Forms.Label();
            this.DecoderPro_label = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cifer_name
            // 
            this.cifer_name.AutoSize = true;
            this.cifer_name.Font = new System.Drawing.Font("Calibri", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cifer_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cifer_name.Location = new System.Drawing.Point(339, 9);
            this.cifer_name.Name = "cifer_name";
            this.cifer_name.Size = new System.Drawing.Size(588, 91);
            this.cifer_name.TabIndex = 25;
            this.cifer_name.Text = "Шифр Виженера";
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.encrypt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encrypt_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrypt_button.Location = new System.Drawing.Point(591, 573);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(179, 78);
            this.encrypt_button.TabIndex = 24;
            this.encrypt_button.Text = "Зашифровать!";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.decrypt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decrypt_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decrypt_button.Location = new System.Drawing.Point(591, 456);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(179, 78);
            this.decrypt_button.TabIndex = 23;
            this.decrypt_button.Text = "Расшифровать!";
            this.decrypt_button.UseVisualStyleBackColor = false;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // encrypted_text
            // 
            this.encrypted_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.encrypted_text.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encrypted_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrypted_text.Location = new System.Drawing.Point(29, 456);
            this.encrypted_text.Name = "encrypted_text";
            this.encrypted_text.Size = new System.Drawing.Size(522, 195);
            this.encrypted_text.TabIndex = 22;
            this.encrypted_text.Text = "";
            // 
            // message_text
            // 
            this.message_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.message_text.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message_text.Location = new System.Drawing.Point(234, 311);
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(317, 50);
            this.message_text.TabIndex = 21;
            // 
            // key_text
            // 
            this.key_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.key_text.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_text.Location = new System.Drawing.Point(234, 219);
            this.key_text.Name = "key_text";
            this.key_text.Size = new System.Drawing.Size(317, 50);
            this.key_text.TabIndex = 20;
            // 
            // encrypted_label
            // 
            this.encrypted_label.AutoSize = true;
            this.encrypted_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encrypted_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrypted_label.Location = new System.Drawing.Point(20, 396);
            this.encrypted_label.Name = "encrypted_label";
            this.encrypted_label.Size = new System.Drawing.Size(313, 45);
            this.encrypted_label.TabIndex = 19;
            this.encrypted_label.Text = "Шифр-сообщение";
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message_label.Location = new System.Drawing.Point(20, 311);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(208, 45);
            this.message_label.TabIndex = 18;
            this.message_label.Text = "Сообщение";
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_label.Location = new System.Drawing.Point(20, 219);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(106, 45);
            this.key_label.TabIndex = 17;
            this.key_label.Text = "Ключ";
            // 
            // DecoderPro_label
            // 
            this.DecoderPro_label.AutoSize = true;
            this.DecoderPro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecoderPro_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DecoderPro_label.Location = new System.Drawing.Point(12, 4);
            this.DecoderPro_label.Name = "DecoderPro_label";
            this.DecoderPro_label.Size = new System.Drawing.Size(218, 42);
            this.DecoderPro_label.TabIndex = 16;
            this.DecoderPro_label.Text = "DecoderPro";
            this.DecoderPro_label.Click += new System.EventHandler(this.DecoderPro_label_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(591, 417);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 19);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Латиница";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(683, 417);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 19);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Кириллица";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Vigenere_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
            this.Name = "Vigenere_Form";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cifer_name;
        private Button encrypt_button;
        private Button decrypt_button;
        private RichTextBox encrypted_text;
        private TextBox message_text;
        private TextBox key_text;
        private Label encrypted_label;
        private Label message_label;
        private Label key_label;
        private Label DecoderPro_label;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}