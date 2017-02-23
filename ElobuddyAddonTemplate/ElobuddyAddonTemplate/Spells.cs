using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace $safeprojectname$
{
    internal static class Spells
    {
        public static Spell.Skillshot Q;
        public static Spell.Skillshot W;
        public static Spell.Active E;
        public static Spell.Targeted R;
        public static void InitializeSpell()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 0, SkillShotType.Linear);
            W = new Spell.Skillshot(SpellSlot.W, 0, SkillShotType.Circular);
            E = new Spell.Active(SpellSlot.E, 0);
            R = new Spell.Targeted(SpellSlot.R, 0);
        }
    }
}

