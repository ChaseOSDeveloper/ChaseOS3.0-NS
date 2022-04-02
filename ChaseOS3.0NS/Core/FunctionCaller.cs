using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseOS3._0NS.Core
{
    public class FunctionCaller
    {
        public FunctionCaller()
        {
            
        }
        public void CallFunction(string cmd)
        {
            //Command translates into something that I can use to navigate the arguments easily, and make the code more organized plus arguments within the command itself!
            string[] args = cmd.Split(" ");
            string[] argsTempRam = new string[] { };
            string calledfunction = args[0];
            int index = 0;
            foreach (string arg in args)
            {
                if (index > 0)
                {
                    argsTempRam.Append(arg);
                }
                index++;
            }
            args = new string[] { };
            foreach (string tempArg in argsTempRam)
            {
                args.Append(tempArg);
            }
            argsTempRam = new string[] { };
            //Actual function calling and a bunch of else statements with only one if statement! Funny right?
        }
    }      
}
