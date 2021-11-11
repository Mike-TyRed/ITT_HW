
namespace SubProcesos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pgb1 = new System.Windows.Forms.ProgressBar();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pgb2 = new System.Windows.Forms.ProgressBar();
            this.pgb3 = new System.Windows.Forms.ProgressBar();
            this.btnDetener = new System.Windows.Forms.Button();
            this.txtb4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hilo 1:";
            // 
            // pgb1
            // 
            this.pgb1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pgb1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pgb1.Location = new System.Drawing.Point(213, 9);
            this.pgb1.Name = "pgb1";
            this.pgb1.Size = new System.Drawing.Size(414, 32);
            this.pgb1.TabIndex = 1;
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb1.Location = new System.Drawing.Point(107, 9);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 29);
            this.txtb1.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIniciar.Location = new System.Drawing.Point(135, 212);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 45);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Inicio";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtb2
            // 
            this.txtb2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb2.Location = new System.Drawing.Point(107, 66);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 29);
            this.txtb2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hilo 2:";
            // 
            // txtb3
            // 
            this.txtb3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb3.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb3.Location = new System.Drawing.Point(107, 130);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(100, 29);
            this.txtb3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hilo 3:";
            // 
            // pgb2
            // 
            this.pgb2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pgb2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pgb2.Location = new System.Drawing.Point(211, 66);
            this.pgb2.Name = "pgb2";
            this.pgb2.Size = new System.Drawing.Size(416, 29);
            this.pgb2.TabIndex = 8;
            // 
            // pgb3
            // 
            this.pgb3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pgb3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pgb3.Location = new System.Drawing.Point(213, 130);
            this.pgb3.Name = "pgb3";
            this.pgb3.Size = new System.Drawing.Size(414, 29);
            this.pgb3.TabIndex = 9;
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetener.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDetener.Location = new System.Drawing.Point(256, 212);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(144, 45);
            this.btnDetener.TabIndex = 10;
            this.btnDetener.Text = "Suspender";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // txtb4
            // 
            this.txtb4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb4.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb4.Location = new System.Drawing.Point(278, 263);
            this.txtb4.Name = "txtb4";
            this.txtb4.Size = new System.Drawing.Size(100, 33);
            this.txtb4.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.Window;
            this.btn3.Location = new System.Drawing.Point(406, 212);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(118, 45);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "Detener";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 308);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.txtb4);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.pgb3);
            this.Controls.Add(this.pgb2);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.pgb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sub procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgb1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pgb2;
        private System.Windows.Forms.ProgressBar pgb3;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TextBox txtb4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn3;
    }
}

