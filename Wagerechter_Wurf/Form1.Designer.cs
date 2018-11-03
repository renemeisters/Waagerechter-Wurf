namespace Wagerechter_Wurf
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.field = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.xErgebniss = new System.Windows.Forms.Label();
            this.yErgebniss = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.wurf = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.Label();
            this.field.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wurf)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.ForestGreen;
            this.field.Controls.Add(this.label1);
            this.field.Controls.Add(this.wurf);
            this.field.Controls.Add(this.Ball);
            this.field.Controls.Add(this.label4);
            this.field.Controls.Add(this.xErgebniss);
            this.field.Controls.Add(this.yErgebniss);
            this.field.Controls.Add(this.label2);
            this.field.Location = new System.Drawing.Point(34, 12);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(954, 535);
            this.field.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            // 
            // xErgebniss
            // 
            this.xErgebniss.AutoSize = true;
            this.xErgebniss.Location = new System.Drawing.Point(845, 69);
            this.xErgebniss.Name = "xErgebniss";
            this.xErgebniss.Size = new System.Drawing.Size(28, 13);
            this.xErgebniss.TabIndex = 5;
            this.xErgebniss.Text = "___ ";
            // 
            // yErgebniss
            // 
            this.yErgebniss.AutoSize = true;
            this.yErgebniss.Location = new System.Drawing.Point(845, 43);
            this.yErgebniss.Name = "yErgebniss";
            this.yErgebniss.Size = new System.Drawing.Size(25, 13);
            this.yErgebniss.TabIndex = 3;
            this.yErgebniss.Text = "___";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(648, 13);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Starte Wurf";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // wurf
            // 
            this.wurf.Location = new System.Drawing.Point(808, 105);
            this.wurf.Name = "wurf";
            this.wurf.Size = new System.Drawing.Size(120, 20);
            this.wurf.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wurfgeschwindigkeit";
            // 
            // Ball
            // 
            this.Ball.AutoSize = true;
            this.Ball.BackColor = System.Drawing.Color.ForestGreen;
            this.Ball.Image = global::Wagerechter_Wurf.Properties.Resources.ball;
            this.Ball.Location = new System.Drawing.Point(0, -1);
            this.Ball.MinimumSize = new System.Drawing.Size(50, 50);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(50, 50);
            this.Ball.TabIndex = 0;
            this.Ball.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 569);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.field);
            this.Name = "Form1";
            this.Text = "Wagerechte Wurf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.field.ResumeLayout(false);
            this.field.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wurf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Ball;
        private System.Windows.Forms.Panel field;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label yErgebniss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xErgebniss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown wurf;
    }
}

