namespace QoF_UI
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
            this.nudLeveys = new System.Windows.Forms.NumericUpDown();
            this.nudKorkeus = new System.Windows.Forms.NumericUpDown();
            this.bLuoKenttä = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bTalletaPelikenttä = new System.Windows.Forms.Button();
            this.bLuePelikenttä = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeveys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKorkeus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelikentän leveys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pelikentän korkeus";
            // 
            // nudLeveys
            // 
            this.nudLeveys.Location = new System.Drawing.Point(132, 4);
            this.nudLeveys.Margin = new System.Windows.Forms.Padding(4);
            this.nudLeveys.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudLeveys.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLeveys.Name = "nudLeveys";
            this.nudLeveys.Size = new System.Drawing.Size(67, 23);
            this.nudLeveys.TabIndex = 2;
            this.nudLeveys.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudKorkeus
            // 
            this.nudKorkeus.Location = new System.Drawing.Point(132, 31);
            this.nudKorkeus.Margin = new System.Windows.Forms.Padding(4);
            this.nudKorkeus.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudKorkeus.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKorkeus.Name = "nudKorkeus";
            this.nudKorkeus.Size = new System.Drawing.Size(67, 23);
            this.nudKorkeus.TabIndex = 2;
            this.nudKorkeus.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bLuoKenttä
            // 
            this.bLuoKenttä.Location = new System.Drawing.Point(219, 8);
            this.bLuoKenttä.Name = "bLuoKenttä";
            this.bLuoKenttä.Size = new System.Drawing.Size(105, 46);
            this.bLuoKenttä.TabIndex = 3;
            this.bLuoKenttä.Text = "Tee uusi  kenttä";
            this.bLuoKenttä.UseVisualStyleBackColor = true;
            this.bLuoKenttä.Click += new System.EventHandler(this.bLuoKenttä_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seuraava sukupolvi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bSeuraavaSukupolvi_Click);
            // 
            // bTalletaPelikenttä
            // 
            this.bTalletaPelikenttä.Location = new System.Drawing.Point(444, 8);
            this.bTalletaPelikenttä.Name = "bTalletaPelikenttä";
            this.bTalletaPelikenttä.Size = new System.Drawing.Size(73, 46);
            this.bTalletaPelikenttä.TabIndex = 3;
            this.bTalletaPelikenttä.Text = "Tallenna";
            this.bTalletaPelikenttä.UseVisualStyleBackColor = true;
            this.bTalletaPelikenttä.Click += new System.EventHandler(this.bTalletaKenttä_Click);
            // 
            // bLuePelikenttä
            // 
            this.bLuePelikenttä.Location = new System.Drawing.Point(523, 8);
            this.bLuePelikenttä.Name = "bLuePelikenttä";
            this.bLuePelikenttä.Size = new System.Drawing.Size(108, 46);
            this.bLuePelikenttä.TabIndex = 3;
            this.bLuePelikenttä.Text = "Lue kenttä tiedostosta";
            this.bLuePelikenttä.UseVisualStyleBackColor = true;
            this.bLuePelikenttä.Click += new System.EventHandler(this.bLuePelikenttä_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoard.Location = new System.Drawing.Point(19, 70);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(600, 600);
            this.pnlBoard.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 681);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.bLuePelikenttä);
            this.Controls.Add(this.bTalletaPelikenttä);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bLuoKenttä);
            this.Controls.Add(this.nudKorkeus);
            this.Controls.Add(this.nudLeveys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Of Life ";
            ((System.ComponentModel.ISupportInitialize)(this.nudLeveys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKorkeus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLeveys;
        private System.Windows.Forms.NumericUpDown nudKorkeus;
        private System.Windows.Forms.Button bLuoKenttä;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bTalletaPelikenttä;
        private System.Windows.Forms.Button bLuePelikenttä;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

