namespace GalakPizza
{
    partial class TakeOutPage
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeOutPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TakeOutButton = new GalakPizza.CustomsItems.CustomButton();
            this.EatThereButton = new GalakPizza.CustomsItems.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1113, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // TakeOutButton
            // 
            this.TakeOutButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TakeOutButton.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.TakeOutButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TakeOutButton.BorderRadius = 20;
            this.TakeOutButton.BorderSize = 0;
            this.TakeOutButton.FlatAppearance.BorderSize = 0;
            this.TakeOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TakeOutButton.ForeColor = System.Drawing.Color.White;
            this.TakeOutButton.Location = new System.Drawing.Point(1113, 800);
            this.TakeOutButton.Name = "TakeOutButton";
            this.TakeOutButton.Size = new System.Drawing.Size(500, 120);
            this.TakeOutButton.TabIndex = 2;
            this.TakeOutButton.Text = "Na wynos";
            this.TakeOutButton.TextColor = System.Drawing.Color.White;
            this.TakeOutButton.UseVisualStyleBackColor = false;
            this.TakeOutButton.Click += new System.EventHandler(this.TakeOutButton_Click);
            // 
            // EatThereButton
            // 
            this.EatThereButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.EatThereButton.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.EatThereButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.EatThereButton.BorderRadius = 20;
            this.EatThereButton.BorderSize = 0;
            this.EatThereButton.FlatAppearance.BorderSize = 0;
            this.EatThereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EatThereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EatThereButton.ForeColor = System.Drawing.Color.White;
            this.EatThereButton.Location = new System.Drawing.Point(307, 800);
            this.EatThereButton.Name = "EatThereButton";
            this.EatThereButton.Size = new System.Drawing.Size(500, 120);
            this.EatThereButton.TabIndex = 1;
            this.EatThereButton.Text = "Na miejscu";
            this.EatThereButton.TextColor = System.Drawing.Color.White;
            this.EatThereButton.UseVisualStyleBackColor = false;
            this.EatThereButton.Click += new System.EventHandler(this.EatThereButton_Click);
            // 
            // TakeOutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(150)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TakeOutButton);
            this.Controls.Add(this.EatThereButton);
            this.Name = "TakeOutPage";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomsItems.CustomButton EatThereButton;
        private CustomsItems.CustomButton TakeOutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
