﻿namespace WinToolbox.Commands;

public class Version : Command
{
    public Version() : base("version", "version") { }

    public override void Execute(string[] args)
    {
        Console.WriteLine($"WinToolbox v{Program.Version}");
    }
}