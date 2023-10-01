using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaCifrados.Models;

namespace tareaCifrados.Models
{
    class CifradoTelefonico : CifradoPorDiccionarios
    {
        


        public CifradoTelefonico() 
        {
            setDiccionario();
        }

        public void setDiccionario() 
        {
           diccionarioAlfabeto.Add('a', "21");
           diccionarioAlfabeto.Add('b', "22");
           diccionarioAlfabeto.Add('c', "23");
           diccionarioAlfabeto.Add('d', "31");
           diccionarioAlfabeto.Add('e', "32");
           diccionarioAlfabeto.Add('f', "33");
           diccionarioAlfabeto.Add('g', "41");
           diccionarioAlfabeto.Add('h', "42");
           diccionarioAlfabeto.Add('i', "43");
           diccionarioAlfabeto.Add('j', "51");
           diccionarioAlfabeto.Add('k', "52");
           diccionarioAlfabeto.Add('l', "53");
           diccionarioAlfabeto.Add('m', "61");
           diccionarioAlfabeto.Add('n', "62");
           diccionarioAlfabeto.Add('o', "63");
           diccionarioAlfabeto.Add('p', "71");
           diccionarioAlfabeto.Add('q', "72");
           diccionarioAlfabeto.Add('r', "73");
           diccionarioAlfabeto.Add('s', "74");
           diccionarioAlfabeto.Add('t', "81");
           diccionarioAlfabeto.Add('u', "82");
           diccionarioAlfabeto.Add('v', "83");
           diccionarioAlfabeto.Add('w', "91");
           diccionarioAlfabeto.Add('x', "92");
           diccionarioAlfabeto.Add('y', "93");
           diccionarioAlfabeto.Add('z', "94");
           diccionarioAlfabeto.Add(' ', "*");
        }

       

       

       

       


    }
}
