namespace Practica_1
{
    partial class Form3
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(69, 36);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb1.Size = new System.Drawing.Size(633, 197);
            this.tb1.TabIndex = 1;
            this.tb1.TextChanged += new System.EventHandler(this.Tb1_TextChanged);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(343, 317);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(106, 44);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "mostrar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button bt1;
    }
}