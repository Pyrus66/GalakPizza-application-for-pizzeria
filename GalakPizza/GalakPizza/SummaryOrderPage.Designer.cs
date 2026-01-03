namespace GalakPizza
{
    partial class SummaryOrderPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancelOrder = new GalakPizza.CustomsItems.CustomButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.ButtonPay = new GalakPizza.CustomsItems.CustomButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddd = new GalakPizza.CustomsItems.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.buttonAddd);
            this.panel1.Controls.Add(this.ButtonCancelOrder);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.ButtonPay);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 200);
            this.panel1.TabIndex = 0;
            // 
            // ButtonCancelOrder
            // 
            this.ButtonCancelOrder.BackColor = System.Drawing.Color.Crimson;
            this.ButtonCancelOrder.BackgroundColor = System.Drawing.Color.Crimson;
            this.ButtonCancelOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCancelOrder.BorderRadius = 20;
            this.ButtonCancelOrder.BorderSize = 0;
            this.ButtonCancelOrder.FlatAppearance.BorderSize = 0;
            this.ButtonCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancelOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonCancelOrder.Location = new System.Drawing.Point(1110, 33);
            this.ButtonCancelOrder.Name = "ButtonCancelOrder";
            this.ButtonCancelOrder.Size = new System.Drawing.Size(250, 150);
            this.ButtonCancelOrder.TabIndex = 2;
            this.ButtonCancelOrder.Text = "Anuluj zamówienie";
            this.ButtonCancelOrder.TextColor = System.Drawing.Color.White;
            this.ButtonCancelOrder.UseVisualStyleBackColor = false;
            this.ButtonCancelOrder.Click += new System.EventHandler(this.ButtonCancelOrder_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(48, 64);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(152, 55);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "label1";
            // 
            // ButtonPay
            // 
            this.ButtonPay.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPay.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonPay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPay.BorderRadius = 20;
            this.ButtonPay.BorderSize = 0;
            this.ButtonPay.FlatAppearance.BorderSize = 0;
            this.ButtonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPay.ForeColor = System.Drawing.Color.White;
            this.ButtonPay.Location = new System.Drawing.Point(1650, 33);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(250, 150);
            this.ButtonPay.TabIndex = 0;
            this.ButtonPay.Text = "Zapłać";
            this.ButtonPay.TextColor = System.Drawing.Color.White;
            this.ButtonPay.UseVisualStyleBackColor = false;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(150)))));
            this.panelContent.Location = new System.Drawing.Point(0, 256);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1920, 824);
            this.panelContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zamówienie:";
            // 
            // buttonAddd
            // 
            this.buttonAddd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddd.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAddd.BorderRadius = 20;
            this.buttonAddd.BorderSize = 0;
            this.buttonAddd.FlatAppearance.BorderSize = 0;
            this.buttonAddd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddd.ForeColor = System.Drawing.Color.White;
            this.buttonAddd.Location = new System.Drawing.Point(1380, 33);
            this.buttonAddd.Name = "buttonAddd";
            this.buttonAddd.Size = new System.Drawing.Size(250, 150);
            this.buttonAddd.TabIndex = 3;
            this.buttonAddd.Text = "Dodaj pizze";
            this.buttonAddd.TextColor = System.Drawing.Color.White;
            this.buttonAddd.UseVisualStyleBackColor = false;
            this.buttonAddd.Click += new System.EventHandler(this.ButtonAdd);
            // 
            // SummaryOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "SummaryOrderPage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.SummaryOrderPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomsItems.CustomButton ButtonPay;
        private System.Windows.Forms.Panel panelContent;
        protected System.Windows.Forms.Label labelPrice;
        protected System.Windows.Forms.Label label1;
        private CustomsItems.CustomButton ButtonCancelOrder;
        private CustomsItems.CustomButton buttonAddd;
    }
}
