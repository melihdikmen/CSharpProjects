namespace EmlakArayüz
{
    partial class DüzenlemeEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.kiraorfiyat_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depozito_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirası:";
            // 
            // kiraorfiyat_textbox
            // 
            this.kiraorfiyat_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiraorfiyat_textbox.Location = new System.Drawing.Point(236, 57);
            this.kiraorfiyat_textbox.MaxLength = 1000000;
            this.kiraorfiyat_textbox.Name = "kiraorfiyat_textbox";
            this.kiraorfiyat_textbox.Size = new System.Drawing.Size(108, 26);
            this.kiraorfiyat_textbox.TabIndex = 1;
            this.kiraorfiyat_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kiraorfiyat_textbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depozito:";
            // 
            // depozito_textbox
            // 
            this.depozito_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depozito_textbox.Location = new System.Drawing.Point(236, 109);
            this.depozito_textbox.Multiline = true;
            this.depozito_textbox.Name = "depozito_textbox";
            this.depozito_textbox.Size = new System.Drawing.Size(108, 28);
            this.depozito_textbox.TabIndex = 1;
          
            this.depozito_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kiraorfiyat_textbox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(346, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DüzenlemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depozito_textbox);
            this.Controls.Add(this.kiraorfiyat_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DüzenlemeEkranı";
            this.Text = "DüzenlemeEkranı";
            this.Load += new System.EventHandler(this.DüzenlemeEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kiraorfiyat_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depozito_textbox;
        private System.Windows.Forms.Button button1;
    }
}