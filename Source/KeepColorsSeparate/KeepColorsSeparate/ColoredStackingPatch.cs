using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace KeepColorsSeparate
{
    [HarmonyPatch(typeof(Thing))]
    static class ColoredStackingPatch
    {
        [HarmonyPatch(nameof(Thing.CanStackWith)), HarmonyPostfix]
        static void Thing_CanStackWith_Postfix(ref bool __result, Thing other, Thing __instance)
        {
            if (__result)
            {
                var colorableThis = __instance.TryGetComp<CompColorable>();
                var colorableThat = other.TryGetComp<CompColorable>();
                if (colorableThis != null && colorableThat != null)
                {
                    __result = colorableThis.Color.IndistinguishableFrom(colorableThat.Color);
                }
            }
            return;
        }
    }
}
