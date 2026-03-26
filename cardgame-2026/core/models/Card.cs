using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame.core.models
{

    public struct CardAttributes
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public CardAttributes(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }
    }

    // Represents a generic card
    public abstract class Card
    {
        public string Name { get; set; }
        public CardAttributes Attributes { get; set; }

        public Card(string name, CardAttributes attributes)
        {
            Name = name;
            Attributes = attributes;
        }

        public override string ToString() =>
            $"{Name} of {Attributes.Suit} (Value: {Attributes.Value})";
    }

}