using System;
namespace SA52Paper
{
    public static class SectionA
    {
        public static int GetIntFromCharDigit(char charDigit)
        {
            return int.Parse(charDigit.ToString());
        }


        public static string InputISBNForQuery()
            {
                string queryISBN;
                while (true)
                {
                    queryISBN = Console.ReadLine();
                    if (queryISBN.Length == 13)
                    {
                        if (queryISBN.Contains("?"))
                        {
                            if (!queryISBN.EndsWith("?"))
                            {
                                int n = queryISBN.Where(x => x == '?').Count();
                                if (n == 1)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Only one ?");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Don't end with ?");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Have to contain one ?");
                        }
                    }
                    else
                    {
                        Console.WriteLine("need 13 digits");
                    }
                    Console.WriteLine("Please enter correct string.");
                }
                return queryISBN;
            }

            public static int GetMissingIndex(string queryISBN)
            {
                int missingIndex = queryISBN.IndexOf("?");
                return missingIndex;
            }

            public static int GetOthersWeightedSum(string queryISBN)
            {
                int weightedSum = 0;
                for (int i = 0; i < queryISBN.Length - 1; i++)
                {
                    int weight = 3;
                    if (i % 2 == 0)
                    {
                        weight = 1;
                    }
                    char c = queryISBN[i];
                    int digit;
                    bool success = int.TryParse(c.ToString(), out digit);
                    if (success)
                    {
                        weightedSum += (digit * weight);
                    }
                    else
                    {
                        Console.WriteLine($"index of {i} is {c}");
                    }
                }
                return weightedSum;
            }

            public static int FindMissingDigit(int othersWeightedSum, int missingIndex, int checkDigit)
            {
                int weight = 3;
                if (missingIndex % 2 == 0)
                {
                    weight = 1;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (((weight * i + othersWeightedSum) % 10) + checkDigit == 10)
                    {
                        return i;
                    }
                }
                return -1;
            }
        
    }
}

