// using statements allow me access to the classes in the stated namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.AdHoc_Demo;
using CardGame.GameElements; // To have acces to my various collection-class demos

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // comment or un-comment the following line to see/hide the demos
            // RunDemos();

            Program myApp = new Program();
            myApp.RunCardDemo();
        }

        public void RunCardDemo()
        {
            DeckOfCards myDeck = new DeckOfCards();
            myDeck.Shuffle();
            DisplayCards(myDeck);
            // uh-oh - not so secure.....
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            Console.WriteLine("There are {0} cards in the deck", myDeck.Cards.Count);

            // this won't compile...
            // myDeck.Cards = new List<Card>();
        }

        private static void DisplayCards(DeckOfCards myDeck)
        {
            // Just display all the cards
            foreach (Card item in myDeck.Cards)
                Console.WriteLine("{0} of {1}", item.Face, item.Suit);
        }
        static void RunDemos()
        {
            // Run some of the demos
            ArrayDemo demo1 = new ArrayDemo();
            demo1.Run();
            ListDemo demo2 = new ListDemo();
            demo2.Run();
            QueueDemo demo3 = new QueueDemo();
            demo3.Run();
            StackDemo demo4 = new StackDemo();
            demo4.Run();
        }
    }
}



















// LOGs....
// At the end of this topic, you should be able to
// TODO: 1) List the different kinds of collections we can use in C# 4.0 or higher
// NOTE: 1a) http://stackoverflow.com/questions/247621/what-are-the-correct-version-numbers-for-c
// TODO: 2) Identify which kind of collection type is supported directly by the C# language
// TODO: 3) Compare and contrast the main characteristics of Arrays, Lists, Queues, Stacks, and Dictionaries
// TODO: 4) Explain what is meant by the term "Generics" and how it applies to the various collection classes
// TODO: 5) Create samples that illustrate the various kinds of collections
// NOTE: 5a) Array - 
// NOTE: 5b) List - 
// NOTE: 5c) Queue -
// NOTE: 5d) Stack - deck of cards (pop from top of stack, discard pile is empty stack that we push from)
// NOTE: 5e) Shuffle - take a deck of cards and shuffle them
// NOTE: 5f) Sort - take a deck of cards and sort them, first by suit, then by card face -- a) OrderBy extension method, b) LINQ to Objects query
// NOTE: 5g) Dictionary -


// ) Abstract Classes
// ) Interfaces
// ) Extension Methods
