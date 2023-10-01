using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{
    /// <summary>
    /// Abstracción de la clase criptografía para efectos académicos. 
    /// </summary>
    public class Criptografia
    {
        protected String frase;
        protected int primeraLetra = 'a';
        protected int ultimaLetra = ('z' - 'a') + 1;

       

        protected String getFrase() 
        {
            return frase;
        }

        public String Frase(String pFrase) => frase = pFrase;


       /// <summary>
       /// Determina si un carácter es un espacio
       /// </summary>
       /// <param name="pCaracter">Una letra de tipo char</param>
       /// <returns>True si es un espacio</returns>
        protected Boolean esEspacio(char pCaracter) 
        {
            return pCaracter == 32;
        }
        
        
    }
}
