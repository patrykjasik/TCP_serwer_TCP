namespace TCP_serwer_TCP
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
            this.adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniach = new System.Windows.Forms.ListBox();
            this.przycisk_start = new System.Windows.Forms.Button();
            this.przycisk_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(13, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(278, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "Adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(342, 12);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(351, 20);
            this.my_port.TabIndex = 1;
            // 
            // info_o_polaczeniach
            // 
            this.info_o_polaczeniach.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_o_polaczeniach.FormattingEnabled = true;
            this.info_o_polaczeniach.ItemHeight = 29;
            this.info_o_polaczeniach.Location = new System.Drawing.Point(13, 40);
            this.info_o_polaczeniach.Name = "info_o_polaczeniach";
            this.info_o_polaczeniach.Size = new System.Drawing.Size(680, 265);
            this.info_o_polaczeniach.TabIndex = 2;
            // 
            // przycisk_start
            // 
            this.przycisk_start.Location = new System.Drawing.Point(77, 334);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(182, 52);
            this.przycisk_start.TabIndex = 3;
            this.przycisk_start.Text = "Start";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // przycisk_stop
            // 
            this.przycisk_stop.Location = new System.Drawing.Point(365, 334);
            this.przycisk_stop.Name = "przycisk_stop";
            this.przycisk_stop.Size = new System.Drawing.Size(184, 52);
            this.przycisk_stop.TabIndex = 4;
            this.przycisk_stop.Text = "Stop";
            this.przycisk_stop.UseVisualStyleBackColor = true;
            this.przycisk_stop.Click += new System.EventHandler(this.przycisk_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 407);
            this.Controls.Add(this.przycisk_stop);
            this.Controls.Add(this.przycisk_start);
            this.Controls.Add(this.info_o_polaczeniach);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.ListBox info_o_polaczeniach;
        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button przycisk_stop;
    }
}

