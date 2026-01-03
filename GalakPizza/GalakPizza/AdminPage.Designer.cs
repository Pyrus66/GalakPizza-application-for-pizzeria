namespace GalakPizza
{
    partial class AdminPage
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
            this.panel = new System.Windows.Forms.Panel();
            this.customButton2 = new GalakPizza.CustomsItems.CustomButton();
            this.customButton1 = new GalakPizza.CustomsItems.CustomButton();
            this.buttonModifyProduct = new GalakPizza.CustomsItems.CustomButton();
            this.buttonAddProduct = new GalakPizza.CustomsItems.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel.Controls.Add(this.customButton2);
            this.panel.Controls.Add(this.customButton1);
            this.panel.Controls.Add(this.buttonModifyProduct);
            this.panel.Controls.Add(this.buttonAddProduct);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(450, 1080);
            this.panel.TabIndex = 3;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderRadius = 0;
            this.customButton2.BorderSize = 2;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(0, 450);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(450, 150);
            this.customButton2.TabIndex = 3;
            this.customButton2.Text = "Wyjdź";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(0, 300);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(450, 150);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Usuń produkt";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.buttonDelProduct_Click);
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonModifyProduct.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonModifyProduct.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonModifyProduct.BorderRadius = 0;
            this.buttonModifyProduct.BorderSize = 2;
            this.buttonModifyProduct.FlatAppearance.BorderSize = 0;
            this.buttonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModifyProduct.ForeColor = System.Drawing.Color.White;
            this.buttonModifyProduct.Location = new System.Drawing.Point(0, 150);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(450, 150);
            this.buttonModifyProduct.TabIndex = 1;
            this.buttonModifyProduct.Text = "Edytuj produkt";
            this.buttonModifyProduct.TextColor = System.Drawing.Color.White;
            this.buttonModifyProduct.UseVisualStyleBackColor = false;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddProduct.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddProduct.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAddProduct.BorderRadius = 0;
            this.buttonAddProduct.BorderSize = 2;
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduct.Location = new System.Drawing.Point(0, 0);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(450, 150);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Dodaj produkt";
            this.buttonAddProduct.TextColor = System.Drawing.Color.White;
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(101, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1297, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj w panelu administratora";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Location = new System.Drawing.Point(450, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1470, 1080);
            this.panelContent.TabIndex = 4;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelContent);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private CustomsItems.CustomButton buttonAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private CustomsItems.CustomButton buttonModifyProduct;
        private CustomsItems.CustomButton customButton2;
        private CustomsItems.CustomButton customButton1;
    }
}
