using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {
        List<int> mountains = new List<int> { };
        List<int> index = new List<int> { };

        Random rand = new Random();
        // game loop
        for (int i = 0; i < 8; i++)
        {
            mountains.Add(rand.Next(0,10)); // represents the height of one mountain.

        }
        
        for(int i = 0;i < 8; i++)
        {
            for(int j = 1;j < 6; j++)
            {
                if (mountains[i] > mountains[j])
                {

                }
            }
        }   
    }
}