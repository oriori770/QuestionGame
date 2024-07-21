using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuestionGame.Mode
{
    public class Game
    {
        XmlDocument xmlDocument;
        public Game(XmlDocument xmlDocument ) 
        {
            this.xmlDocument = xmlDocument;
            //StartGame();
        }
        public void StartGame()
        {
        }
    }
}
