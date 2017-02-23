using EloBuddy.SDK;
using EloBuddy;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using System;
/* 
 * Please Remember this
 * is pure basic
 * as well as just
 * a template
 */
namespace $safeprojectname$
{
    class Loader
{
    static void Main(string[] args)
    {
        Loading.OnLoadingComplete += OnLoadingComplete;
    }

    private static void OnLoadingComplete(EventArgs args)
    {
        if (Player.Instance.Hero != Champion.Zed) return;
        Chat.Print("Template made by [©RaiNote]\n Have fun using this simple template.");
        Game.OnTick += OnTick;
    }

    private static void OnTick(EventArgs args)
    {
        Menus.CreateMenu();
        if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) Combo.ComboExecute();
        if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LaneClear)) LaneClear.LaneClearExecute();
    }
}
}
