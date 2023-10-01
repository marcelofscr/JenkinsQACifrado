using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tareaCifrados.Models;

namespace tarea1.Forms
{
    public partial class FormDescifrarCesar : Form
    {
        public FormDescifrarCesar()
        {
            InitializeComponent();
        }
        CifradoCesar cCesar = new CifradoCesar();
        CifradoLlave cLlave = new CifradoLlave();
        CifradoVigenere cVigenere = new CifradoVigenere();
        CifradoTransposicion cTrans = new CifradoTransposicion();
        CifradoTelefonico cTelefonico = new CifradoTelefonico();
        CifradoBinario cBinario = new CifradoBinario();

        private void button1_Click(object sender, EventArgs e)
        {
            
            cCesar.Frase(textCifrar.Text.ToLower());
            if (textLlave.Text == "" || Int32.TryParse(textLlave.Text, out int y) == false)
            {
                MessageBox.Show("Desplazamiento o llave inválida", "Error");
                
            }
            else 
            {
                textCifrado.Text = cCesar.cifrarCesar(Int32.Parse(textLlave.Text));
            }
        }

        private void textCifrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDescifrarCesar_Load(object sender, EventArgs e)
        {

        }

        private void btnLlave_Click(object sender, EventArgs e)
        {

            cLlave.Frase(textCifrar.Text.ToLower());
            if (textLlave.Text == "" || Int32.TryParse(textLlave.Text, out int y) == true)
            {
                MessageBox.Show("Desplazamiento o llave inválida", "Error");

            }
            else
            {
                
                textCifrado.Text = cLlave.cifrarFrase(textLlave.Text);
            }
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textLlave.Text, out int i) && int.Parse(textLlave.Text) <= 99)
            {
                cVigenere.Frase(textCifrar.Text.ToLower());
                textCifrado.Text = cVigenere.cifrarFraseVigenere(1, textLlave.Text);
            }
            else 
            {
                MessageBox.Show("Desplazamiento o llave inválida", "Error");
            }
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            cTrans.Frase(textCifrar.Text);
            textCifrado.Text = cTrans.cifrarMensajeInverso(textCifrar.Text);

        }

        private void btnMensajeInverso_Click(object sender, EventArgs e)
        {
            cTrans.Frase(textCifrar.Text);
            textCifrado.Text = cTrans.cifrarPalabraInversa();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textCifrado.Text = "";
            textCifrar.Text = "";
            textLlave.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormDescifrar x = new FormDescifrar();
            x.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTelefonico_Click(object sender, EventArgs e)
        {
            cTelefonico.Frase(textCifrar.Text);
            textCifrado.Text = cTelefonico.cifrarConDiccionario();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            cBinario.Frase(textCifrar.Text);
            textCifrado.Text = cBinario.cifrarConDiccionario();
        }
    }
    }

