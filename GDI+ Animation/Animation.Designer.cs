namespace GDI__Animation
{
    partial class fAnimation
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
            this.tAnimation = new System.Windows.Forms.Timer(this.components);
            this.tbRadius = new System.Windows.Forms.TrackBar();
            this.lRadius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tAnimation
            // 
            this.tAnimation.Interval = 16;
            this.tAnimation.Tick += new System.EventHandler(this.tAnimation_Tick);
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(116, 12);
            this.tbRadius.Maximum = 200;
            this.tbRadius.Minimum = 10;
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(104, 45);
            this.tbRadius.TabIndex = 0;
            this.tbRadius.Value = 100;
            this.tbRadius.ValueChanged += new System.EventHandler(this.tbRadius_ValueChanged);
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadius.Location = new System.Drawing.Point(12, 12);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(63, 20);
            this.lRadius.TabIndex = 1;
            this.lRadius.Text = "Radius:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seitenlänge:";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(116, 63);
            this.tbLength.Maximum = 50;
            this.tbLength.Minimum = 10;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(104, 45);
            this.tbLength.TabIndex = 2;
            this.tbLength.Value = 10;
            this.tbLength.ValueChanged += new System.EventHandler(this.tbLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geschwindigkeit:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(362, 12);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 4;
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // fAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lRadius);
            this.Controls.Add(this.tbRadius);
            this.Name = "fAnimation";
            this.Text = "Animation";
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tAnimation;
        private System.Windows.Forms.TrackBar tbRadius;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbSpeed;
    }
}

