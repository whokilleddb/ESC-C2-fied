using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        EvilCommands evilCmds = new EvilCommands();

        if (args.Length == 0)
        {
            evilCmds.GetHelp();
            return;
        }

        // Example: Process the arguments
        foreach (string arg in args)
        {
            evilCmds.RunSQLConsole(arg);
        }
    }
}