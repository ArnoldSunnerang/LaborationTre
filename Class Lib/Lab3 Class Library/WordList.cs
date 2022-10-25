using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Lab3_Class_Library
{
    public class WordList
    {
        private List<Word> wordList;

        public string Name { get; }
        public string[] Languages { get; }
        public WordList (string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            wordList = new List<Word>();
        }
        public static string[] GetLists()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Labb3");
            Directory.CreateDirectory(folderPath);
            
            string[] listsGot = Directory.EnumerateFiles(folderPath).ToArray();
            List<string> fileNames = new List<string>();
            try
            {

                for (int i = 0; i < listsGot.Length; i++)
                {
                    string[] slashSplit = listsGot[i].Split('\\');
                    string[] dotSplit = slashSplit[slashSplit.Length - 1].Split('.');

                    if (dotSplit[1] == "dat")
                    {
                        fileNames.Add(dotSplit[0]);
                    }
                }
                
                return fileNames.ToArray();

            }
            catch
            {
                return listsGot;
            }
                


        }

        public static WordList LoadList(string name)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Labb3");
            string fileName = name + ".dat";
            string filePath = Path.Combine(folderPath, fileName);
            Directory.CreateDirectory(folderPath);
            
            try
            {
                StreamReader loadFile = new StreamReader(filePath);
                WordList fetchedList = new WordList(name, loadFile.ReadLine().Split(";"));
            
            
                if (File.Exists(filePath))
                {
                    try
                    {
                        while (!loadFile.EndOfStream)
                        {
                            fetchedList.Add(loadFile.ReadLine().Split(";"));
                        }
                    
                        loadFile.Close();
                    }
                    catch
                    {
                        loadFile.Close();

                    }
                }


                loadFile.Close();
                return fetchedList;

            }
            catch
            {
                Console.WriteLine("No list with that name could be found.");
                WordList unfetchedList = new WordList("");
                return unfetchedList;
            }


        }

        public void Save()
        {
            string folderName = "Labb3";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), folderName);
            string fileName = $"{Name}.dat";
            string filePath = Path.Combine(folderPath, fileName);

            Directory.CreateDirectory(folderPath);
            
            
            try
            {
                var createFile = File.CreateText(filePath);
                createFile.Close();
                StreamWriter saveFile = new StreamWriter(filePath);
                saveFile.WriteLine(String.Join(";", Languages));
                
                if(wordList != null)
                {
                    foreach (Word w in wordList)
                    {
                        string translation = String.Join(";", w.Translations);
                        saveFile.WriteLine(translation);
                    }

                }
                Console.WriteLine("List saved.");
                saveFile.Close();
            }
            catch
            {
                Console.WriteLine("List could not be saved.");
            }
            


        }

        public void Add(params string[] translations)
        {
            Word newWord = new Word(translations);
            this.wordList.Add(newWord);
        }

        public bool Remove(int translation, string word)
        {
            bool foundAndRemoved = false;

            for (int i = 0; i < wordList.Count(); i++)
            {
                if (wordList[i].Translations[translation].ToLower() == word.ToLower())
                {
                    foundAndRemoved = true;
                    wordList.RemoveAt(i);
                    
                }
            }

            return foundAndRemoved;
        }

        public int Count()
        {
            return wordList.Count();
        }

        public void List(int sortByTranslation, Action<string[]> showTranslation)
        {
            try
            {
                wordList.Sort((x, y) => x.Translations[sortByTranslation].CompareTo(y.Translations[sortByTranslation]));
            }
            catch
            {
                
            }
            
            foreach(Word w in wordList)
            {
                showTranslation(w.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            
            Random rnd = new Random();
            int randomWord = rnd.Next(0, wordList.Count());
            int randomFromLanguage = rnd.Next(0, Languages.Length);
            int randomToLanguage = rnd.Next(0, Languages.Length);

            if (Languages.Length > 1)
            {
                while (randomFromLanguage == randomToLanguage)
                {
                    randomToLanguage = rnd.Next(0, Languages.Length);
                }
            }
            
            try
            {
                Word practiceWord = new Word(randomFromLanguage, randomToLanguage, wordList[randomWord].Translations);
                return practiceWord;
            }
            catch
            {
                string[] emptyTranslation = new string[] { "" };
                Word nullWord = new Word(0, 0, emptyTranslation);
                return nullWord;
            }

            


            

        }

    }
}
