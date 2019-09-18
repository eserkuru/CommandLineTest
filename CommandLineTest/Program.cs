using System;
using System.Diagnostics;

namespace CommandLineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(@"cd\");
            cmd.StandardInput.WriteLine(@"mkdir SolutionBuilder");
            cmd.StandardInput.WriteLine(@"cd .\SolutionBuilder");
            cmd.StandardInput.WriteLine(@"mkdir test2");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.ReadLine();
        }
    }
}
