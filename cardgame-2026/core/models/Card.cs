using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame.core.models
{
    // Represents a generic card
    public abstract class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string name, string suit, int value)
        {
            Name = name;
            Suit = suit;
            Value = value;
        }

        public override string ToString() => $"{Name} of {Suit} (Value: {Value})";
    }
}