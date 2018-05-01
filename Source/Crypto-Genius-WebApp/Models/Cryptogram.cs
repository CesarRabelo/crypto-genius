using System;
using System.Collections.Generic;

namespace CryptoGeniusWebApp.Models
{
    [Serializable]
    public class Cryptogram
    {
        public Guid Id { get; set; }
        public string Tip { get; set; }
        public string Answer { get; set; }
        public string Alphabet { get; set; }
        public int AnswerLength { get { return this.Answer.Length; } }
        public string Model { get; set; }
        public bool Done { get; set; }
        public List<Word> GridWords { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }


        public Cryptogram(string tip, string answer, Dictionary<string, string> dictionary)
        {
            this.Tip = tip;
            this.Answer = answer;
            this.Dictionary = dictionary;
            this.Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public Cryptogram()
        {
            this.Id = Guid.NewGuid();
            this.Dictionary = new Dictionary<string, string>();
            this.Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public Cryptogram(Guid id)
        {
            this.Id = id;
            this.Dictionary = new Dictionary<string, string>();
            this.Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        /// <summary>
        /// Model of coquetel book number 269 page 5.
        /// </summary>
        public void GenerateModelNabopolassar()
        {
            this.Tip = "Nas casas em destaque: o filho e sucessor de Nabopolassar, rei da Babilônia que libertou o reino da Assíria e destruiu Nínive.";
            this.Answer = "NABUCODONOSORII";
            this.Model = "5,17,1,6,10,14,15,18,4,19,20,13,8,11,3,16,21,2,12,9,7,22,23,24,25,26";
            this.GenerateDictionary(TypeDictionary.Number);
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
            this.GridWords.Add(new Word("Matrimônio; casamento.", "NUPCIAS", this.Dictionary, 4));
            this.GridWords.Add(new Word("Nascido sob o quinto signo do Zodíaco.", "LEONINO", this.Dictionary, 4));

        }

        /// <summary>
        /// Model of coquetel book number 269 page 5.
        /// </summary>
        public void GenerateModelPartidaEmpatada()
        {
            this.Tip = "Para letras iguais, números iguais. Resolvido o passatempo, surgirá, nas casas em destaque a situação que leva um jogo de futebol a prorrogação.";
            this.Answer = "PARTIDAEMPATADA";
            this.Model = "4,15,14,8,1,26,25,24,11,19,20,5,13,6,3,9,21,12,2,10,7,16,17,18,19,22";

            this.GenerateDictionary(TypeDictionary.Number);
            this.GridWords = new List<Word>();
            this.GridWords.Add(new Word("Computador (?): o PC.", "PESSOAL", this.Dictionary, 0));
            this.GridWords.Add(new Word("Revogado; desfeito", "ANULADO", this.Dictionary, 0));
            this.GridWords.Add(new Word("Dizer outra vez.", "REPETIR", this.Dictionary, 0));
            this.GridWords.Add(new Word("Perigosos alvos da curiosidade de crianças dentro de casa.", "TOMADAS", this.Dictionary, 0));
            this.GridWords.Add(new Word("Impreciso.", "INCERTO", this.Dictionary, 0));
            this.GridWords.Add(new Word("Ruptura de vaso sanguíneo (pop.).", "DERRAME", this.Dictionary, 0));
            this.GridWords.Add(new Word("Fechar a camisa.", "ABOTOAR", this.Dictionary, 0));
            this.GridWords.Add(new Word("Cartão de (?): seu roubo deve ser comunicado a administradora.", "CREDITO", this.Dictionary, 2));
            this.GridWords.Add(new Word("Suspende o alentamento materno.", "DESMAMA", this.Dictionary, 3));
            this.GridWords.Add(new Word("Entortar pelo calor.", "EMPENAR", this.Dictionary, 2));
            this.GridWords.Add(new Word("Ave que dá nome ao Sítio de Lobato (Lit. inf.).", "PICAPAU", this.Dictionary, 3));
            this.GridWords.Add(new Word("Parte fixa de portas e janelas.", "BATENTE", this.Dictionary, 2));
            this.GridWords.Add(new Word("Aparelho de apoio para quem tem dificuldade em caminhar.", "ANDADOR", this.Dictionary, 3));
            this.GridWords.Add(new Word("Despretensioso.", "MODESTO", this.Dictionary, 2));
            this.GridWords.Add(new Word("Treinos.", "ENSAIOS", this.Dictionary, 3));
        }

        /// <summary>
        /// Generate the dictionary
        /// </summary>
        private void GenerateDictionary(TypeDictionary type)
        {
            AddItems(this.Alphabet);
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
                AddItemDictionaryModel(letter, position);
                position++;
            }
        }

        private void AddItemDictionaryModel(char letter, int position)
        {
            this.Dictionary.Add(letter.ToString(), this.Model.Split(",")[position]);
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
