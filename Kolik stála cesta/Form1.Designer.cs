
namespace Kolik_stála_cesta
{
    partial class formKolikStalaCesta
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKolikStalaCesta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.poleCena = new System.Windows.Forms.TextBox();
            this.poleSpotreba = new System.Windows.Forms.TextBox();
            this.poleVzdalenost = new System.Windows.Forms.TextBox();
            this.poleVysledek = new System.Windows.Forms.TextBox();
            this.tlacitkoVypocti = new System.Windows.Forms.Button();
            this.tlacitkoOProgramu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Cena paliva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Spotřeba paliva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(40, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Ujetá vzdálenost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(282, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kč/l";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(282, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "l/100 km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(282, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(25, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cena za ujetou vzdálenost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(337, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kč";
            // 
            // poleCena
            // 
            this.poleCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleCena.Location = new System.Drawing.Point(176, 20);
            this.poleCena.Name = "poleCena";
            this.poleCena.Size = new System.Drawing.Size(100, 26);
            this.poleCena.TabIndex = 1;
            this.poleCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleSpotreba
            // 
            this.poleSpotreba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleSpotreba.Location = new System.Drawing.Point(176, 55);
            this.poleSpotreba.Name = "poleSpotreba";
            this.poleSpotreba.Size = new System.Drawing.Size(100, 26);
            this.poleSpotreba.TabIndex = 4;
            this.poleSpotreba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleVzdalenost
            // 
            this.poleVzdalenost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleVzdalenost.Location = new System.Drawing.Point(176, 90);
            this.poleVzdalenost.Name = "poleVzdalenost";
            this.poleVzdalenost.Size = new System.Drawing.Size(100, 26);
            this.poleVzdalenost.TabIndex = 7;
            this.poleVzdalenost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleVysledek
            // 
            this.poleVysledek.Enabled = false;
            this.poleVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleVysledek.Location = new System.Drawing.Point(231, 188);
            this.poleVysledek.Name = "poleVysledek";
            this.poleVysledek.Size = new System.Drawing.Size(100, 26);
            this.poleVysledek.TabIndex = 11;
            this.poleVysledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlacitkoVypocti
            // 
            this.tlacitkoVypocti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlacitkoVypocti.Location = new System.Drawing.Point(29, 135);
            this.tlacitkoVypocti.Name = "tlacitkoVypocti";
            this.tlacitkoVypocti.Size = new System.Drawing.Size(335, 29);
            this.tlacitkoVypocti.TabIndex = 9;
            this.tlacitkoVypocti.Text = "&Vypočti";
            this.tlacitkoVypocti.UseVisualStyleBackColor = true;
            this.tlacitkoVypocti.Click += new System.EventHandler(this.tlacitkoVypocti_Click);
            // 
            // tlacitkoOProgramu
            // 
            this.tlacitkoOProgramu.Location = new System.Drawing.Point(261, 236);
            this.tlacitkoOProgramu.Name = "tlacitkoOProgramu";
            this.tlacitkoOProgramu.Size = new System.Drawing.Size(119, 23);
            this.tlacitkoOProgramu.TabIndex = 13;
            this.tlacitkoOProgramu.Text = "&O programu";
            this.tlacitkoOProgramu.UseVisualStyleBackColor = true;
            this.tlacitkoOProgramu.Click += new System.EventHandler(this.tlacitkoOProgramu_Click);
            // 
            // formKolikStalaCesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 272);
            this.Controls.Add(this.tlacitkoOProgramu);
            this.Controls.Add(this.tlacitkoVypocti);
            this.Controls.Add(this.poleVysledek);
            this.Controls.Add(this.poleVzdalenost);
            this.Controls.Add(this.poleSpotreba);
            this.Controls.Add(this.poleCena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formKolikStalaCesta";
            this.Text = "Kolik stála cesta?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox poleCena;
        private System.Windows.Forms.TextBox poleSpotreba;
        private System.Windows.Forms.TextBox poleVzdalenost;
        private System.Windows.Forms.TextBox poleVysledek;
        private System.Windows.Forms.Button tlacitkoVypocti;
        private System.Windows.Forms.Button tlacitkoOProgramu;
    }
}

