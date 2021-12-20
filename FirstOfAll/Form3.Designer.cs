
namespace FirstOfAll
{
    partial class Mutfak
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
            this.mutfakdeneme = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.eklekasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mutfakdeneme
            // 
            this.mutfakdeneme.Location = new System.Drawing.Point(67, 63);
            this.mutfakdeneme.Name = "mutfakdeneme";
            this.mutfakdeneme.Size = new System.Drawing.Size(408, 156);
            this.mutfakdeneme.TabIndex = 0;
            this.mutfakdeneme.Text = "mutfakdeneme";
            this.mutfakdeneme.UseVisualStyleBackColor = true;
            this.mutfakdeneme.Click += new System.EventHandler(this.mutfakdeneme_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(587, 73);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 106);
            this.checkedListBox1.TabIndex = 1;
            // 
            // eklekasa
            // 
            this.eklekasa.Location = new System.Drawing.Point(587, 185);
            this.eklekasa.Name = "eklekasa";
            this.eklekasa.Size = new System.Drawing.Size(174, 52);
            this.eklekasa.TabIndex = 2;
            this.eklekasa.Text = "kasaya ekle";
            this.eklekasa.UseVisualStyleBackColor = true;
            this.eklekasa.Click += new System.EventHandler(this.eklekasa_Click);
            // 
            // Mutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eklekasa);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.mutfakdeneme);
            this.Name = "Mutfak";
            this.Text = "MUTFAK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mutfakdeneme;
        private System.Windows.Forms.Button eklekasa;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}