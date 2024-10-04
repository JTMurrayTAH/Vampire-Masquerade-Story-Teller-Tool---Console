using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTM_Generator
{
    internal class CharacterCreator
    {
        Char[] CharacterList;
        //Char[] CharList;

        public CharacterCreator()
        {
            
        }

        public void StartChar(int AmountOfChars)
        {
        CharacterList = new Char[AmountOfChars];
            for (int i = 0; i < CharacterList.Length; i++)
            {
                // Initialize each character with a name from exampleNames or any other source
                CharacterList[i] = new Char();

                CharacterList[i].StartGenerate(); // Call StartGenerate for each character
            }
        }
    }
}
