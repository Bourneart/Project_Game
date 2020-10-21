using System;
using UnityEngine;

public interface IMobCard
{
    string MobID { get; }
    string MobName { get; }

    int MobReflex { get; set; }
    int MobBody { get; set; }
    int MobIntrllegence { get; set; }
    int MobWisdom { get; set; }
    float MobHitPoints { get; set; }
    float MobManaPoints { get; set; }
    float MobMagicArmorClass { get; set; }
}
