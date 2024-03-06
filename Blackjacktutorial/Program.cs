using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace Blackjacktutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
        }
    }
}
