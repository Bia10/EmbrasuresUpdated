using HarmonyLib;
using Verse;

namespace EmbrasuresUpdated.Source;

internal abstract class Patch
{
    /// <summary>
    /// Checks if this Patch should be applied now.
    /// </summary>
    /// <returns>Returns true if the Patch should be applied.</returns>
    protected abstract bool ShouldPatchApply();

    /// <summary>
    /// Apply the patch.
    /// </summary>
    protected abstract void ApplyPatch(Harmony? harmony = null);

    /// <summary>
    /// The Description of this patch.
    /// Mainly used for logging.
    /// </summary>
    /// <returns>The Patch Description.</returns>
    protected abstract string PatchDescription();

    /// <summary>
    /// Checks if this Patch needs to be applied, and applies if needed.
    /// </summary>
    public void ApplyPatchIfRequired(Harmony? harmony = null)
    {
        if (ShouldPatchApply())
        {
            Log.Message("EmbrasuresUpdated: Applying Patch ... " + PatchDescription());

            ApplyPatch(harmony);

            Log.Message("EmbrasuresUpdated: Applied Patch! " + PatchDescription());
        }
        else
        {
            Log.Message("EmbrasuresUpdated: Skipping Applying Patch " + PatchDescription());
        }
    }
}