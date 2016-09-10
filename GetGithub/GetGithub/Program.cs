using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string branch = Console.ReadLine();
                Project project = new Project(branch);
                Console.WriteLine("Start...");
                Parallel.ForEach(project, Execute);
                Console.WriteLine("Done");
            }
        }

        static void Execute(AbstractExecutor executor)
        {
            if (executor != null)
            {
                Console.WriteLine("Getting {0}", executor.Url);
                executor.Execute();
            }
        }
    }
}
