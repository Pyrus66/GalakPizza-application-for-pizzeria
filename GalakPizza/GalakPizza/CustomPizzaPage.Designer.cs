namespace GalakPizza
{
    partial class CustomPizzaPage
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
            this.NavPanel = new System.Windows.Forms.Panel();
            this.ButtonCancel = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonSummary = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonPizzaSos = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonPizzaNoMeat = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonPizzaMeat = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonPizzaCheese = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonPizzaBase = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonPizzaDough = new GalakPizza.CustomsItems.CustomButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(150)))));
            this.NavPanel.Controls.Add(this.ButtonCancel);
            this.NavPanel.Controls.Add(this.ButtonSummary);
            this.NavPanel.Controls.Add(this.ButtonPizzaSos);
            this.NavPanel.Controls.Add(this.ButtonPizzaNoMeat);
            this.NavPanel.Controls.Add(this.ButtonPizzaMeat);
            this.NavPanel.Controls.Add(this.ButtonPizzaCheese);
            this.NavPanel.Controls.Add(this.ButtonPizzaBase);
            this.NavPanel.Controls.Add(this.ButtonPizzaDough);
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(1920, 200);
            this.NavPanel.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Crimson;
            this.ButtonCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.ButtonCancel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonCancel.BorderRadius = 20;
            this.ButtonCancel.BorderSize = 0;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(12, 12);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(175, 175);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.TextColor = System.Drawing.Color.White;
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSummary
            // 
            this.ButtonSummary.BackColor = System.Drawing.Color.Gray;
            this.ButtonSummary.BackgroundColor = System.Drawing.Color.Gray;
            this.ButtonSummary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonSummary.BorderRadius = 20;
            this.ButtonSummary.BorderSize = 0;
            this.ButtonSummary.Enabled = false;
            this.ButtonSummary.FlatAppearance.BorderSize = 0;
            this.ButtonSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSummary.ForeColor = System.Drawing.Color.White;
            this.ButtonSummary.Location = new System.Drawing.Point(1632, 12);
            this.ButtonSummary.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSummary.Name = "ButtonSummary";
            this.ButtonSummary.Size = new System.Drawing.Size(275, 175);
            this.ButtonSummary.TabIndex = 6;
            this.ButtonSummary.Text = "Podsumowanie";
            this.ButtonSummary.TextColor = System.Drawing.Color.White;
            this.ButtonSummary.UseVisualStyleBackColor = false;
            this.ButtonSummary.Click += new System.EventHandler(this.ButtonSummary_Click);
            // 
            // ButtonPizzaSos
            // 
            this.ButtonPizzaSos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaSos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaSos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPizzaSos.BorderRadius = 15;
            this.ButtonPizzaSos.BorderSize = 0;
            this.ButtonPizzaSos.FlatAppearance.BorderSize = 0;
            this.ButtonPizzaSos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPizzaSos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPizzaSos.ForeColor = System.Drawing.Color.White;
            this.ButtonPizzaSos.Location = new System.Drawing.Point(1375, 24);
            this.ButtonPizzaSos.Name = "ButtonPizzaSos";
            this.ButtonPizzaSos.Size = new System.Drawing.Size(225, 150);
            this.ButtonPizzaSos.TabIndex = 5;
            this.ButtonPizzaSos.Text = "Dodatkowy sos";
            this.ButtonPizzaSos.TextColor = System.Drawing.Color.White;
            this.ButtonPizzaSos.UseVisualStyleBackColor = false;
            this.ButtonPizzaSos.Click += new System.EventHandler(this.ButtonPizzaSos_Click);
            // 
            // ButtonPizzaNoMeat
            // 
            this.ButtonPizzaNoMeat.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaNoMeat.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaNoMeat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPizzaNoMeat.BorderRadius = 15;
            this.ButtonPizzaNoMeat.BorderSize = 0;
            this.ButtonPizzaNoMeat.FlatAppearance.BorderSize = 0;
            this.ButtonPizzaNoMeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPizzaNoMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPizzaNoMeat.ForeColor = System.Drawing.Color.White;
            this.ButtonPizzaNoMeat.Location = new System.Drawing.Point(1144, 24);
            this.ButtonPizzaNoMeat.Name = "ButtonPizzaNoMeat";
            this.ButtonPizzaNoMeat.Size = new System.Drawing.Size(225, 150);
            this.ButtonPizzaNoMeat.TabIndex = 4;
            this.ButtonPizzaNoMeat.Text = "Dodatki vege";
            this.ButtonPizzaNoMeat.TextColor = System.Drawing.Color.White;
            this.ButtonPizzaNoMeat.UseVisualStyleBackColor = false;
            this.ButtonPizzaNoMeat.Click += new System.EventHandler(this.ButtonPizzaNoMeat_Click);
            // 
            // ButtonPizzaMeat
            // 
            this.ButtonPizzaMeat.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaMeat.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaMeat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPizzaMeat.BorderRadius = 15;
            this.ButtonPizzaMeat.BorderSize = 0;
            this.ButtonPizzaMeat.FlatAppearance.BorderSize = 0;
            this.ButtonPizzaMeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPizzaMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPizzaMeat.ForeColor = System.Drawing.Color.White;
            this.ButtonPizzaMeat.Location = new System.Drawing.Point(913, 24);
            this.ButtonPizzaMeat.Name = "ButtonPizzaMeat";
            this.ButtonPizzaMeat.Size = new System.Drawing.Size(225, 150);
            this.ButtonPizzaMeat.TabIndex = 3;
            this.ButtonPizzaMeat.Text = "Dodatki mięsne";
            this.ButtonPizzaMeat.TextColor = System.Drawing.Color.White;
            this.ButtonPizzaMeat.UseVisualStyleBackColor = false;
            this.ButtonPizzaMeat.Click += new System.EventHandler(this.ButtonPizzaMeat_Click);
            // 
            // ButtonPizzaCheese
            // 
            this.ButtonPizzaCheese.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaCheese.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaCheese.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPizzaCheese.BorderRadius = 15;
            this.ButtonPizzaCheese.BorderSize = 0;
            this.ButtonPizzaCheese.FlatAppearance.BorderSize = 0;
            this.ButtonPizzaCheese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPizzaCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPizzaCheese.ForeColor = System.Drawing.Color.White;
            this.ButtonPizzaCheese.Location = new System.Drawing.Point(682, 24);
            this.ButtonPizzaCheese.Name = "ButtonPizzaCheese";
            this.ButtonPizzaCheese.Size = new System.Drawing.Size(225, 150);
            this.ButtonPizzaCheese.TabIndex = 2;
            this.ButtonPizzaCheese.Text = "Ser";
            this.ButtonPizzaCheese.TextColor = System.Drawing.Color.White;
            this.ButtonPizzaCheese.UseVisualStyleBackColor = false;
            this.ButtonPizzaCheese.Click += new System.EventHandler(this.ButtonPizzaCheese_Click);
            // 
            // ButtonPizzaBase
            // 
            this.ButtonPizzaBase.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaBase.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaBase.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPizzaBase.BorderRadius = 15;
            this.ButtonPizzaBase.BorderSize = 0;
            this.ButtonPizzaBase.FlatAppearance.BorderSize = 0;
            this.ButtonPizzaBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPizzaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPizzaBase.ForeColor = System.Drawing.Color.White;
            this.ButtonPizzaBase.Location = new System.Drawing.Point(451, 24);
            this.ButtonPizzaBase.Name = "ButtonPizzaBase";
            this.ButtonPizzaBase.Size = new System.Drawing.Size(225, 150);
            this.ButtonPizzaBase.TabIndex = 1;
            this.ButtonPizzaBase.Text = "Sos ";
            this.ButtonPizzaBase.TextColor = System.Drawing.Color.White;
            this.ButtonPizzaBase.UseVisualStyleBackColor = false;
            this.ButtonPizzaBase.Click += new System.EventHandler(this.ButtonPizzaBase_Click);
            // 
            // ButtonPizzaDough
            // 
            this.ButtonPizzaDough.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaDough.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPizzaDough.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPizzaDough.BorderRadius = 15;
            this.ButtonPizzaDough.BorderSize = 0;
            this.ButtonPizzaDough.FlatAppearance.BorderSize = 0;
            this.ButtonPizzaDough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPizzaDough.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPizzaDough.ForeColor = System.Drawing.Color.White;
            this.ButtonPizzaDough.Location = new System.Drawing.Point(220, 24);
            this.ButtonPizzaDough.Name = "ButtonPizzaDough";
            this.ButtonPizzaDough.Size = new System.Drawing.Size(225, 150);
            this.ButtonPizzaDough.TabIndex = 0;
            this.ButtonPizzaDough.Text = "Ciasto";
            this.ButtonPizzaDough.TextColor = System.Drawing.Color.White;
            this.ButtonPizzaDough.UseVisualStyleBackColor = false;
            this.ButtonPizzaDough.Click += new System.EventHandler(this.ButtonPizzaDough_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(150)))));
            this.ContentPanel.Location = new System.Drawing.Point(0, 200);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1920, 880);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ContentPanel_ControlAdded);
            // 
            // CustomPizzaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "CustomPizzaPage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private CustomsItems.CustomButton ButtonSummary;
        private CustomsItems.CustomButton ButtonPizzaSos;
        private CustomsItems.CustomButton ButtonPizzaNoMeat;
        private CustomsItems.CustomButton ButtonPizzaMeat;
        private CustomsItems.CustomButton ButtonPizzaCheese;
        private CustomsItems.CustomButton ButtonPizzaBase;
        private System.Windows.Forms.Panel ContentPanel;
        private CustomsItems.CustomButton ButtonPizzaDough;
        private CustomsItems.CustomButton ButtonCancel;
    }
}
