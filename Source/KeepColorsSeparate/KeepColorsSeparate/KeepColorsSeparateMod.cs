using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace KeepColorsSeparate
{
    public class KeepColorsSeparateMod: Mod 
    {
        public KeepColorsSeparateMod(ModContentPack content): base(content)
        {
            var harmony = new Harmony("PeteTimesSix.KeepColorsSeparate");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
