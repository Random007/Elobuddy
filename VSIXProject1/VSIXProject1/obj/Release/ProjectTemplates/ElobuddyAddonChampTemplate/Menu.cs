using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace $safeprojectname$
{
    internal class Menus
    {
        public static Menu mainMenu;
        public static Menu ComboMenu;
        public static Menu DrawingMenu;
        public static Menu LaneClearMenu;

        public static void CreateMenu()
        {
            mainMenu = MainMenu.AddMenu("mainMenu", "0", "Basic EB Template Menu");
            mainMenu.AddSeparator();
            ComboMenu = mainMenu.AddSubMenu("Combo");
            DrawingMenu = mainMenu.AddSubMenu("Drawing");
            LaneClearMenu = mainMenu.AddSubMenu("LaneClear");

            mainMenu.AddGroupLabel("EB Template Menu");
            mainMenu.AddLabel("Some EB Template Description..");


            ComboMenu.AddGroupLabel("Combo Settings");
            ComboMenu.Add("Q", new CheckBox("Use Q"));
            ComboMenu.Add("W", new CheckBox("Use W"));
            ComboMenu.Add("E", new CheckBox("Use E"));
            ComboMenu.Add("R", new CheckBox("Use R"));


            DrawingMenu.AddGroupLabel("Draw Settings");
            DrawingMenu.Add("Q", new CheckBox("Draw Q"));
            DrawingMenu.Add("W", new CheckBox("Draw W"));
            DrawingMenu.Add("E", new CheckBox("Draw E"));
            DrawingMenu.Add("R", new CheckBox("Draw R"));


            LaneClearMenu.AddGroupLabel("LaneClear Settings");
            LaneClearMenu.Add("Q", new CheckBox("Use Q"));
            LaneClearMenu.Add("W", new CheckBox("Use W Clear Combo"));
            LaneClearMenu.Add("E", new CheckBox("Use E"));
        }
    }
}

