namespace AulaS7
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tank = new System.Windows.Forms.PictureBox();
            this.numVE = new System.Windows.Forms.NumericUpDown();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numVS = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tank2 = new System.Windows.Forms.PictureBox();
            this.txtMN2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tank3 = new System.Windows.Forms.PictureBox();
            this.txtMN3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tank
            // 
            this.tank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tank.Location = new System.Drawing.Point(196, 12);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(200, 300);
            this.tank.TabIndex = 3;
            this.tank.TabStop = false;
            // 
            // numVE
            // 
            this.numVE.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVE.Location = new System.Drawing.Point(62, 159);
            this.numVE.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVE.Name = "numVE";
            this.numVE.Size = new System.Drawing.Size(100, 20);
            this.numVE.TabIndex = 4;
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(257, 318);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(100, 20);
            this.txtMN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "VE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "VS:";
            // 
            // numVS
            // 
            this.numVS.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVS.Location = new System.Drawing.Point(62, 185);
            this.numVS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVS.Name = "numVS";
            this.numVS.Size = new System.Drawing.Size(100, 20);
            this.numVS.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tank2
            // 
            this.tank2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tank2.Location = new System.Drawing.Point(413, 13);
            this.tank2.Name = "tank2";
            this.tank2.Size = new System.Drawing.Size(200, 300);
            this.tank2.TabIndex = 7;
            this.tank2.TabStop = false;
            // 
            // txtMN2
            // 
            this.txtMN2.Location = new System.Drawing.Point(474, 319);
            this.txtMN2.Name = "txtMN2";
            this.txtMN2.Size = new System.Drawing.Size(100, 20);
            this.txtMN2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MN:";
            // 
            // tank3
            // 
            this.tank3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tank3.Location = new System.Drawing.Point(632, 13);
            this.tank3.Name = "tank3";
            this.tank3.Size = new System.Drawing.Size(200, 300);
            this.tank3.TabIndex = 10;
            this.tank3.TabStop = false;
            // 
            // txtMN3
            // 
            this.txtMN3.Location = new System.Drawing.Point(693, 319);
            this.txtMN3.Name = "txtMN3";
            this.txtMN3.Size = new System.Drawing.Size(100, 20);
            this.txtMN3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "MN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 353);
            this.Controls.Add(this.tank3);
            this.Controls.Add(this.txtMN3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tank2);
            this.Controls.Add(this.txtMN2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numVS);
            this.Controls.Add(this.numVE);
            this.Controls.Add(this.tank);
            this.Controls.Add(this.txtMN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox tank;
        private System.Windows.Forms.NumericUpDown numVE;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numVS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox tank2;
        private System.Windows.Forms.TextBox txtMN2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox tank3;
        private System.Windows.Forms.TextBox txtMN3;
        private System.Windows.Forms.Label label7;
    }
}

