using System;
using System.Collections.Generic;

using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Scp914;

namespace RPNames
{
    public class Config : IConfig
    {
        
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;


        public bool TutorialNick { get; set; } = true;


        public bool DboisSetting { get; set; } = true;


        public bool SCPSetting { get; set; } = true;


        public bool DeathReset { get; set; } = false;


        public bool ShowNick { get; set; } = true;


        public bool ShowRealName { get; set; } = false;


        public Dictionary<PlayerRoles.RoleTypeId, string> ClassTitles { get; set; } = new Dictionary<PlayerRoles.RoleTypeId, string>
        {
            {
                PlayerRoles.RoleTypeId.ClassD, "D-"
            },
            {
                PlayerRoles.RoleTypeId.Scientist, "Dr."
            },
            {
                PlayerRoles.RoleTypeId.FacilityGuard, "Security Officer "
            },
            {
                PlayerRoles.RoleTypeId.NtfCaptain, "Commander "
            },
            {
                PlayerRoles.RoleTypeId.NtfPrivate, "Cadet "
            },
            {
                PlayerRoles.RoleTypeId.NtfSergeant, "Lieutenant "
            },
            {
                PlayerRoles.RoleTypeId.NtfSpecialist, "Field Agent "
            },
            {
                PlayerRoles.RoleTypeId.ChaosConscript, "Agent of Chaos "
            },
            {
                PlayerRoles.RoleTypeId.Scp049, "SCP-049 "
            },
            {
                PlayerRoles.RoleTypeId.Scp0492, "SCP-049-2 "
            },
            {
                PlayerRoles.RoleTypeId.Scp079, "SCP-079 "
            },
            {
                PlayerRoles.RoleTypeId.Scp096, "SCP-096 "
            },
            {
                PlayerRoles.RoleTypeId.Scp106, "SCP-106 "
            },
            {
                PlayerRoles.RoleTypeId.Scp173, "SCP-173 "
            },
            {
                PlayerRoles.RoleTypeId.Scp939, "SCP-939 "
            },
   
        };

        public List<string> HumanNames { get; set; } = new List<string> { };
    }
}