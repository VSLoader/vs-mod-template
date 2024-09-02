using System;
using GMSL;

namespace samplemod;

public class Mod : GMSLMod
{
    // Runs when patching the game when changes are detected.
    public override void Patch()
    {
        Console.WriteLine($"[sampleMod]: Running Patch!");
    }

    // Runs before every startup.
    public override void Start()
    {
        Console.WriteLine($"[sampleMod]: Running Start!");
    }
}
