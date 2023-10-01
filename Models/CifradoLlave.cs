using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{
    /// <summary>
    /// Abstacción de la clase CifradoLlave para efectos académicos
    /// </summary>
    public class CifradoLlave : Criptografia
    {
        
        /// <summary>
        /// Ajusta el tamaño de una cadena de caracteres al de otra cadena de caracteres.
        /// </summary>
        /// <param name="pPalabra">Una cadena de caracteres</param>
        /// <param name="llave">Una cadena de caracteres a la que se debe ajustar pPalabra</param>
        /// <returns>La cadena de caracteres con otros agregados para ajustarse al tamaño</returns>
        private String ajustarLlave(String pPalabra, String llave) 
        {
            String llaveAjustada = "";
            if (llave.Length < pPalabra.Length)
            {
                llaveAjustada = ajustarLlaveAuxiliar(llaveAjustada, pPalabra, llave);
            }
            else 
            {
                llaveAjustada = llave.Substring(0, pPalabra.Length);
            }
            return llaveAjustada;
        }

        /// <summary>
        /// Ajusta el tamaño de una cadena de caracteres al de otra cadena de caracteres si la palabra llave
        /// es más pequeña que la palabra por cifrar.
        /// </summary>
        /// <param name="pPalabra">Una cadena de caracteres</param>
        /// <param name="llave">Una cadena de caracteres a la que se debe ajustar pPalabra</param>
        /// <returns>La cadena de caracteres con otros agregados para ajustarse al tamaño</returns>
        private String ajustarLlaveAuxiliar(String pLlaveAjustar, String pPalabra, String pLlave) 
        {
            int i = 0;
            while (pLlaveAjustar.Length < pPalabra.Length)
            {
                pLlaveAjustar += pLlave[i];
                i++;

                if (i == pLlave.Length)
                {
                    i = 0;
                }
            }
            return pLlaveAjustar;

        }
        /// <summary>
        /// Codifica una cadena de caracteres utilizando otra como llave, este método recibe solo una palabra.
        /// </summary>
        /// <param name="pPalabra">La palabra o frase por cifrar</param>
        /// <param name="llave">La llave que se debe utilizar para la codificación</param>
        /// <returns>Una cadena de caracteres cifrada</returns>
        private String cifradoPalabraLlave(String pPalabra, String llave) 
        {
            char letraCifrada;
            String llaveAux = ajustarLlave(pPalabra, llave);
            String auxFrase = "";
            int i = 0;
            while (i < llaveAux.Length) 
            {
                int nuevaPosicion = pPalabra[i] + llaveAux[i];
                if (nuevaPosicion < 122)
                {
                    letraCifrada = (char)(nuevaPosicion);
                    auxFrase += letraCifrada;
                }
                else
                {
                    nuevaPosicion = setNuevaPosicion(nuevaPosicion);
                    letraCifrada = (char)(nuevaPosicion);
                    auxFrase += letraCifrada;
                }
                i++;
            }
            return auxFrase;
        }

        private int setNuevaPosicion(int pPosicion) 
        {
            pPosicion -= 122;
            if (pPosicion < 97) 
            {
                pPosicion += 26;
            }
            return pPosicion;
        }

        /// <summary>
        /// Descifra una cadena de caracteres previamente codificada por llave, este método recibe solo una palabra
        /// </summary>
        /// <param name="pPalabra">La cadena de carecteres por descifrar</param>
        /// <param name="llave">La llave que se utilizó para cifrarla</param>
        /// <returns>La cadena de caracteres descifrada</returns>
        private String descifradoPorLlave(String pPalabra, String llave) 
        {
            char letraCifrada;
            String llaveAux = ajustarLlave(pPalabra, llave);
            String auxFrase = "";
            int i = 0;
            while (i < llaveAux.Length)
            {
                int nuevaPosicion = pPalabra[i] - llaveAux[i];
                if (nuevaPosicion < 0)
                {
                    nuevaPosicion = nuevaPosicion + 122;
                    letraCifrada = (char)(nuevaPosicion);
                    auxFrase += letraCifrada;
                }
                else
                {
                    nuevaPosicion = nuevaPosicion + 96;
                    letraCifrada = (char)(nuevaPosicion);
                    auxFrase += letraCifrada;
                }
                i++;
            }
            return auxFrase;
        }

        /// <summary>
        /// Cifra una frase formada por palabras correspondientes a una cadena de caracteres
        /// </summary>
        /// <param name="llave"> La llave que se utilizará para el cifrado</param>
        /// <returns>La frase cifrada</returns>
        public String cifrarFrase(String llave) 
        {
            String auxFrase = "";
            foreach (String palabra in frase.Split()) 
            {
                auxFrase += cifradoPalabraLlave(palabra, llave) + " ";

            }

            frase = auxFrase;
            return frase;
        }

        /// <summary>
        /// Decodifica una frase formada por palabras correspondientes a una cadena de caracteres
        /// </summary>
        /// <param name="llave"> La llave que se utilizó para el cifrado</param>
        /// <returns>La frase decodificada</returns>
        public String descifrarFrase(String llave) 
        {
            String auxFrase = "";
            foreach (String palabra in frase.Split())
            {
                auxFrase += descifradoPorLlave(palabra, llave) + " ";
            }

            this.frase = auxFrase;
            return frase;
        }



    }
}
