namespace QoF_UI
{
    partial class FrmTiedostoNimi
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
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bPeruuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tietostonimi";
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(12, 16);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(482, 20);
            this.txtNimi.TabIndex = 1;
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(158, 46);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // bPeruuta
            // 
            this.bPeruuta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bPeruuta.Location = new System.Drawing.Point(247, 46);
            this.bPeruuta.Name = "bPeruuta";
            this.bPeruuta.Size = new System.Drawing.Size(75, 23);
            this.bPeruuta.TabIndex = 3;
            this.bPeruuta.Text = "Peruuta";
            this.bPeruuta.UseVisualStyleBackColor = true;
            // 
            // FrmTiedostoNimi
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bPeruuta;
            this.ClientSize = new System.Drawing.Size(510, 80);
            this.Controls.Add(this.bPeruuta);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.label1);
            this.Name = "FrmTiedostoNimi";
            this.Text = "TiedostoNimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bPeruuta;
    }
}