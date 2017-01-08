namespace Beadando
{
    partial class Modositas
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
            this._lblSzulnev = new System.Windows.Forms.Label();
            this._lblNev = new System.Windows.Forms.Label();
            this._tboxCim = new System.Windows.Forms.TextBox();
            this._tboxNev = new System.Windows.Forms.TextBox();
            this._btnVissza = new System.Windows.Forms.Button();
            this._btnMentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblSzulnev
            // 
            this._lblSzulnev.AutoSize = true;
            this._lblSzulnev.Location = new System.Drawing.Point(19, 45);
            this._lblSzulnev.Name = "_lblSzulnev";
            this._lblSzulnev.Size = new System.Drawing.Size(27, 13);
            this._lblSzulnev.TabIndex = 17;
            this._lblSzulnev.Text = "Cim:";
            // 
            // _lblNev
            // 
            this._lblNev.AutoSize = true;
            this._lblNev.Location = new System.Drawing.Point(19, 19);
            this._lblNev.Name = "_lblNev";
            this._lblNev.Size = new System.Drawing.Size(30, 13);
            this._lblNev.TabIndex = 16;
            this._lblNev.Text = "Név:";
            // 
            // _tboxCim
            // 
            this._tboxCim.Location = new System.Drawing.Point(119, 38);
            this._tboxCim.Name = "_tboxCim";
            this._tboxCim.Size = new System.Drawing.Size(492, 20);
            this._tboxCim.TabIndex = 13;
            // 
            // _tboxNev
            // 
            this._tboxNev.Location = new System.Drawing.Point(119, 12);
            this._tboxNev.Name = "_tboxNev";
            this._tboxNev.Size = new System.Drawing.Size(492, 20);
            this._tboxNev.TabIndex = 12;
            // 
            // _btnVissza
            // 
            this._btnVissza.Location = new System.Drawing.Point(525, 101);
            this._btnVissza.Name = "_btnVissza";
            this._btnVissza.Size = new System.Drawing.Size(75, 23);
            this._btnVissza.TabIndex = 19;
            this._btnVissza.Text = "Vissza";
            this._btnVissza.UseVisualStyleBackColor = true;
            this._btnVissza.Click += new System.EventHandler(this._btnVissza_Click);
            // 
            // _btnMentes
            // 
            this._btnMentes.Location = new System.Drawing.Point(22, 101);
            this._btnMentes.Name = "_btnMentes";
            this._btnMentes.Size = new System.Drawing.Size(75, 23);
            this._btnMentes.TabIndex = 18;
            this._btnMentes.Text = "Mentés";
            this._btnMentes.UseVisualStyleBackColor = true;
            this._btnMentes.Click += new System.EventHandler(this._btnMentes_Click);
            // 
            // Modositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 224);
            this.Controls.Add(this._btnVissza);
            this.Controls.Add(this._btnMentes);
            this.Controls.Add(this._lblSzulnev);
            this.Controls.Add(this._lblNev);
            this.Controls.Add(this._tboxCim);
            this.Controls.Add(this._tboxNev);
            this.Name = "Modositas";
            this.Text = "Modositas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblSzulnev;
        private System.Windows.Forms.Label _lblNev;
        private System.Windows.Forms.TextBox _tboxCim;
        private System.Windows.Forms.TextBox _tboxNev;
        private System.Windows.Forms.Button _btnVissza;
        private System.Windows.Forms.Button _btnMentes;
    }
}