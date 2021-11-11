
namespace Interfaz_de_archivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnG = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.lblAr = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(171, -1);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(99, 31);
            this.btnG.TabIndex = 0;
            this.btnG.Text = "Guardar";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(87, -1);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(91, 31);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Abrir";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // rtxt
            // 
            this.rtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt.Location = new System.Drawing.Point(12, 97);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(529, 341);
            this.rtxt.TabIndex = 3;
            this.rtxt.Text = "";
            // 
            // lblAr
            // 
            this.lblAr.AutoSize = true;
            this.lblAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAr.Location = new System.Drawing.Point(12, 58);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(0, 25);
            this.lblAr.TabIndex = 4;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(1, -1);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(91, 31);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "Crear";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnG);
            this.Name = "Form1";
            this.Text = "Bloc de notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Label lblAr;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

