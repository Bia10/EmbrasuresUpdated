using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace EmbrasuresUpdated.Source;

[StaticConstructorOnStartup]
internal class Patcher
{
    static Patcher()
    {
        var assemblyName = Assembly.GetExecutingAssembly().GetName();
        var modName = $"[{assemblyName.Name} v{assemblyName.Version}]:";

        Log.Message($"{modName} Starting ...");

        // Create List of Patches
        List<Patch> patches = new()
        {
            new PatchEmbrasureDef()
        };

        // Create Harmony Instance
        var harmony = new Harmony("EmbrasuresUpdated");

        // Iterate Patches
        patches.ForEach(patch => patch.ApplyPatchIfRequired(harmony));

        Log.Message($"{modName} Complete.");
    }
}