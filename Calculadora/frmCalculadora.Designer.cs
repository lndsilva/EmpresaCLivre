namespace Calculadora
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(53, 32);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(78, 20);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Número 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(53, 55);
            this.txtNum1.MaxLength = 10;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(176, 26);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(53, 130);
            this.txtNum2.MaxLength = 10;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(176, 26);
            this.txtNum2.TabIndex = 1;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(53, 107);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(78, 20);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Número 2";
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Image = ((System.Drawing.Image)(resources.GetObject("btnSomar.Image")));
            this.btnSomar.Location = new System.Drawing.Point(53, 184);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(176, 47);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSomar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(53, 255);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(151, 255);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 20);
            this.lblResposta.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(53, 303);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 47);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 362);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnLimpar;
    }
}