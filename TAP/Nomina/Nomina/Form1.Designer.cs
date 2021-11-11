
namespace Nomina
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.btng = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario/hora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtn
            // 
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.Location = new System.Drawing.Point(157, 74);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(206, 29);
            this.txtn.TabIndex = 2;
            // 
            // txts
            // 
            this.txts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts.Location = new System.Drawing.Point(157, 118);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(100, 31);
            this.txts.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horas/mes:";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.Location = new System.Drawing.Point(283, 9);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(0, 19);
            this.lbld.TabIndex = 8;
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh.Location = new System.Drawing.Point(311, 43);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(0, 19);
            this.lblh.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "Registro de datos:";
            // 
            // txth
            // 
            this.txth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth.Location = new System.Drawing.Point(157, 166);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(100, 31);
            this.txth.TabIndex = 11;
            // 
            // btng
            // 
            this.btng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btng.Location = new System.Drawing.Point(106, 235);
            this.btng.Name = "btng";
            this.btng.Size = new System.Drawing.Size(97, 33);
            this.btng.TabIndex = 12;
            this.btng.Text = "Guardar";
            this.btng.UseVisualStyleBackColor = true;
            this.btng.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnl
            // 
            this.btnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnl.Location = new System.Drawing.Point(209, 235);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(97, 33);
            this.btnl.TabIndex = 13;
            this.btnl.Text = "Limpiar";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 296);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btng);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Nómina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Button btng;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.Timer timer1;
    }
}

