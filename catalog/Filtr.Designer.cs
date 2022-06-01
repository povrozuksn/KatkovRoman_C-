namespace catalog
{
    partial class Filtr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filtr));
            this.button9 = new System.Windows.Forms.Button();
            this.compbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button9.Location = new System.Drawing.Point(29, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(234, 69);
            this.button9.TabIndex = 32;
            this.button9.Text = "Фильтр";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // compbox
            // 
            this.compbox.AutoCompleteCustomSource.AddRange(new string[] {
            "самсунг",
            "айфон"});
            this.compbox.FormattingEnabled = true;
            this.compbox.Items.AddRange(new object[] {
            "Samsung",
            "Iphone"});
            this.compbox.Location = new System.Drawing.Point(115, 20);
            this.compbox.Name = "compbox";
            this.compbox.Size = new System.Drawing.Size(166, 21);
            this.compbox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Компания";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(115, 62);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(165, 20);
            this.pricetxt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Цена до";
            // 
            // pan
            // 
            this.pan.AutoScroll = true;
            this.pan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pan.Location = new System.Drawing.Point(17, 167);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(870, 405);
            this.pan.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(703, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 66);
            this.button3.TabIndex = 39;
            this.button3.Text = "Корзина";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.likedClick);
            // 
            // Filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(888, 577);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compbox);
            this.Name = "Filtr";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox compbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Button button3;
    }
}