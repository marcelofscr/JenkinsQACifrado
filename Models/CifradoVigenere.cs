using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{
    public class CifradoVigenere : CifradoCesar
    {
        
        /// <summary>
        /// Funciona para cifrar o descifrar una palabra utilizando el método Vigenére
        /// </summary>
        /// <param name="pPalabra">Palabra que será cifrada o descifrada</param>
        /// <param name="pUnidad">1 para cifrar o -1 para descifrar</param>
        /// <param name="pLlave">Valor de la llave</param>
        /// <returns></returns>
        private String cifrarVigenere(String pPalabra, int pUnidad, String pLlave) 
        {
            String fraseAux = "";
            int i = 0;
            int c = 0;
            int desplazamiento;
            while (c < pPalabra.Length) 
            {
                desplazamiento = int.Parse(pLlave[i].ToString()) * pUnidad;
                fraseAux += cifrarCaracterCesar(pPalabra[c], desplazamiento);
                c++;
                i++;
                if (i == pLlave.Length) 
                {
                    i = 0;
                }

            }
            frase = fraseAux;
            return frase;
        }


        /// <summary>
        /// Cifra o descifra una frase por el método Vigenére
        /// </summary>
        /// <param name="pUnidad">1 para descifrar o -1 para descifrar</param>
        /// <param name="pLlave">El valor de la llave</param>
        /// <returns></returns>

        public String cifrarFraseVigenere(int pUnidad, String pLlave) 
        {
            String auxFrase = "";
            foreach (String palabra in frase.Split())
            {
                auxFrase += cifrarVigenere(palabra, pUnidad, pLlave) + " ";
            }

            this.frase = auxFrase;
            return frase;
        }

      




    }
}
