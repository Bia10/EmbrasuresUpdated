using UnityEngine;
using Verse;

namespace EmbrasuresUpdated.Source.Settings;

internal class ModSettingsEmbrasures : ModSettings
{
    private bool _changesEnabled;

    public int FillPercent = 75;
    public int StuffCost = 15;

    // HP, Work, Flamability?
    // Int for Graphics Enum?

    public override void ExposeData()
    {
        base.ExposeData();

        Scribe_Values.Look(ref FillPercent, "FillPercent", 75);
        Scribe_Values.Look(ref StuffCost, "StuffCost", 15);
        Scribe_Values.Look(ref _changesEnabled, "ChangesEnabled", false);
    }

    public void DoSettingsWindowContents(Rect canvas)
    {
        var listingStandard = new Listing_Standard
        {
            ColumnWidth = 250f
        };

        listingStandard.Begin(canvas);
        //listing_Standard.set_ColumnWidth(rect.get_width() - 4f);

        listingStandard.Label("System Enabled.");
        listingStandard.Gap(12f);
        listingStandard.CheckboxLabeled("Enabled", ref _changesEnabled);

        listingStandard.Label("Setting will only apply after a Game Restart.");
        listingStandard.Gap(12f);

        listingStandard.GapLine(12f);
        listingStandard.Label("Fill Percent: " + FillPercent + "%");
        FillPercent = (int)(100 * listingStandard.Slider(FillPercent / 100f, 0.01f, 0.99f));

        listingStandard.Label("Sandbags are 65%");

        listingStandard.GapLine(12f);
        listingStandard.Label("Stuff Cost: " + StuffCost);
        listingStandard.IntAdjuster(ref StuffCost, 1, 1);
        listingStandard.Label("Wall is 5 stuff");

        listingStandard.End();
    }
}