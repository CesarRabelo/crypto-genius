using System;
using System.Collections.Generic;

namespace CryptoGeniusWebApp.Models
{
    public class Cryptogram
    {
        public Cryptogram()
        {
            
        }

        public int Id { get; set; }
        public Guid Key { get; set; }
        public string Tip { get; set; }
        public string Answer { get; set; }
        public string Alphabet { get; set; }
        public int AnswerLength { get { return this.Answer.Length; } }
        public string Model { get; set; }
        public bool Done { get; set; }
        //public List<Word> GridWords { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }

    }
}
