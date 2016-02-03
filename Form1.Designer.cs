namespace Arduino2
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
            this.yak = new System.Windows.Forms.Button();
            this.sondur = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // yak
            // 
            this.yak.Location = new System.Drawing.Point(145, 53);
            this.yak.Name = "yak";
            this.yak.Size = new System.Drawing.Size(75, 23);
            this.yak.TabIndex = 0;
            this.yak.Text = "Led Yak";
            this.yak.UseVisualStyleBackColor = true;
            this.yak.Click += new System.EventHandler(this.yak_Click);
            // 
            // sondur
            // 
            this.sondur.Location = new System.Drawing.Point(145, 112);
            this.sondur.Name = "sondur";
            this.sondur.Size = new System.Drawing.Size(75, 23);
            this.sondur.TabIndex = 1;
            this.sondur.Text = "Led Söndür";
            this.sondur.UseVisualStyleBackColor = true;
            this.sondur.Click += new System.EventHandler(this.sondur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 261);
            this.Controls.Add(this.sondur);
            this.Controls.Add(this.yak);
            this.Name = "Form1";
            this.Text = "Arduino ile C# Haberleşme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yak;
        private System.Windows.Forms.Button sondur;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

