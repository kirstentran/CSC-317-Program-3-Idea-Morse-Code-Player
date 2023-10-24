using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Program Author: Kirsten Tran - w10015360 
   Assignment: Program 3 Morse Code Player
Description: This Page cotains the back-end code of the Morse Encode algorithm running when the button Simulate is called */

namespace CSC_317_Program_3_Idea_Morse_Code_Player
{
    internal class MorseEncoder
    {
        /* This class should accept a message and convert it to Morse Code.
         * complete the class below.
         */

        private string message;
        private string morse_code;


        public MorseEncoder()
        {
            morse_code = string.Empty;

        }

        public string Text
        {
            get { return this.message; }
            set
            {
                this.message = value;

                this.morse_code = "";
                Translate();

            }
        }
        public string Morse
        {
            get { return this.morse_code; }

        }
        private void Translate()
        {
            string abc = message.ToLower();
            for (int i = 0; i < abc.Length; i++)
            {
                morse_code += translation[abc[i]];
            }
        }

        /* This is a dictionary that is used to store the translation table  
         * for converting your message to Morse Code
         */
        private static Dictionary<char, string> translation = new Dictionary<char, string>()
        {
            { 'a', ".-" },
            { 'b', "-..." },
            { 'c', "-.-." },
            { 'd', "-.." },
            { 'e', "." },
            { 'f', "..-." },
            { 'g', "--." },
            { 'h', "...." },
            { 'i', ".." },
            { 'j', ".---" },
            { 'k', "-.-" },
            { 'l', ".-.." },
            { 'm', "--" },
            { 'n', "-." },
            { 'o', "---" },
            { 'p', ".--." },
            { 'q', "--.-" },
            { 'r', ".-." },
            { 's', "..." },
            { 't', "-" },
            { 'u', "..-" },
            { 'v', "...-" },
            { 'w', ".--" },
            { 'x', "-..-" },
            { 'y', "-.--" },
            { 'z', "--.." },
            { '0', "-----" },
            { '1', ".-----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." },
            { ' ', "\\" },
        };
    }
}
