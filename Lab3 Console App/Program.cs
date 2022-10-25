using Lab3_Class_Library;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Lab3_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {


            if(args.Length > 0)
            {
                
                if (args[0] == "-lists")
                {
                    Lists();
                }
                else if (args[0] == "-new")
                {
                    New();
                }
                else if (args[0] == "-add")
                {
                    Add();
                }
                else if (args[0] == "-remove")
                {
                    Remove();
                }
                else if (args[0] == "-words")
                {
                    Words();
                }
                else if (args[0] == "-count")
                {
                    Count();
                }
                else if (args[0] == "-practice")
                {
                    Practice();
                }
                else
                {
                    Parameters();
                }
            }
            else
            {
                Parameters();
            }

            void Lists()
            {
                
                string[] lists = WordList.GetLists();
                
                for (int i = 0; i < lists.Length; i++)
                {
                    Console.WriteLine(lists[i]);
                }

            }
            
            void New()
            {
                try
                {
                    string[] languages = new List<string>(args).GetRange(2, args.Length - 2).ToArray();
                    
                    if (languages.Length == 0)
                    {
                        Parameters();
                        return;
                    }

                    WordList newList = new Lab3_Class_Library.WordList(args[1], languages);

                    newList.Save();
                
                    Add();

                }
                catch
                {
                    Parameters();
                }

            }
            
            void Add()
            {
                try
                {
                    WordList listAdd = WordList.LoadList(args[1]);

                    while (true)
                    {
                        string[] translations = new string[listAdd.Languages.Length];

                        for (int i = 0; i < listAdd.Languages.Length; i++)
                        {
                            if (i > 0)
                            {
                                Console.WriteLine($"Add a translation of {translations[0]} in {listAdd.Languages[i]}.");
                                translations[i] = Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine($"Add a new word in {listAdd.Languages[0]}");
                                translations[i] = Console.ReadLine();
                            
                                if (translations[i] == "")
                                {
                                    listAdd.Save();
                                    return;
                                }

                            }
                        }
                        listAdd.Add(translations);

                    }

                }
                catch
                {
                    Parameters();
                }
                
            }

            void Remove()
            {
                
                try
                {
                    
                    List<string> wordsFromArgs = new();
                    
                    for (int i = 3; i < args.Length; i++)
                    {
                        wordsFromArgs.Add(args[i]);
                    }
                    
                    string[] wordsToRemove = wordsFromArgs.ToArray();
                    WordList listRemove = WordList.LoadList(args[1]);
                    if (listRemove.Name == "")
                    {
                        return;
                    }
                    
                    int chosenLanguage = 0;
                    
                    for (int i = 0; i < listRemove.Languages.Length; i++)
                    {
                        if (listRemove.Languages[i].ToLower() == args[2].ToLower())
                        {
                            chosenLanguage = i;
                            break;
                        }
                        else if (i == listRemove.Languages.Length - 1)
                        {
                            Console.WriteLine("No words were found.");
                            return;
                        }
                    }

                    for (int i = 0; i < wordsToRemove.Length; i++)
                    {
                        listRemove.Remove(chosenLanguage, wordsToRemove[i]);
                        Console.WriteLine($"{wordsToRemove[i]} removed.");
                    }

                    listRemove.Save();

                }
                catch
                {
                    Console.WriteLine("No words were removed.");
                }
            }

            void Words(int sortingLangugage = 0)
            {
                try
                {
                    WordList sortedList = WordList.LoadList(args[1]);
                    sortedList.List(sortingLangugage, (x) => Console.WriteLine(String.Join(" ", x)));

                }
                catch
                {
                    Parameters();
                }
            }

            void Count()
            {
                try
                {
                    WordList countedList = WordList.LoadList(args[1]);
                    Console.WriteLine(countedList.Count());

                }
                catch
                {

                }
            }

            void Practice()
            {
                try
                {
                    WordList practiceList = WordList.LoadList(args[1]);
                    int totalAnswers = 0;
                    int correctAnswers = 0;
                    while (true)
                    {
                        Word practiceWord = practiceList.GetWordToPractice();
                        Console.WriteLine($"{practiceWord.Translations[practiceWord.FromLanguage]} in {practiceList.Languages[practiceWord.ToLanguage]}:");
                        string answer = Console.ReadLine();
                
                        if (answer == "")
                        {
                            Console.WriteLine($"{totalAnswers} words were practiced, with {correctAnswers} correct answers.");
                            return;
                        }
                        else if (answer.ToLower() == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
                        {
                            totalAnswers++;
                            correctAnswers++;
                            Console.WriteLine("The answer is correct.");
                        }
                        else
                        {
                            totalAnswers++;
                            Console.WriteLine("The answer is incorrect.");
                        }

                    }

                }
                catch
                {
                    Parameters();
                }
            }

            void Parameters()
            {
                Console.WriteLine($"Use any of the following parameters:{Environment.NewLine}" +
                        $"-lists{Environment.NewLine}" +
                        $"-new <list name> <language 1> <language 2> .. <langauge n>{Environment.NewLine}" +
                        $"-add <list name>{Environment.NewLine}" +
                        $"-remove <list name> <language> <word 1> <word 2> .. <word n>{Environment.NewLine}" +
                        $"-words <listname> <sortByLanguage>{Environment.NewLine}" +
                        $"-count <listname>{Environment.NewLine}" +
                        $"-practice <listname>{Environment.NewLine}" +
                        $"{Environment.NewLine}");
            }
        }
    }
}