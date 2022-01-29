
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
namespace Kernel { 


    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun() {
            Console.Clear();
           Console.WriteLine("Loaded into Boot");
            openFunnix.os.Shell.main();
        }

        protected override void Run(){}
    }
}
