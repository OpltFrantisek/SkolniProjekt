using System;
using System.Collections.Generic;
using System.Linq;

namespace Morseovka
{
    class MorseovaAbeceda
    {
        private string[][] abc = new string[2][];
        private char[] znaky = new char[] { '.', '-', ' ', '/' };
        public string vyslednaVeta;
        public string VyslednaVeta
        {
            get { return vyslednaVeta; }
        }
        public void Pokus()
        {
            throw new NotImplementedException();
        }
        public MorseovaAbeceda()
        {
            abc[0] = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "----", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", ".-.-.-.", ".....", "---...", "--..--", "..--..", "--..-", "-.-.-.", "--...", "-.--.-", ".-..-.", "-....-", "..--.-", ".--.-." };
            abc[1] = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "ch", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z","0","1","2","3","4","5","6","7","8","9",".",".",":",",","?","!",";","(",")","\"","-","_","@"};                  
        }
        public void NovaVeta(string code)
        {
            vyslednaVeta = RozdelNaSlova(code);
        }
        private string RozdelNaSlova(string code)
        {
            string s = "";
            string[] veta = code.Split('/');
            foreach(string slovo in veta)
            {
               s += PrelozSlovo(slovo)+" ";
            }
            return s;
        }
        private string PrelozSlovo(string slovo)
        {
            string[] pismena = slovo.Split(' ');
            string prelozeneSlovo = "";
            foreach(string znak in pismena)
            {
                if (abc[0].Contains(znak))
                {
                    int pozice = Array.IndexOf(abc[0], znak);
                    prelozeneSlovo += abc[1][pozice];
                } 
            }
            return prelozeneSlovo;

        }
        public List<int> PrevedNaIO(string data)
        {
            List <int> vystup = new List<int>();

            foreach(char znak in data)
            {
                switch (znak)
                {
                    case '.':vystup.Add(0); break;
                    case '-':vystup.Add(1); break;
                    case ' ':vystup.Add(3); break;
                    case '/':vystup.Add(4); break;
                }
            }
            return vystup;                              
        }
        
    }
}
