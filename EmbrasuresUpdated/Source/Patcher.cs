using System.Collections.Generic;
using HarmonyLib;
using Verse;

namespace EmbrasuresUpdated.Source;

[StaticConstructorOnStartup]
internal class Patcher
{
    static Patcher()
    {
        Log.Message("EmbrasuresUpdated: Starting ...");

        // Create List of Patches
        List<Patch> patches = new()
        {
            new PatchEmbrasureDef()
        };

        // Create Harmony Instance
        var harmony = new Harmony("EmbrasuresUpdated");

        // Iterate Patches
        patches.ForEach(patch => patch.ApplyPatchIfRequired(harmony));

        Log.Message("EmbrasuresUpdated: Complete.");
    }

    /// <summary>
    /// Debug Logging Helper
    /// </summary>
    /// <param name="objectToTest"></param>
    /// <param name="name"></param>
    /// <param name="logSuccess"></param>
    public static void LogNull(object? objectToTest, string name, bool logSuccess = false)
    {
        if (objectToTest == null)
        {
            Log.Error(name + " Is NULL.");
        }
        else if (logSuccess)
        {
            Log.Message(name + " Is Not NULL.");
        }
    }
}