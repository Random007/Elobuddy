using EloBuddy;
using EloBuddy.SDK.Rendering;
using EloBuddy.SDK.Menu.Values;
using static $safeprojectname$.Menus;
using static $safeprojectname$.Spells;
using System;

namespace $safeprojectname$
{
    internal class Drawings
    {
        public static void CreateDrawings()
        {
            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            if (DrawingMenu["Q"].Cast<CheckBox>().CurrentValue && Q.IsReady())
            {
                Circle.Draw(SharpDX.Color.Red, Q.Range, Player.Instance);
            }
            if (DrawingMenu["W"].Cast<CheckBox>().CurrentValue && W.IsReady())
            {
                Circle.Draw(SharpDX.Color.Blue, W.Range, Player.Instance);
            }
            if (DrawingMenu["E"].Cast<CheckBox>().CurrentValue && E.IsReady())
            {
                Circle.Draw(SharpDX.Color.Yellow, E.Range, Player.Instance);
            }
            if (DrawingMenu["R"].Cast<CheckBox>().CurrentValue && R.IsReady())
            {
                Circle.Draw(SharpDX.Color.Black, R.Range, Player.Instance);
            }
        }
    }
}

