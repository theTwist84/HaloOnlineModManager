﻿using System;
using getArgs;

namespace HaloOnlineModManager
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                getArgs.Program.Help();
            }
            else if (args[0].Contains("/") || args[0].Contains("-") || args[0].Contains("--"))
            {
                if (args.Length < 1)
                    return;
                else if (args[0].Contains("b") || args[0].Contains("backup"))
                {
                    if (args.Length < 2)
                    return;
                    if (args.Length == 3)
                        getArgs.Program.Backup(args[1], args[2]);
                    else
                        getArgs.Program.Backup(args[1], null);
                }
                else if (args[0].Contains("r") || args[0].Contains("restore"))
                {
                    if (args.Length < 2)
                        return;
                    if (args.Length == 3) 
                        getArgs.Program.Restore(args[1], args[2]);
                    else
                        getArgs.Program.Restore(args[1], null);
                }
                else if (args[0].Contains("p") || args[0].Contains("patch"))
                {
                    if (args.Length < 4)
                        return;
                    getArgs.Program.Patch(args[1], args[2], args[3]);
                }
                else if (args[0].Contains("z") || args[0].Contains("zip"))
                {
                    if (args.Length < 2)
                        return;
                    getArgs.Program.Zip(args[1]);
                }
                else if (args[0].Contains("d") || args[0].Contains("download"))
                {
                    if (args.Length < 3 && args[2].Contains("*.zip"))
                        return;
                    getArgs.Program.Download(args[1], args[2]);
                }
                else if (args[0].Contains("?") || args[0].Contains("h") || args[0].Contains("help"))
                {
                    getArgs.Program.Help();
                }
                else
                {
                    if (args.Length < 2)
                        return;
                    getArgs.Program.List(args[0], args[1]);
                }
            }
        }
    }
}