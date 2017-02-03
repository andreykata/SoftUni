﻿using System;
class LettersSum
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];

            switch (letter)
            {
                case 'a': sum = sum + 1;
                    break;
                case 'e': sum = sum + 2;
                    break;
                case 'i': sum = sum + 3;
                    break;
                case 'o': sum += 4; // sum = sum + 4;
                    break;
                case 'u': sum += 5;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(sum);
    }
}