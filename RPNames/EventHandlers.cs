namespace RPNames.EventHandlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using Exiled.API.Extensions;
    using System;
    using Hints;
    using System.Collections.Generic;
    using Exiled.Events.EventArgs.Player;

    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        Random random = new Random();

        public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            //if (plugin.NickNames.Count == 0)
            //{
            //Refreshnames();
            //}
            
            if (ev.NewRole.GetTeam() != PlayerRoles.Team.SCPs && plugin.Config.ClassTitles.ContainsKey(ev.NewRole))
            { 
                int RandomNameNumber = random.Next(1, plugin.NickNames.Count-1);
                //plugin.NickNames.RemoveAt(RandomNameNumber);
                ev.Player.DisplayNickname = plugin.Config.ClassTitles[ev.NewRole] + plugin.NickNames[(RandomNameNumber)];
            }
            if (ev.NewRole.GetTeam() == PlayerRoles.Team.SCPs && plugin.Config.ClassTitles.ContainsKey(ev.NewRole))
            {
                if (plugin.Config.SCPSetting)
                {

                    ev.Player.DisplayNickname = plugin.Config.ClassTitles[ev.NewRole];
                }
                else
                {
                    if (!plugin.Config.DboisSetting)
                    {
                        int RandomNameNumber = random.Next(1, plugin.NickNames.Count - 1);
                        //plugin.NickNames.RemoveAt(RandomNameNumber);
                        ev.Player.DisplayNickname = plugin.Config.ClassTitles[ev.NewRole] + plugin.NickNames[RandomNameNumber];
                    }
                    else
                    {
                        int DclassNumber = random.Next(1000, 9999);
                        ev.Player.DisplayNickname = ("D-" + DclassNumber.ToString());
                    }
                }
            }
            if (ev.NewRole == PlayerRoles.RoleTypeId.ClassD)
            {
                if (plugin.Config.DboisSetting)
                {
                    int DclassNumber = random.Next(1000, 9999);
                    ev.Player.DisplayNickname = ("D-" + DclassNumber.ToString());
                }
                
            }

            if (ev.NewRole == PlayerRoles.RoleTypeId.Tutorial || ev.NewRole == PlayerRoles.RoleTypeId.Spectator)
            {
                if (plugin.Config.TutorialNick)
                {
                    ev.Player.DisplayNickname = null;
                }
            }
            if(plugin.Config.ShowNick)
            {
                ev.Player.ReferenceHub.hints.Show(new TextHint($"{ev.Player.DisplayNickname}", new HintParameter[]
                { new StringHintParameter("") }, HintEffectPresets.FadeInAndOut(15f, 1f, 15f), 15f));
            }

            if (plugin.Config.ShowRealName)
            {
                if (ev.Player.DisplayNickname != null)
                {
                    ev.Player.DisplayNickname = $"{ev.Player.DisplayNickname} ({ev.Player.Nickname})";
                }
            }
        }
        public void OnPlayerDeath(DiedEventArgs ev)
        {
            if (plugin.Config.DeathReset)
            {
                ev.Player.DisplayNickname = null;
            }
        }


        public void Refreshnames()
        {
            if (plugin.Config.HumanNames == null)
            {
                plugin.NickNames = new List<string> { "Hyde", "Hood", "Hull", "Hogan", "Hitchens", "Higgins", "Hodder", "Huxx", "Hester", "King", "Kubiak", "Koker", "Kerrigan", "Kumara", "Knox", "Koufax", "Keagan", "Kestrel", "Future", "Fitzpatrick", "Fontana", "Fenner", "Furyk", "Finch", "Fullbright", "Fassbinder", "Flood", "Fong", "E.Gold", "Fleetwood", "Fugger", "Frost", "Fsik", "Fawcett", "Fishman", "Freeze", "Fissolo", "Foley", "Fairchild", "Freeman", "Decker", "Dobermann", "Dunlop", "Dumont", "Dandridge", "Diamond", "Cyrus", "Craggs", "Crisper", "Cotheran", "Curry", "Conard", "Cutler", "Coggins", "Cates", "Crisp", "Curio", "Murray", "Morrison", "McKay", "Merchant", "Murillo", "Mooney", "Murdock", "Matisse", "Massey", "McGee", "Minter", "Munson", "Oswald", "Ortega", "Ogle", "Orr", "Ogden", "Onassis", "Olson", "Ollenrenshaw", "Silver", "Small", "Stoneking", "Sweeney", "Surrett", "Swiatek", "Sloane", "Stapleton", "Seibert", "Stroud", "Strode", "Stockton", "Bright", "Miller", "Simarded", "Tombstone", "Cimmerian", "Conwell", "Clef", "Gears", "Kiryu", "Heiden", "Lloyd", "Marlowe", "Sorts", "Xyank", "Anborough", "LaFerrier", "Iceberg", "Kondraki", "Eskobar", "Anderson", "Ambrose", "Baudin", "Belitrov", "Chao", "Blackwood", "Fitzroy", "Silberescher", "Aktus", "Diaghilev", "Winchell", "Winters", "Walsh", "Whalen", "Watson", "Wooster", "Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Winchester", "Wire", "Wolf", "Wheeler", "Warrick", "Walcott", "Wilde", "Wexler", "Wells", "Weeks", "Wainright", "Wallace", "Weaver", "Wagner", "Wadd", "Withers", "Whitby", "Woodland", "Woody", "Warren", "Race", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker", "Riggs", "Redman", "Reinhart", "Redgrave", "Rafferty", "Rigby", "Roman", "Reece", "Abawi", "Allard", "Adara", "Abbott", "Acampora", "Ackerman", "Ackroyd", "Abbington", "Axworthy", "Ainge", "Abernathy", "Atkinson", "Abner", "Abella", "Agholor", "Allred", "Asola", "Abrams", "Acker", "Abrell", "Acuff", "Archer", "Asterio", "Adair", "Albright", "Adelson", "Atwood", "Aguillar", "Adler", "Arrowood", "Arora", "Tray", "R.Tey", "A.Clef", "Amathor", "Jesus", "Joker", "Lemon", "Boucher", "Git", "Brook", "Broke", "Brown", "Smith", "Reed" };
            }
            else
            {
                plugin.NickNames = plugin.Config.HumanNames;
            }
        }
    }
}
