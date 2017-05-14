using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        #region https://www.hackerrank.com/challenges/2d-array?h_r=next-challenge&h_v=zen
        static void Main(String[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            //for (int i = 0; i < 6; i++)
            //{
            //    foreach (int j in arr[i])
            //    {
            //        Console.Write(j + " ");
            //    }
            //}
            int comboTotal, max = 0;
            for (int k = 0; k < 4; k++)
            {
                for (int l = 0; l < 4; l++)
                {
                    comboTotal = arr[k][l] + arr[k][l + 1] + +arr[k][l + 2] + arr[k + 1][l + 1] + arr[k + 2][l] + arr[k + 2][l + 1] + arr[k + 2][l + 2];

                    if (k==0 && l==0)
                    {
                        max = comboTotal;
                    }

                    if (comboTotal > max)
                    {
                        max = comboTotal;
                    }
                }
            }
            Console.WriteLine("");
            Console.Write(max);

            Console.Read();
        }

        #endregion
        
        //static void Main(string[] args)
        //{
        //    public static void test()
        //    {
        //    int b = 0;
        //    }
        //Program pr = new Program();


        #region StringBuilder
        //StringBuilder userString = new StringBuilder("0");
        //for (int i = 1; i < 10000; i++)
        //{
        //    userString.Append(i + " ");
        //}
        //Console.WriteLine(userString);
        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv7
        //string grid = System.IO.File.ReadAllText(@"C:\Users\Kian\Documents\visual studio 2015\Projects\cSahrpLearning\grid.txt");
        //string[] lines = grid.Split('\n');
        //int a =0,b=0,c=0,d=0, multiplication, result=0;
        //string[] numbersString;
        //int[] numbers = new int[20];

        //foreach (string  line in lines)
        //{
        //    numbersString = line.Split(' ');
        //    for (int i = 0; i < numbersString.Length; i++)
        //    {
        //        numbers[i] = int.Parse(numbersString[i]);
        //    }
        //    for (int i = 3; i < numbers.Length; i++)
        //    {
        //        multiplication = numbers[i] * numbers[i - 1] * numbers[i - 2] * numbers[i - 3];
        //        if (multiplication > result)
        //        {
        //            result = multiplication;
        //            a = numbers[i];
        //            b = numbers[i - 1];
        //            c = numbers[i - 2];
        //            d = numbers[i - 3];
        //        }
        //    }
        //}
        //Console.WriteLine("Result: "+result);
        //Console.WriteLine(d+" "+c+" "+b+" "+a);
        ////Console.WriteLine(grid);

        //Console.ReadKey();

        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv6
        //    int k;
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        for (int j = i+1 ; j < 1000; j++)
        //        {
        //            k = 1000 - i - j;
        //            if (j<k && i * i + j * j == k * k)  
        //            {
        //                Console.WriteLine(i + " " + j + " " + k);
        //                goto Found;
        //            }
        //        }
        //    }
        //Found:
        //    Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv5
        //int skv = 0, kvs = 0;
        //for (int i = 1; i < 101; i++)
        //{
        //    skv = skv + i*i;
        //    kvs = kvs + i;
        //}
        //Console.WriteLine(Math.Pow(kvs,2)-skv);
        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv4
        //Console.WriteLine("Mata in texten: ");
        //string text = Console.ReadLine();
        //text = text.ToLower();
        //text = text.Replace(" ", string.Empty);

        //List<char> letters = new List<char>();
        //letters = text.ToList<char>();

        //List<char> reverseLetters = new List<char>();
        //for (int i = letters.Count-1; i >= 0; i--)
        //{
        //    reverseLetters.Add(letters[i]);
        //}

        //bool palindrom = true;
        //for (int i = 0; i < letters.Count-1; i++)
        //{
        //    if (letters[i] != reverseLetters[i])
        //    {
        //        palindrom = false;
        //        break;
        //    } 
        //}
        //if (palindrom) Console.WriteLine("Det är polindrom.");
        //else Console.WriteLine("Det är inte polindrom.");

        ////foreach (char item in reverseLetters)
        ////{
        ////    Console.Write(item+" ");
        ////}
        //Console.ReadKey();

        //Better solution
        //Console.WriteLine("Mata in text: ");

        //string text = Console.ReadLine();
        //string t = text.ToLower();

        //bool Palindrom = true;

        //for (int i = 0; i < t.Length - 1 - i && Palindrom; i++)
        //{
        //    if (t.Substring(i, 1) == t.Substring(t.Length - 1 - i, 1))
        //    {
        //        Console.WriteLine("Ja det är ett palindrom");
        //        break;

        //    }
        //    else Palindrom = false;
        //    Console.WriteLine("Nej det är inget palindrom");
        //}

        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv3
        //List<int> fibList = new List<int>();
        //fibList.Add(1);
        //fibList.Add(1);
        //int lastNumber = 1;
        //int sum = 2;

        //for (int i = 2; lastNumber <= 4000000; i++)
        //{
        //    lastNumber = fibList[i - 1] + fibList[i - 2];
        //    fibList.Add(lastNumber);
        //    sum = sum + lastNumber;
        //}
        //Console.WriteLine(sum);

        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv2
        //List<long> fibList = new List<long>();
        //fibList.Add(1);
        //fibList.Add(1);

        //for (int i = 2; i < 51; i++)
        //{
        //    fibList.Add(fibList[i - 1] + fibList[i - 2]);
        //}
        //foreach (long fibNumber in fibList)
        //{
        //    Console.Write(fibNumber+" ");
        //}
        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/10-nyttiga-ovningar öv1
        //int sum = 0;
        //for (int i = 1; i <= 333; i++)
        //{
        //    sum = sum + 3 * i;
        //}
        //for (int i = 1; i < 200; i++)
        //{
        //    sum = sum + 5 * i;
        //}
        //for (int i = 1; i <= 66; i++)
        //{
        //    sum = sum - 15 * i;
        //}
        //Console.WriteLine(sum);

        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/klasser-en-introduktion öv1&2&3

        //Bil bil1 = new Bil();
        //Console.Write("Vad har bilen för märke? ");
        //bil1.Märke = Console.ReadLine();
        //Console.Write("Vad har den för modell? ");
        //bil1.Modell = int.Parse(Console.ReadLine());
        //Console.WriteLine("Vad har ägaren för födelse datumn? YYMMdd");
        //CultureInfo provider = CultureInfo.InvariantCulture;
        //bil1.Birthday = DateTime.ParseExact(Console.ReadLine(), "yyMMdd", provider);

        //Console.WriteLine("Bil1 är en {0} med modelln {1}.",bil1.Märke,bil1.Modell);
        //Console.WriteLine("{0}s ägare är {1}myndig.", bil1.Slang, (bil1.Myndig ? "" : "inte "));
        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/felhantering-undantag öv1&2
        //bool done = false;
        //int inkomst = 0;
        //int timmar = 0;

        //while (!done)
        //{
        //    Console.Write("Ange din inkomst: ");
        //    try
        //    {
        //        inkomst = int.Parse(Console.ReadLine());
        //        done = true;
        //    }
        //    catch (ArgumentNullException ex)
        //    {
        //        Console.WriteLine("Please make sure you have entered a vlue.");
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Please make sure that your entry is an integer.");
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (OverflowException ex)
        //    {
        //        Console.WriteLine("Your number is too big.");
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //done = false;
        //while (!done)
        //{
        //    try
        //    {
        //        Console.Write("Ange antal timmar: ");
        //        timmar = int.Parse(Console.ReadLine());
        //        done = true;
        //    }
        //    catch (ArgumentNullException ex)
        //    {
        //        Console.WriteLine("Please make sure you have entered a vlue.");
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Please make sure that your entry is an integer.");
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (OverflowException ex)
        //    {
        //        Console.WriteLine("Your number is too big.");
        //        Console.WriteLine(ex.Message);
        //    }

        //}
        //done = false;
        //while (!done)
        //{
        //    try
        //    {
        //        Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
        //        done = true;
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine(ex.Message + " Please enter timmar number bigger than zero.");
        //        done = false;
        //        while (!done)
        //        {
        //            try
        //            {
        //                Console.Write("Ange antal timmar: ");
        //                timmar = int.Parse(Console.ReadLine());
        //                done = true;
        //            }
        //            catch (ArgumentNullException e)
        //            {
        //                Console.WriteLine("Please make sure you have entered a vlue.");
        //                Console.WriteLine(e.Message);
        //            }
        //            catch (FormatException e)
        //            {
        //                Console.WriteLine("Please make sure that your entry is an integer.");
        //                Console.WriteLine(e.Message);
        //            }
        //            catch (OverflowException e)
        //            {
        //                Console.WriteLine("Your number is too big.");
        //                Console.WriteLine(e.Message);
        //            }
        //        }
        //        done = false;
        //    }
        //}

        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/samlingsklasser öv5
        //string text = System.IO.File.ReadAllText(@"C:\Users\Kian\Documents\Visual Studio 2015\Projects\cSahrpLearning\sampleText.txt");


        //text = text.Replace(".", string.Empty);
        //text = text.Replace("?", string.Empty);
        //text = text.Replace(",", string.Empty);
        //text = text.Replace("!", string.Empty);
        //text = text.Replace("\"", string.Empty);
        //text = text.Replace("'", string.Empty);
        //text = text.Replace("(", string.Empty);
        //text = text.Replace(")", string.Empty);
        //text = text.Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ");

        //List<string> listOfWords = new List<string>();
        //listOfWords.AddRange(text.Split(' '));
        //for (int i = 0; i < listOfWords.Count; i++)
        //{
        //    listOfWords[i] = listOfWords[i].Trim(' ');
        //}


        //Dictionary<string, int> countOfWords = new Dictionary<string, int>();
        //foreach (string word in listOfWords)
        //    if (!countOfWords.ContainsKey(word.ToLower()))
        //    {
        //        countOfWords.Add(word.ToLower(), 1);
        //    }
        //    else
        //    {
        //        countOfWords[word.ToLower()]++;
        //    }

        //for (int i = 0; i < countOfWords.Count; i++)
        //{
        //    countOfWords.Values.Max();
        //}

        //foreach (KeyValuePair<string,int> pair in countOfWords.OrderByDescending(key => key.Value))
        //{
        //    Console.WriteLine("{0,-20}{1}", pair.Key, pair.Value);
        //}

        //Console.WriteLine();
        //Console.ReadKey();


        #endregion

        #region http://www.csharpskolan.se/article/samlingsklasser öv4
        //Dictionary<string,byte> deck = new Dictionary<string,byte>();
        //string[] suits = { "c", "d", "h", "s" };
        //string[] number = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};

        //for (int i = 0; i < suits.Length; i++)
        //{
        //    for (int j = 0; j < number.Length; j++)
        //    {
        //        string card = suits[i]+number[j];
        //        deck.Add(card, (byte)(j + 1));
        //    }
        //}

        //Random randomer = new Random();
        //for (int i = 0; i < 1000; i++)
        //{
        //    int card1 = randomer.Next(1, 52);
        //    int card2 = randomer.Next(1, 52);
        //    while (card1==card2)
        //    {
        //        card2 = randomer.Next(1, 52);
        //    }

        //    if (deck.ElementAt(card1).Value == deck.ElementAt(card2).Value)
        //    {
        //        Console.WriteLine(@"PAR:    {0,-10}{1}", deck.ElementAt(card1), deck.ElementAt(card2));
        //    }
        //}
        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/samlingsklasser öv3
        //Console.Write("hur många kort? ");
        //int number = int.Parse(Console.ReadLine());

        //List<string> deck = new List<string>();
        //for (int i = 0; i < number; i++)
        //{
        //    Console.Write("Skriv fram sidan: ");
        //    deck.Add(Console.ReadLine());
        //    Console.Write("Skriv backsidan: ");
        //    deck.Add(Console.ReadLine());
        //}


        //Console.WriteLine("\nInmatade korten slumpmässigt är:");
        //Random randomer = new Random();
        //do
        //{
        //    int card = randomer.Next(0, deck.Count);
        //    if (card%2==0)
        //    {
        //        Console.WriteLine(deck[card]+"\t"+deck[(card+1)]);
        //        deck.Remove(deck[card]);
        //        deck.Remove(deck[card]);
        //    }
        //} while (deck.Count>0);

        //Console.ReadKey();
        #endregion

        #region http://www.csharpskolan.se/article/samlingsklasser öv2
        //double inmatat = 0;
        //List<double> lista = new List<double>();
        //do
        //{
        //    Console.Write("Mata in ett nummer: ");
        //    inmatat = double.Parse(Console.ReadLine());
        //    lista.Add(inmatat);
        //    Console.WriteLine("Summan = " + lista.Sum());
        //} while (inmatat != 0);
        //Console.ReadKey();

        #endregion

        #region http://www.csharpskolan.se/article/samlingsklasser öv1
        //SortedList<int, int> resultat = new SortedList<int, int>();
        //Random randomer = new Random();

        //for (int i = 0; i < 1000; i++)
        //{
        //    int tal = randomer.Next(1, 7);
        //    if (!resultat.ContainsKey(tal))
        //    {
        //        resultat.Add(tal, 0);
        //    }
        //    resultat[tal]++;
        //}
        //foreach (KeyValuePair<int, int> kvp in resultat)
        //{
        //    Console.WriteLine("Nyckel: {0} Värde: {1}",kvp.Key,kvp.Value);
        //}
        //Console.ReadKey();

        #endregion

    }
}

