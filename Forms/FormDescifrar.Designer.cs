
namespace tarea1.Forms
{
    partial class FormDescifrar
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
            this.textCifrar = new System.Windows.Forms.TextBox();
            this.textCifrado = new System.Windows.Forms.TextBox();
            this.textLlave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCesar = new System.Windows.Forms.Button();
            this.btnLlave = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btnInverso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDescifradoTelefono = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCifrar
            // 
            this.textCifrar.Location = new System.Drawing.Point(47, 113);
            this.textCifrar.Multiline = true;
            this.textCifrar.Name = "textCifrar";
            this.textCifrar.Size = new System.Drawing.Size(378, 237);
            this.textCifrar.TabIndex = 0;
            this.textCifrar.TextChanged += new System.EventHandler(this.txtCifrar_TextChanged);
            // 
            // textCifrado
            // 
            this.textCifrado.Location = new System.Drawing.Point(663, 113);
            this.textCifrado.Multiline = true;
            this.textCifrado.Name = "textCifrado";
            this.textCifrado.ReadOnly = true;
            this.textCifrado.Size = new System.Drawing.Size(378, 237);
            this.textCifrado.TabIndex = 1;
            // 
            // textLlave
            // 
            this.textLlave.Location = new System.Drawing.Point(567, 411);
            this.textLlave.Name = "textLlave";
            this.textLlave.Size = new System.Drawing.Size(100, 22);
            this.textLlave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Llave o desplazamiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCesar
            // 
            this.btnCesar.Location = new System.Drawing.Point(219, 491);
            this.btnCesar.Name = "btnCesar";
            this.btnCesar.Size = new System.Drawing.Size(138, 23);
            this.btnCesar.TabIndex = 4;
            this.btnCesar.Text = "Descifrado César";
            this.btnCesar.UseVisualStyleBackColor = true;
            this.btnCesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLlave
            // 
            this.btnLlave.Location = new System.Drawing.Point(382, 491);
            this.btnLlave.Name = "btnLlave";
            this.btnLlave.Size = new System.Drawing.Size(149, 23);
            this.btnLlave.TabIndex = 5;
            this.btnLlave.Text = "Descifrado por llave";
            this.btnLlave.UseVisualStyleBackColor = true;
            this.btnLlave.Click += new System.EventHandler(this.btnLlave_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(550, 491);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(161, 23);
            this.btnVigenere.TabIndex = 6;
            this.btnVigenere.Text = "Descifrado Vigenére";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnInversa
            // 
            this.btnInversa.Location = new System.Drawing.Point(739, 491);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(146, 23);
            this.btnInversa.TabIndex = 7;
            this.btnInversa.Text = "Palabra inversa";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnInverso
            // 
            this.btnInverso.Location = new System.Drawing.Point(219, 541);
            this.btnInverso.Name = "btnInverso";
            this.btnInverso.Size = new System.Drawing.Size(138, 23);
            this.btnInverso.TabIndex = 8;
            this.btnInverso.Text = "Mensaje inverso";
            this.btnInverso.UseVisualStyleBackColor = true;
            this.btnInverso.Click += new System.EventHandler(this.btnInverso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(789, 541);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1053, 571);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 10;
            this.button7.Text = "Volver";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(47, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(186, 34);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Texto cifrado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Texto descifrado:";
            // 
            // btnDescifradoTelefono
            // 
            this.btnDescifradoTelefono.Location = new System.Drawing.Point(382, 541);
            this.btnDescifradoTelefono.Name = "btnDescifradoTelefono";
            this.btnDescifradoTelefono.Size = new System.Drawing.Size(167, 23);
            this.btnDescifradoTelefono.TabIndex = 13;
            this.btnDescifradoTelefono.Text = "Descifrado telefónico";
            this.btnDescifradoTelefono.UseVisualStyleBackColor = true;
            this.btnDescifradoTelefono.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(584, 541);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(158, 23);
            this.btnBinario.TabIndex = 14;
            this.btnBinario.Text = "Descifrado binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // FormDescifrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 616);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnDescifradoTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInverso);
            this.Controls.Add(this.btnInversa);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnLlave);
            this.Controls.Add(this.btnCesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLlave);
            this.Controls.Add(this.textCifrado);
            this.Controls.Add(this.textCifrar);
            this.Name = "FormDescifrar";
            this.Text = "FormDescifrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCifrar;
        private System.Windows.Forms.TextBox textCifrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox textLlave;
        public System.Windows.Forms.Button btnCesar;
        public System.Windows.Forms.Button btnLlave;
        public System.Windows.Forms.Button btnVigenere;
        public System.Windows.Forms.Button btnInversa;
        public System.Windows.Forms.Button btnInverso;
        public System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnDescifradoTelefono;
        public System.Windows.Forms.Button btnBinario;
    }
}