using EloBuddy;
using EloBuddy.SDK;

namespace $safeprojectname$
{
    internal class LaneClear
    {
        public static void LaneClearExecute()
        {
            var QLaneMonster = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.ServerPosition, Spells.Q.Range);
            var WQLaneMonster = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.ServerPosition, Spells.W.Range + Spells.Q.Range);
            var ELaneMonster = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.ServerPosition, Spells.E.Range);
        }
    }
}

