using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{/// <summary>
/// Abstracción de la clase transposición para efectos académicos
/// </summary>
    public class CifradoTransposicion : Criptografia
    {

        /// <summary>
        /// Cifra una frase palabra por palabra sin afectar su posición en la oración.
        /// </summary>
        /// <param name="pFrase"> Un string de caracteres correspondiente a la frase por cifrar</param>
        /// <returns></returns>
        public String cifrarMensajeInverso(String pFrase) 
        {
            string palabraInversa = string.Join(" ", frase.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            frase = palabraInversa;
            return frase;
        }
        /// <summary>
        /// Cifra un mensaje en su totalidad
        /// </summary>
        /// <returns>Un string con la palabra o frase inversa</returns>
        public String cifrarPalabraInversa() 
        {
            int i = frase.Length;
            String aux = "";
            while (i > 0) 
            {
                aux += frase[i - 1];
                i--;
            }
            frase = aux;
            return frase; 
        }
    }
}
