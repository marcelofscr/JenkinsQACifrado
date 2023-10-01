using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{
    class CifradoPorDiccionarios : Criptografia
    {
        protected Dictionary<char, String> diccionarioAlfabeto = new Dictionary<char, string>();

        public String descifrarConDiccionario()
        {
            String aux = "";
            foreach (var caracter in frase.Split(' '))
            {
                aux += getKey(caracter);
            }
            frase = aux;
            return frase;
        }
        public String cifrarConDiccionario()
        {
            String aux = "";
            foreach (var caracter in frase) 
            {
                aux += getValue(caracter) + " ";
            }
            frase = aux;
            return frase;
        }

        public String getValue(char pKey) 
        {
            String valor = "";
            foreach (var item in diccionarioAlfabeto)
            {
                if (item.Key.Equals(pKey))
                {
                    valor = item.Value;
                }
            }
            return valor;
        }

        public char getKey(String pValue) //Este método aparece en dos sub clases del mismo nivel.
        {
            char llave = ' ';
            foreach (var item in diccionarioAlfabeto)
            {
                if (item.Value.Equals(pValue))
                {
                    llave = item.Key;
                }
            }
            return llave;
        }


    }
}
