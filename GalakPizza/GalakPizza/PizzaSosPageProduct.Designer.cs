namespace GalakPizza
{
    partial class PizzaSosPageProduct
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonLess = new GalakPizza.CustomsItems.CustomButton();
            this.ButtonMore = new GalakPizza.CustomsItems.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(8, 200);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(320, 56);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(104, 320);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(144, 56);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "label1";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCount.Location = new System.Drawing.Point(104, 256);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(144, 56);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "label1";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(70, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ButtonLess
            // 
            this.ButtonLess.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonLess.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonLess.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonLess.BorderRadius = 20;
            this.ButtonLess.BorderSize = 0;
            this.ButtonLess.FlatAppearance.BorderSize = 0;
            this.ButtonLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLess.ForeColor = System.Drawing.Color.White;
            this.ButtonLess.Location = new System.Drawing.Point(40, 256);
            this.ButtonLess.Name = "ButtonLess";
            this.ButtonLess.Size = new System.Drawing.Size(56, 56);
            this.ButtonLess.TabIndex = 1;
            this.ButtonLess.Text = "-";
            this.ButtonLess.TextColor = System.Drawing.Color.White;
            this.ButtonLess.UseVisualStyleBackColor = false;
            this.ButtonLess.Click += new System.EventHandler(this.ButtonLess_Click);
            // 
            // ButtonMore
            // 
            this.ButtonMore.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonMore.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonMore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonMore.BorderRadius = 20;
            this.ButtonMore.BorderSize = 0;
            this.ButtonMore.FlatAppearance.BorderSize = 0;
            this.ButtonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMore.ForeColor = System.Drawing.Color.White;
            this.ButtonMore.Location = new System.Drawing.Point(248, 256);
            this.ButtonMore.Name = "ButtonMore";
            this.ButtonMore.Size = new System.Drawing.Size(56, 56);
            this.ButtonMore.TabIndex = 2;
            this.ButtonMore.Text = "+";
            this.ButtonMore.TextColor = System.Drawing.Color.White;
            this.ButtonMore.UseVisualStyleBackColor = false;
            this.ButtonMore.Click += new System.EventHandler(this.ButtonMore_Click);
            // 
            // PizzaSosPageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ButtonLess);
            this.Controls.Add(this.ButtonMore);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Name = "PizzaSosPageProduct";
            this.Size = new System.Drawing.Size(340, 380);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCount;
        private CustomsItems.CustomButton ButtonMore;
        private CustomsItems.CustomButton ButtonLess;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
