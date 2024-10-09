using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTM_Generator;

namespace VTM_DMTool.DataBase
{
    internal class CharDataBase
    {
        //List<character> data;
        public List<VTM_Generator.Char> Chars = new List<VTM_Generator.Char>();
        VTM_Generator.Char CurrentChar;


        public void GenerateANewChar()
        {
            Console.Clear();
            CurrentChar = new VTM_Generator.Char();
            CurrentChar.StartGenerate();
        }

     
        public void AddCharacter()
        {
            
            Chars.Add(CurrentChar);
        }
        public void TryToFind() { }
        public void SearchData() { }
        void PrintCharacterData() { }
    }
}
