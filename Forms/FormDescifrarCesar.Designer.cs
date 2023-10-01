
namespace tarea1.Forms
{
    partial class FormDescifrarCesar
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
            this.btnCesar = new System.Windows.Forms.Button();
            this.btnLlave = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnInverso = new System.Windows.Forms.Button();
            this.btnMensajeInverso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textLlave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTelefonico = new System.Windows.Forms.Button();
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
            this.textCifrar.TextChanged += new System.EventHandler(this.textCifrar_TextChanged);
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
            // btnCesar
            // 
            this.btnCesar.Location = new System.Drawing.Point(226, 521);
            this.btnCesar.Name = "btnCesar";
            this.btnCesar.Size = new System.Drawing.Size(121, 23);
            this.btnCesar.TabIndex = 2;
            this.btnCesar.Text = "Cifrado César";
            this.btnCesar.UseVisualStyleBackColor = true;
            this.btnCesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLlave
            // 
            this.btnLlave.Location = new System.Drawing.Point(384, 521);
            this.btnLlave.Name = "btnLlave";
            this.btnLlave.Size = new System.Drawing.Size(128, 23);
            this.btnLlave.TabIndex = 3;
            this.btnLlave.Text = "Cifrado por llave";
            this.btnLlave.UseVisualStyleBackColor = true;
            this.btnLlave.Click += new System.EventHandler(this.btnLlave_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(530, 521);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(137, 23);
            this.btnVigenere.TabIndex = 4;
            this.btnVigenere.Text = "Cifrado Vigenére";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnInverso
            // 
            this.btnInverso.Location = new System.Drawing.Point(692, 521);
            this.btnInverso.Name = "btnInverso";
            this.btnInverso.Size = new System.Drawing.Size(153, 23);
            this.btnInverso.TabIndex = 5;
            this.btnInverso.Text = "Palabra inversa";
            this.btnInverso.UseVisualStyleBackColor = true;
            this.btnInverso.Click += new System.EventHandler(this.btnInverso_Click);
            // 
            // btnMensajeInverso
            // 
            this.btnMensajeInverso.Location = new System.Drawing.Point(226, 563);
            this.btnMensajeInverso.Name = "btnMensajeInverso";
            this.btnMensajeInverso.Size = new System.Drawing.Size(159, 23);
            this.btnMensajeInverso.TabIndex = 6;
            this.btnMensajeInverso.Text = "Mensaje inverso";
            this.btnMensajeInverso.UseVisualStyleBackColor = true;
            this.btnMensajeInverso.Click += new System.EventHandler(this.btnMensajeInverso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(732, 563);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textLlave
            // 
            this.textLlave.Location = new System.Drawing.Point(567, 411);
            this.textLlave.Name = "textLlave";
            this.textLlave.Size = new System.Drawing.Size(100, 22);
            this.textLlave.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Llave o desplazamiento: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ir a descifrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Texto por cifrar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Texto cifrado:";
            // 
            // btnTelefonico
            // 
            this.btnTelefonico.Location = new System.Drawing.Point(399, 563);
            this.btnTelefonico.Name = "btnTelefonico";
            this.btnTelefonico.Size = new System.Drawing.Size(132, 23);
            this.btnTelefonico.TabIndex = 13;
            this.btnTelefonico.Text = "Cifrado telefónico";
            this.btnTelefonico.UseVisualStyleBackColor = true;
            this.btnTelefonico.Click += new System.EventHandler(this.btnTelefonico_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(551, 563);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(128, 23);
            this.btnBinario.TabIndex = 14;
            this.btnBinario.Text = "Cifrado Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // FormDescifrarCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 616);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnTelefonico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLlave);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMensajeInverso);
            this.Controls.Add(this.btnInverso);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnLlave);
            this.Controls.Add(this.btnCesar);
            this.Controls.Add(this.textCifrado);
            this.Controls.Add(this.textCifrar);
            this.Name = "FormDescifrarCesar";
            this.Text = "FormDescifrarCesar";
            this.Load += new System.EventHandler(this.FormDescifrarCesar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textCifrar;
        public System.Windows.Forms.TextBox textCifrado;
        public System.Windows.Forms.Button btnCesar;
        public System.Windows.Forms.Button btnLlave;
        public System.Windows.Forms.Button btnVigenere;
        public System.Windows.Forms.Button btnInverso;
        public System.Windows.Forms.Button btnMensajeInverso;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.TextBox textLlave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnTelefonico;
        public System.Windows.Forms.Button btnBinario;
    }
}