
namespace Biblioteka3
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.txtImeAutora = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.dtDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.txtBrojStranica = new System.Windows.Forms.TextBox();
            this.dgKnjige = new System.Windows.Forms.DataGridView();
            this.btnUnesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime Autora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN Knjige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum Izdavanja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj Stranica";
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(156, 18);
            this.txtNazivKnjige.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(132, 22);
            this.txtNazivKnjige.TabIndex = 5;
            // 
            // txtImeAutora
            // 
            this.txtImeAutora.Location = new System.Drawing.Point(156, 50);
            this.txtImeAutora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImeAutora.Name = "txtImeAutora";
            this.txtImeAutora.Size = new System.Drawing.Size(132, 22);
            this.txtImeAutora.TabIndex = 6;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(156, 82);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(132, 22);
            this.txtIsbn.TabIndex = 7;
            // 
            // dtDatumIzdavanja
            // 
            this.dtDatumIzdavanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatumIzdavanja.Location = new System.Drawing.Point(156, 117);
            this.dtDatumIzdavanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDatumIzdavanja.Name = "dtDatumIzdavanja";
            this.dtDatumIzdavanja.Size = new System.Drawing.Size(132, 22);
            this.dtDatumIzdavanja.TabIndex = 8;
            // 
            // txtBrojStranica
            // 
            this.txtBrojStranica.Location = new System.Drawing.Point(156, 154);
            this.txtBrojStranica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrojStranica.Name = "txtBrojStranica";
            this.txtBrojStranica.Size = new System.Drawing.Size(132, 22);
            this.txtBrojStranica.TabIndex = 9;
            // 
            // dgKnjige
            // 
            this.dgKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKnjige.Location = new System.Drawing.Point(29, 210);
            this.dgKnjige.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgKnjige.Name = "dgKnjige";
            this.dgKnjige.RowHeadersWidth = 51;
            this.dgKnjige.Size = new System.Drawing.Size(727, 268);
            this.dgKnjige.TabIndex = 10;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(353, 151);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(100, 28);
            this.btnUnesi.TabIndex = 11;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.dgKnjige);
            this.Controls.Add(this.txtBrojStranica);
            this.Controls.Add(this.dtDatumIzdavanja);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtImeAutora);
            this.Controls.Add(this.txtNazivKnjige);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.TextBox txtImeAutora;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.DateTimePicker dtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtBrojStranica;
        private System.Windows.Forms.DataGridView dgKnjige;
        private System.Windows.Forms.Button btnUnesi;
    }
}

