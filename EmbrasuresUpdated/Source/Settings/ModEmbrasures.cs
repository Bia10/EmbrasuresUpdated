using UnityEngine;
using Verse;

namespace EmbrasuresUpdated.Source.Settings;

internal class ModEmbrasures : Mod
{
    public static ModSettingsEmbrasures? Settings;

    public ModEmbrasures(ModContentPack content) : base(content)
    {
        Settings = GetSettings<ModSettingsEmbrasures>();
    }

    public override string SettingsCategory()
    {
        return "ED-Embrasures";
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        Settings?.DoSettingsWindowContents(inRect);
    }
}