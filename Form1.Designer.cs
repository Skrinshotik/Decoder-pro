namespace Decoder_pro
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
            this.encode_button = new System.Windows.Forms.Button();
            this.code_selector = new System.Windows.Forms.ComboBox();
            this.public_key_1_text = new System.Windows.Forms.TextBox();
            this.public_key_2_text = new System.Windows.Forms.TextBox();
            this.private_key_text = new System.Windows.Forms.TextBox();
            this.decode_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(46, 228);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(97, 47);
            this.encode_button.TabIndex = 0;
            this.encode_button.Text = "Encode";
            this.encode_button.UseVisualStyleBackColor = true;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // code_selector
            // 
            this.code_selector.FormattingEnabled = true;
            this.code_selector.Location = new System.Drawing.Point(69, 71);
            this.code_selector.Name = "code_selector";
            this.code_selector.Size = new System.Drawing.Size(121, 23);
            this.code_selector.TabIndex = 1;
            this.code_selector.SelectedIndexChanged += new System.EventHandler(this.code_selector_SelectedIndexChanged);
            // 
            // public_key_1_text
            // 
            this.public_key_1_text.Location = new System.Drawing.Point(46, 122);
            this.public_key_1_text.Name = "public_key_1_text";
            this.public_key_1_text.Size = new System.Drawing.Size(100, 23);
            this.public_key_1_text.TabIndex = 2;
            // 
            // public_key_2_text
            // 
            this.public_key_2_text.Location = new System.Drawing.Point(46, 151);
            this.public_key_2_text.Name = "public_key_2_text";
            this.public_key_2_text.Size = new System.Drawing.Size(100, 23);
            this.public_key_2_text.TabIndex = 3;
            // 
            // private_key_text
            // 
            this.private_key_text.Location = new System.Drawing.Point(46, 181);
            this.private_key_text.Name = "private_key_text";
            this.private_key_text.Size = new System.Drawing.Size(100, 23);
            this.private_key_text.TabIndex = 4;
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(165, 228);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(97, 47);
            this.decode_button.TabIndex = 5;
            this.decode_button.Text = "Decode";
            this.decode_button.UseVisualStyleBackColor = true;
            this.decode_button.Click += new System.EventHandler(this.decode_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decode_button);
            this.Controls.Add(this.private_key_text);
            this.Controls.Add(this.public_key_2_text);
            this.Controls.Add(this.public_key_1_text);
            this.Controls.Add(this.code_selector);
            this.Controls.Add(this.encode_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button encode_button;
        private ComboBox code_selector;
        private TextBox public_key_1_text;
        private TextBox public_key_2_text;
        private TextBox private_key_text;
        private Button decode_button;
    }
}