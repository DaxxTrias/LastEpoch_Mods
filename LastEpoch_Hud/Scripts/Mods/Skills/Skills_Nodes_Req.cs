﻿using HarmonyLib;
using Il2Cpp;

namespace LastEpoch_Hud.Scripts.Mods.Skills
{
    internal class Skills_Nodes_Req
    {
        public static bool CanRun()
        {
            if ((Scenes.IsGameScene()) && (!Save_Manager.instance.IsNullOrDestroyed()))
            {
                if (!Save_Manager.instance.data.IsNullOrDestroyed())
                {
                    return Save_Manager.instance.data.Skills.Disable_NodeRequirement;
                }
                else { return false; }
            }
            else { return false; }
        }


        //Need a fix for LastEpoch 1.2
        //[HarmonyPatch(typeof(LocalTreeData), "fulfilledRequirementExists")]
        /*[HarmonyPatch(typeof(LocalTreeData), "fulfilledRequirementExists", new System.Type[] { typeof(LocalTreeData), typeof(GlobalTreeData.TreeData), typeof(GlobalTreeData.NodeData), typeof(GlobalTreeData.TreeData), typeof(GlobalTreeData.NodeData) })]
        public class LocalTreeData_FulfilledRequirementExists
        {
            [HarmonyPrefix]
            //static bool Prefix(LocalTreeData __instance, ref bool __result , GlobalTreeData.TreeData __0, ref GlobalTreeData.NodeData __1, LocalTreeData.TreeData __2, LocalTreeData.NodeData __3)
            static void Prefix()// ref bool __result)
            {
                if (CanRun())
                {
                    __result = true;
                    return false;
                }
                else { return true; }
            }
        }*/
    }
}
