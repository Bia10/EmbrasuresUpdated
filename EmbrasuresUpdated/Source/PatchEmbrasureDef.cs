using EmbrasuresUpdated.Source.Settings;
using HarmonyLib;
using Verse;

namespace EmbrasuresUpdated.Source;

internal class PatchEmbrasureDef : Patch
{
    protected override void ApplyPatch(Harmony? harmony = null)
    {
        var embrasureDef = ThingDef.Named("ED_Embrasure");

        if (ModEmbrasures.Settings != null)
        {
            embrasureDef.fillPercent = ModEmbrasures.Settings.FillPercent / 100f;
            embrasureDef.costStuffCount = ModEmbrasures.Settings.StuffCost;
        }
    }

    protected override string PatchDescription()
    {
        return "Embrasures";
    }

    protected override bool ShouldPatchApply()
    {
        return true;
    }
}