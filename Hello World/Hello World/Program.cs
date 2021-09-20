using System;
using System.Xml;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int iAmount = 5;
            Console.WriteLine("Input " + iAmount + " data types: ");
            string[] sInput = new String[iAmount];
            for (int a = 0; a < iAmount; a++)
            {
                sInput[a] = Console.ReadLine();
            }

            for (int l = 0; l < iAmount; l++)
            {
                sInput[l] = sInput[l].ToLower();
                //split
                char[] cInput = sInput[l].ToCharArray();
                //for loop for every character using .Length
                if (sInput[l] == "true" || sInput[l] == "false")
                {
                    Console.WriteLine("Is a bool");
                }
                else
                {
                    for (int x = 0; x < cInput.Length; x++)
                    {
                        if (cInput.Length > 1)
                        {
                            //for loop to check for every alphabet character

                            for (int y = 0; y < 26; y++)
                            {
                                if (cInput[x] == Alphabet.cHarbet(y))
                                {
                                    Console.WriteLine("Is an string");
                                    goto done;
                                }
                            }

                            //check for numbers
                            for (int n = 0; n < 10; n++)
                            {
                                if (cInput[x] == Numbers.cNumbers(n))
                                {
                                    for (int j = 0; j < cInput.Length; j++)
                                    {
                                        if (cInput[j] == ',' || cInput[j] == '.')
                                        {
                                            Console.WriteLine("It is a float");
                                            goto done;
                                        }
                                    }
                                    Console.WriteLine("It is an integer");
                                }
                            }
                        }
                        else if (cInput[0] == '1' || cInput[0] == '0')
                        {
                            Console.WriteLine("Is a bool and an integer");
                        }
                        else
                        {
                            for (int k = 0; k < 26; k++)
                            {
                                if (cInput[x] == Alphabet.cHarbet(k))
                                {
                                    Console.WriteLine("Is a char");
                                    goto done;
                                }
                            }
                            for (int n = 0; n < 10; n++)
                            {
                                if (cInput[x] == Numbers.cNumbers(n))
                                {
                                    Console.WriteLine("Is an integer between 2-9");
                                    goto done;
                                } 
                            }
                            Console.WriteLine("Unknown char");
                        }
                        done:
                            Array.Clear(cInput, 0, cInput.Length);
                    }
                }
            }
        }
    }
}