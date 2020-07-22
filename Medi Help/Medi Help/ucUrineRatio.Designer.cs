namespace Medi_Help
{
    partial class ucUrineRatio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Urine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Urine
            // 
            this.Urine.Location = new System.Drawing.Point(291, 326);
            this.Urine.Name = "Urine";
            this.Urine.Size = new System.Drawing.Size(316, 65);
            this.Urine.TabIndex = 1;
            this.Urine.Text = "Urine Test";
            this.Urine.UseVisualStyleBackColor = true;
            // 
            // ucUrineRatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Urine);
            this.Name = "ucUrineRatio";
            this.Size = new System.Drawing.Size(915, 735);
            this.Load += new System.EventHandler(this.ucUrineRatio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Urine;
    }
}
