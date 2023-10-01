using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{
    /// <summary>
    /// Abstracción de la clase cifrado César para efectos académicos
    /// </summary>
    public class CifradoCesar : Criptografia
    {



        /// <summary>
        /// Realiza un cifrado de tipo César sobre un carácter.
        /// </summary>
        /// <param name="pCaracter">Una letra de tipo char</param>
        /// <param name="pDesplazamiento">El valor del desplazamiento que recibirá el valor de tipo char</param>
        /// <returns>El carácter cifrado</returns>
        protected char cifrarCaracterCesar(char pCaracter, int pDesplazamiento) 
        {
            int posicion = pCaracter - primeraLetra;

            int nuevaPosicion = ((posicion + (pDesplazamiento)) % ultimaLetra + ultimaLetra) % ultimaLetra;
            char letraCifrada = (char)(primeraLetra + nuevaPosicion);
            return letraCifrada;
        }

        /// <summary>
        /// Cifra un string de caracteres de acuerdo con la codificación César.
        /// </summary>
        /// <param name="pDesplazamiento">Un int con el valor del desplazamiento</param>
        /// <returns></returns>
        public String cifrarCesar(int pDesplazamiento) 
        {
            char[] fraseToArray = this.frase.ToCharArray();

            for (int i = 0; i < fraseToArray.Length; i++) 
            {
                char letraActual = fraseToArray[i];

                if (!esEspacio(letraActual)) 
                {
                    fraseToArray[i] = cifrarCaracterCesar(letraActual, pDesplazamiento);
                }

            }
            this.frase = new string(fraseToArray);
            return frase;
        }
        /// <summary>
        /// Decodifica un string de caracteres de tipo César.
        /// </summary>
        /// <param name="pDesplazamiento"></param>
        /// <returns></returns>
        public String descifrarCesar(int pDesplazamiento) 
        {
            
            return cifrarCesar(pDesplazamiento * -1);

        }






    }
}
