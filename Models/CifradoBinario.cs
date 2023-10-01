using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaCifrados.Models
{
    class CifradoBinario : CifradoPorDiccionarios
    {
       

        public CifradoBinario() 
        {
            setDiccionario();
        }

        public void setDiccionario() 
        {
            diccionarioAlfabeto.Add('a', "00000");
            diccionarioAlfabeto.Add('b', "00001");
            diccionarioAlfabeto.Add('c', "00010");
            diccionarioAlfabeto.Add('d', "00011");
            diccionarioAlfabeto.Add('e', "00100");
            diccionarioAlfabeto.Add('f', "00101");
            diccionarioAlfabeto.Add('g', "00110");
            diccionarioAlfabeto.Add('h', "00111");
            diccionarioAlfabeto.Add('i', "01000");
            diccionarioAlfabeto.Add('j', "01001");
            diccionarioAlfabeto.Add('k', "01010");
            diccionarioAlfabeto.Add('l', "01011");
            diccionarioAlfabeto.Add('m', "01100");
            diccionarioAlfabeto.Add('n', "01101");
            diccionarioAlfabeto.Add('o', "01110");
            diccionarioAlfabeto.Add('p', "01111");
            diccionarioAlfabeto.Add('q', "10000");
            diccionarioAlfabeto.Add('r', "10001");
            diccionarioAlfabeto.Add('s', "10010");
            diccionarioAlfabeto.Add('t', "10011");
            diccionarioAlfabeto.Add('u', "10100");
            diccionarioAlfabeto.Add('v', "10101");
            diccionarioAlfabeto.Add('w', "10110");
            diccionarioAlfabeto.Add('x', "10111");
            diccionarioAlfabeto.Add('y', "11000");
            diccionarioAlfabeto.Add('z', "11001");
            diccionarioAlfabeto.Add(' ', "*");
        }
       

        

       
    }
}
