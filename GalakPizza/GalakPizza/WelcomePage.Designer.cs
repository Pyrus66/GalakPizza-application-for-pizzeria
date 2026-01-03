namespace GalakPizza
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.Start = new GalakPizza.CustomsItems.CustomButton();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Start.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.Start.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.Start.BorderRadius = 20;
            this.Start.BorderSize = 0;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(735, 720);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(450, 150);
            this.Start.TabIndex = 0;
            this.Start.Text = "Rozpocznij";
            this.Start.TextColor = System.Drawing.Color.White;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.customButton1_Click);
            this.Start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonWelcomePageStart_KeyDown);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomsItems.CustomButton Start;
    }
}
