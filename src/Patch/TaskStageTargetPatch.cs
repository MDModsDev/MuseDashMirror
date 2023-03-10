using Assets.Scripts.GameCore.HostComponent;

namespace MuseDashMirror.Patch;

[HarmonyPatch(typeof(TaskStageTarget), "AddScore")]
internal static class TaskStageTargetPatch
{
    private static void Postfix() => BattleComponent.AddScoreEventInvoke();
}