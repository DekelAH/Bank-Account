using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineUI startProcess = new EngineUI();

            startProcess.Intro();
            startProcess.Registration();
            startProcess.Menu();

            
        }
    }
}
