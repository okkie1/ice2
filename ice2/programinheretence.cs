using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ice2
{
    class programinheretence : theprogramabstract
    {
        public string gameChoice = " ";

        public string getgameChoice()
        {
            return gameChoice;
        }

        public String AddgameChoice()
        {
            this.gameChoice = " ";
            return this.gameChoice;
        }
    }
}
