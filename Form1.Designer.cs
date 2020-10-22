namespace Evaluación_de_Expresiones_Pila_
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
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Location = new System.Drawing.Point(12, 31);
            this.txtUbicacion.Multiline = true;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(225, 21);
            this.txtUbicacion.TabIndex = 0;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(243, 31);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(66, 23);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Enabled = false;
            this.txtExpresion.Location = new System.Drawing.Point(12, 114);
            this.txtExpresion.Multiline = true;
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(225, 153);
            this.txtExpresion.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(243, 176);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(324, 114);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(225, 153);
            this.txtResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 331);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtUbicacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUbicacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.OpenFileDialog txtArchivo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

