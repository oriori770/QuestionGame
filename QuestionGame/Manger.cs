using QuestionGame.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuestionGame
{
    public class Manger
    {
        public Manger() 
        {
            Start();
        }
        public void Start()
        {
            XmlDocument xmlDoc = ReadDoc("Data/QuestionsAndAnswers.xml");
            AddQuestions addQuestions = new AddQuestions(xmlDoc);
            Game game = new Game(xmlDoc);
            int option = GetUserMenuChoice();

            switch (option)
            {
                case 1:
                    addQuestions.StartAddQuestions();
                    break;
                case 2:
                    game.StartGame();
                    break;
            }
        }
        public int GetUserMenuChoice()
        {
            // show user options
            var message = "1. Create questions \n2. Answer Questions";
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine()!);
        }

        public XmlDocument ReadDoc(string path)
        {
            // ? read from file
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            return doc;
        }

    }
}
