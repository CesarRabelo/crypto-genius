using System;
namespace CryptoGeniusWebApp.Models
{
    [Serializable]
    public class Letter
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool KeyVisible { get; set; }        
    }
}
