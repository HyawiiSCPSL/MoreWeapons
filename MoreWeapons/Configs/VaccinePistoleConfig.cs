﻿using System.Collections.Generic;
using System.ComponentModel;
using Synapse.Config;

namespace MoreWeapons.Configs
{
    public class VaccinePistoleConfig : AbstractConfigSection
    {
        [Description("The Roles that SCP-049-2 can be replaced with when hit by the VaccinePistole")]
        public List<int> ReplaceRoles { get; set; } = new List<int>
        {
            (int)RoleType.ClassD,
            (int)RoleType.Scientist
        };

        [Description("The amount of Damage when the Target is not SCP-049-2")]
        public int Damage { get; set; } = 10;

        [Description("The Amount of Adrenaline that can be loaded into the VaccinePistole")]
        public int MagazineSize { get; set; }
    }
}
