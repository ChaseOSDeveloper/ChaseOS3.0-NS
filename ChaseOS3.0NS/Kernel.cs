using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using ChaseOS3._0NS.Core;
namespace ChaseOS3._0NS
{
    public class Kernel : Sys.Kernel
    {
        public FunctionCaller commandCaller = new FunctionCaller();
        public static FunctionsList kernelFunctionList = new FunctionsList();
        protected override void BeforeRun()
        {
            Console.WriteLine("Welcome to ChaseOS 3.0 NS (New System)");
        }
        protected override void Run()
        {
            while (true)
            {
                Console.Write("ChaseOS3.0 Beta> ");
                commandCaller.CallFunction(Console.ReadLine());
            }
        }
    }
}
