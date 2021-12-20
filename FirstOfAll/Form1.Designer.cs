
namespace FirstOfAll
{
	partial class Menu
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
            this.firin = new System.Windows.Forms.Button();
            this.kasa = new System.Windows.Forms.Button();
            this.mutfak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firin
            // 
            this.firin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.firin.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firin.ForeColor = System.Drawing.Color.Black;
            this.firin.Location = new System.Drawing.Point(179, 11);
            this.firin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firin.Name = "firin";
            this.firin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firin.Size = new System.Drawing.Size(480, 90);
            this.firin.TabIndex = 0;
            this.firin.Text = "FIRIN";
            this.firin.UseVisualStyleBackColor = false;
            this.firin.Click += new System.EventHandler(this.firin_Click);
            // 
            // kasa
            // 
            this.kasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kasa.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasa.ForeColor = System.Drawing.Color.Black;
            this.kasa.Location = new System.Drawing.Point(16, 108);
            this.kasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kasa.Name = "kasa";
            this.kasa.Size = new System.Drawing.Size(480, 87);
            this.kasa.TabIndex = 1;
            this.kasa.Text = "KASA";
            this.kasa.UseVisualStyleBackColor = false;
            this.kasa.Click += new System.EventHandler(this.kasa_Click);
            // 
            // mutfak
            // 
            this.mutfak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mutfak.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutfak.ForeColor = System.Drawing.Color.Black;
            this.mutfak.Location = new System.Drawing.Point(179, 203);
            this.mutfak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutfak.Name = "mutfak";
            this.mutfak.Size = new System.Drawing.Size(480, 84);
            this.mutfak.TabIndex = 2;
            this.mutfak.Text = "MUTFAK";
            this.mutfak.UseVisualStyleBackColor = false;
            this.mutfak.Click += new System.EventHandler(this.mutfak_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstOfAll.Properties.Resources.istockphoto_1129081313_170667a;
            this.ClientSize = new System.Drawing.Size(675, 551);
            this.Controls.Add(this.mutfak);
            this.Controls.Add(this.kasa);
            this.Controls.Add(this.firin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menüler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button firin;
		private System.Windows.Forms.Button kasa;
		private System.Windows.Forms.Button mutfak;
    }
}

