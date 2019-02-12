using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] Inputs = { "Boat", "House", "Cat", "River", "Cupboard" };

            {
                Console.WriteLine("The plural forms are:");
                foreach (var input in Inputs)
                {
                    Console.WriteLine(input + "s");
                }
                Inputs[1] = "Homes";
                Console.WriteLine("After replacing:");
                foreach (var input in Inputs)
                {
                    Console.WriteLine(input);
                }
                Array.Resize(ref Inputs, Inputs.Length + 1);
                Inputs[5] = "Friends";
                Console.WriteLine("Length of the List is: \t" + Inputs.Length);
                Console.WriteLine("After adding, the list is here:");
                foreach (var input in Inputs)
                {
                    Console.WriteLine(input);
                }
                int i;
                for (i = 0; i < Inputs.Length; i++)
                {
                    if (Inputs[i].Length == 7)
                    {
                        Console.WriteLine("Words containing 7 characters are:" + Inputs[i]);
                    }
                }
                Console.WriteLine("Word present on the 3rd position is:\t" +Inputs[2]);

                Array.Sort(Inputs);
                Console.WriteLine("The sorted list in ascending order is :");
                for (i = 0; i < Inputs.Length; i++)
                {
                    Console.WriteLine(Inputs[i]);
                }

                Array.Reverse(Inputs);
                Console.WriteLine("The list in reverse order");
                for (i = 0; i < Inputs.Length; i++)
                {
                    Console.WriteLine(Inputs[i]);
                }
            }
        }
        }
    }
    

