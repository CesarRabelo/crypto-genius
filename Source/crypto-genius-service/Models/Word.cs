using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto.Genius.Service.Models
{
    [Serializable]
    public class Word
    {
        public string Answer { get; set; }
        public int Position { get; set; }
        public string Tip { get; set; }
        public List<Letter> Letters { get; set; }
        public int InvisiblePositionLetter { get; set; }
        public bool Done { get; set; }
        private Dictionary<string, string> Dictionary;

        public Word()
        {

        }

        public Word(int invisiblePositionLetter)
        {
            this.InvisiblePositionLetter = invisiblePositionLetter;
            this.Letters = new List<Letter>();
            GenerateLetters();
        }

        public Word(string tip, string Answer, Dictionary<string, string> dictionary, int invisiblePositionLetter)
        {
            this.Tip = tip;
            this.Answer = Answer;
            this.InvisiblePositionLetter = invisiblePositionLetter;
            this.Letters = new List<Letter>();
            this.Dictionary = dictionary;
            GenerateLetters();
        }

        private void GenerateLetters()
        {
            int position = 0;
            foreach(var l in Answer)
            {
                this.Letters.Add(new Letter() { Key = this.Dictionary[l.ToString()], Value = l.ToString(), KeyVisible = position != InvisiblePositionLetter });
                position++;
            }
        }
    }
}
