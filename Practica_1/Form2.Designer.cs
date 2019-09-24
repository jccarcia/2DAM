namespace Practica_1
{
    partial class Form2
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(219, 103);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(187, 58);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Insertar Persona";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(423, 103);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(187, 58);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Mostrar Persona";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(219, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Consultar DNI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(423, 187);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(187, 58);
            this.bt4.TabIndex = 2;
            this.bt4.Text = "Mostrar la persona con el nombre más largo";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(219, 268);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(187, 58);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "Mostrar la persona mas alta";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(423, 268);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(187, 58);
            this.bt6.TabIndex = 4;
            this.bt6.Text = "Salir";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.Bt6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form2";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
    }
}