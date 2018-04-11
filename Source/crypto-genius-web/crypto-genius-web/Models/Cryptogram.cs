using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Crypto.Genius.Web.Models;

namespace crypto.genius.web.Models
{
    [Serializable]
    public class Cryptogram
    {
        public string Tip { get; set; }
        public string Answer { get; set; }
        public List<Word> GridWords { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }
        public bool Done { get; set; }
        public int WordLength { get; set; }

        public Cryptogram()
        {
            GenerateDictionary(TypeDictionary.Number);
        }

        /// <summary>
        /// Model of coquetel book number 269 page 5.
        /// </summary>
        public void GenerateModelNabopolassar()
        {
            this.Tip = "Nas casas em destaque: o filho e sucessor de Nabopolassar, rei da Babilônia que libertou o reino da Assíria e destruiu Nínive.";
            this.Answer = "NABUCODONOSORII";
            this.GridWords = new List<Word>();
            this.GridWords.Add(new Word("A doença que dura muito tempo", "CRONICA", this.Dictionary, 3));
            this.GridWords.Add(new Word("Resistente", "DURADOR", this.Dictionary, 3));
            this.GridWords.Add(new Word("Luta armada", "COMBATE", this.Dictionary, 3));
            this.GridWords.Add(new Word("Ofensa; ultraje.", "INSULTO", this.Dictionary, 3));
            this.GridWords.Add(new Word("Acocorar; abaixar.", "AGACHAR", this.Dictionary, 3));
            this.GridWords.Add(new Word("O mais popular no rasil é o futebol.", "ESPORTE", this.Dictionary, 3));
            this.GridWords.Add(new Word("Aquele que repõe a bola em campo.", "GANDULA", this.Dictionary, 3));
            this.GridWords.Add(new Word("(?) Assassinas, conjunto musical vítima de um trágico acidente.", "MAMONAS", this.Dictionary, 3));
            this.GridWords.Add(new Word("Pedra que, polida, substitui o mármore.", "GRANITO", this.Dictionary, 3));
            this.GridWords.Add(new Word("Bolo de milho vendido em brulhado na própria palha.", "PAMONHA", this.Dictionary, 3));
            this.GridWords.Add(new Word("Recrutar para o serviço militar.", "ALISTAR", this.Dictionary, 3));
            this.GridWords.Add(new Word("Caráter do trabalho do bombeiro.", "HEROICO", this.Dictionary, 3));
            this.GridWords.Add(new Word("Aviltar.", "DEGRADA", this.Dictionary, 3));
            this.GridWords.Add(new Word("Matrimônio; casamento.", "NUPCIAS", this.Dictionary, 3));
            this.GridWords.Add(new Word("Nascido sob o quinto signo do Zodíaco.", "LEONINO", this.Dictionary, 3));            
        }

        /// <summary>
        /// Generate the dictionary
        /// </summary>
        private void GenerateDictionary(TypeDictionary type)
        {
            this.Dictionary = new Dictionary<string, string>();
            var _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            AddItems(_alphabet);
        }
        /// <summary>
        /// Add Items on dictionary
        /// </summary>
        /// <param name="_alphabet"></param>
        private void AddItems(string _alphabet)
        {
            int position = 0;
            foreach (var letter in _alphabet)
            {
                AddItemDictionaryModel(letter, _alphabet.Count(), position);
                position++;
            }
        }

        private void AddItemDictionaryModel(char letter, int length, int position)
        {
            var model = "5,17,1,6,10,14,15,18,4,19,20,13,8,11,3,16,21,2,12,9,7,22,23,24,25,26";
            this.Dictionary.Add(letter.ToString(), model.Split(",")[position]);
        }

        /// <summary>
        /// Add Item on dictionary
        /// </summary>
        /// <param name="item"></param>
        /// <param name="length"></param>
        private void AddItemDictionary(char item, int length)
        {
            
        }
    }

    public enum TypeDictionary
    {
        Number,
        Symbols,
        Emotions,        
    }
}
