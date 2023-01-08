using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue02
{
    internal class ChatBot
    {

        string input = "";
        string currentLanguage = "en";
        string lastAnswer = "";

        List<string> smallTalk = new List<string>();

        Dictionary<string, string> languages = new Dictionary<string, string>()
        {
            {"en", "English"},
            {"de", "Deutsch"}
        };

        Dictionary<string, string> answers = new Dictionary<string, string>();
        Dictionary<string, string> commands = new Dictionary<string, string>();

        Random rnd = new Random();

        /// <summary>
        /// Param <param>language</param><para />
        /// Availibel languages
        /// <list type="bullet">
        /// <item>
        /// <description>'en' for English</description>
        /// </item>
        /// <item>
        /// <description>'de' for Deutsch</description>
        /// </item>
        /// </list>
        /// </summary>
        public ChatBot(string language = "en")
        {
            this.currentLanguage = language;
        }

        // main loop for the bot
        public void StartChat()
        {
            loadTextFiles();
            Console.WriteLine(this.commands["startingChatBot"]);
            Console.WriteLine(this.commands["startedChatBot"]);
            Console.WriteLine("Chatty - " + this.commands["changeLanguage"]);
            Console.Write(" - ");
            this.input = readInput();
            while (input != "bye")
            {
                if (this.input.Length > 0)
                {
                    answerToInput();
                }
                Console.Write(" - ");
                this.input = readInput();
            }
        }

        string readInput()
        {
            return Console.ReadLine().ToLower().Replace('.', ' ').Replace(',', ' ').Replace('-', ' ');
        }

        void answerToInput()
        {
            string[] parts = input.Split(' ');
            foreach (string part in parts)
            {
                if (answers.ContainsKey(part))
                {
                    if(part == this.lastAnswer)
                    {
                        break;
                    }
                    Console.WriteLine("Chatty - " +answers[part]);
                    this.lastAnswer = part;
                    return;
                }
                else if(part == this.commands["#language"])
                {
                    changeLanguage();
                    return;
                }
            }
            int randdomElement = rnd.Next(smallTalk.Count);
            if(randdomElement.ToString() == this.lastAnswer)
            {
                int counter = 0;
                do
                {
                    randdomElement = rnd.Next(smallTalk.Count);
                    counter++;
                } while (randdomElement.ToString() == this.lastAnswer && counter <3);
            }
            this.lastAnswer = randdomElement.ToString();
            Console.WriteLine("Chatty - " + smallTalk[randdomElement]);
        }

        string createPathToFile(string file)
        {
            return Directory.GetCurrentDirectory().Split("bin")[0] + @"text_files\" + this.currentLanguage + @"\" + file;
        }

        void loadCommandsFromFile(ref Dictionary<string,string> output,string path)
        {
            output = new Dictionary<string, string>();
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                try
                {
                    string[] parts = line.Split(':');
                    output.Add(parts[0], parts[1]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The is a error in the language file \'" + path + "\'. The line starting with \'" + line.Split(':')[0] + "\' cann't be loaded!");
                }
            }
        }

        void loadLinesFromFile(ref List<string> output, string path)
        {
            output = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                output.Add(line);
            }
        }

        void loadTextFiles()
        {
            loadCommandsFromFile(ref this.answers, createPathToFile("answers.txt"));
            loadCommandsFromFile(ref this.commands, createPathToFile("commands.txt"));
            loadLinesFromFile(ref this.smallTalk, createPathToFile("small_talk.txt"));
        }

        void changeLanguage()
        {
            Console.WriteLine("Chatty - " + this.commands["changeLanguageText1"]);
            foreach (KeyValuePair<string, string> language in languages)
            {
                Console.WriteLine("\t" + language.Key + " - " + language.Value);
            }
            Console.WriteLine("Chatty - " + this.commands["changeLanguageText2"]);
            Console.Write(" - ");
            string input = readInput();
            if (languages.ContainsKey(input))
            {
                this.currentLanguage = input;
            }
            else
            {
                this.currentLanguage = "en";
            }
            loadTextFiles();
            Console.WriteLine("Chatty - " + this.commands["languageChanged"]);
        }
    }
}
