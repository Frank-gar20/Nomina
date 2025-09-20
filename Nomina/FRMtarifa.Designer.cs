namespace Nomina
{
    partial class FRMtarifa
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
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regular Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Over Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double Time:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(162, 40);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 3;
            // 
            // txtOT
            // 
            this.txtOT.Location = new System.Drawing.Point(162, 87);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(100, 20);
            this.txtOT.TabIndex = 4;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(162, 135);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 20);
            this.txtDT.TabIndex = 5;
            // 
            // BTNguardar
            // 
            this.BTNguardar.Location = new System.Drawing.Point(333, 64);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(75, 23);
            this.BTNguardar.TabIndex = 6;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = true;
            this.BTNguardar.Click += new System.EventHandler(this.BTNguardar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Location = new System.Drawing.Point(333, 114);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNcancelar.TabIndex = 7;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // FRMtarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 213);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNguardar);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtOT);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMtarifa";
            this.Text = "Tarifas de pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtOT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Button BTNguardar;
        private System.Windows.Forms.Button BTNcancelar;
    }
}