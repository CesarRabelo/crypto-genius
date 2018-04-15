using System;

namespace Crypto.Genius.Service.Models
{
    [Serializable]
    public class Letter
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool KeyVisible { get; set; }        
    }
}