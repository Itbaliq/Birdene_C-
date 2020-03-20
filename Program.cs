using System;
using System.Linq;
using System.Collections.Generic;

namespace _1_2_Csh
{   
    class Besh
    {
        private readonly string _opening = "([{";
        private readonly string _closing = ")]}";

        private bool _cantBeBalanced;

        private Stack<int> _opened = new Stack<int>();

        public bool Balanced => !_cantBeBalanced && !_opened.Any();

        public void Put(char ch)
        {
            if (_cantBeBalanced) return;

            int index = _opening.IndexOf(ch);

            if (index != -1)
            {
                _opened.Push(index);
                return;
            }

            index = _closing.IndexOf(ch);

            if (index != -1)
            {
                if (!_opened.Any() || _opened.Peek() != index)
                {
                    _cantBeBalanced = true;
                    _opened.Clear();
                    _opened.TrimExcess();
                    return;
                }

                _opened.Pop();
                return;
            }
        }
        public void Bech()
        {
            Console.WriteLine("Enter a set of brackets :");
            var s = Console.ReadLine();
            var checker = new Besh();

            foreach (var ch in s)
                checker.Put(ch);

            if (checker.Balanced == true)
            {
                Console.WriteLine("Everything is right");
            }
            else Console.WriteLine("Homie,you made a mistake");

            
        }
    }
    class TFactorial
    {
        public void Get()
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);

        }
    };
    class Eqi
    {
       

        public  void Suz()
            {
            Console.WriteLine("\nEnter suzder:");
            string[] str = Console.ReadLine().ToLower().Split(' ');
            int n = 2;
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].Trim(' ', '.', ',', '?', '!', ':', ';');
            }
            var val = str.Where(x => str.Count(z => z == x) < n).Distinct();
            Console.WriteLine(" \nResulte:");
            Console.WriteLine(string.Join(" ", val));
        }

    }
    class Smsh
    {
        

        public  void Sort()
        {
            Console.WriteLine("\nEnter the size of array:");
           int size = Convert.ToInt32(Console.ReadLine());
            int var, i, j;
            int[] array = new int[size];
            Random rand = new Random();
            for (i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100, 100);
            for (i = 0; i < size - 1; ++i)
            {
                for (j = 0; j < size - 1; ++j)
                {
                    if (array[j + 1] < array[j])
                    {
                        var = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = var;
                    }
                }
            }
            Console.WriteLine("\nSorted array:");
            for (i = 0; i < size; i++)
                Console.WriteLine(array[i]);

        }
        public void Search()
        {
            int smnm=0 ,bul,i;
            Console.WriteLine("\nEnter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the required value:");
            bul = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Random rand = new Random();
            for (i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100,100);
            Console.WriteLine("\nThe elements of entered array:");
            for (i = 0; i < size; i++)
                Console.WriteLine(array[i]);
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
               var middle = array.Length/ 2;
                if (bul == array[middle])
                {
                    smnm++;
                }
                if (bul == array[right])
                {
                    right -=  1;
                    smnm++;

                }
                if (bul != array[right])
                {
                    
                    right -=  1;
                }
                if (right == middle + 1)
                {
                    break;
                }

                if (bul == array[left])
                {
                    left += 1;
                    smnm++;
                    if (left == middle - 1) {
                        break;
                    }
                }
                if (bul != array[left])
                {
                    
                    left += 1;
                }
                if (left == middle - 1)
                {
                    break;
                }

            }
            Console.WriteLine("\nMa boy, did you find anything?");
            if (smnm != 0)
            {
                Console.WriteLine("Yes,masa \n");
                Console.WriteLine("\nNumber of repetitions:{0}", smnm);
            }
            else
                Console.WriteLine("No,masa \n");

        }

    }
    class Program
    {   
        static void Main()
        {
            int k;
           
            while (true)
            {
                Smsh sh = new Smsh();
                Eqi suz = new Eqi();
                TFactorial fuc = new TFactorial();
                Besh be = new Besh();


                Console.WriteLine("The list of functions:\n0-Quit\n1-Start a programm\n2-Search a value\n3-Find unique words\n4-Find factorial\n5-Detect the correct sequence of brackets\nEnter your choice:");
                k = Convert.ToInt32(Console.ReadLine());

                if( k == 0)
                {
                    break;
                }
                if (k == 1 )
                {
                    sh.Sort();
                }
                if (k ==2)
                {
                    sh.Search();
                }
                if (k == 3)
                {
                    suz.Suz();
                }
                if (k == 4)
                {
                    fuc.Get();
                }
                if (k == 5)
                {
                    be.Bech();
                }
                else
                    Console.WriteLine("\nTry again\n");
            }




        }
    }

}
