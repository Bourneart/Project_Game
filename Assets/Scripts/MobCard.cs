using System;
using UnityEngine;

public class MobCard : IMobCard
{
    string IMobCard.MobID => _mobID;

    string IMobCard.MobName => _mobName;

    int IMobCard.MobReflex { get => _mobReflex; set => throw new NotImplementedException(); }
    int IMobCard.MobBody { get => _mobBody; set => throw new NotImplementedException(); }
    int IMobCard.MobIntrllegence { get => _mobIntellegence; set => throw new NotImplementedException(); }
    int IMobCard.MobWisdom { get => _mobWisdom; set => throw new NotImplementedException(); }
    float IMobCard.MobHitPoints { get => _mobHitPoints; set => throw new NotImplementedException(); }
    float IMobCard.MobManaPoints { get => _mobManaPoints; set => throw new NotImplementedException(); }
    float IMobCard.MobMagicArmorClass { get => _mobMagicArmorClass; set => throw new NotImplementedException(); }

    private readonly string _mobID;

    internal string _mobName;

    protected int _mobReflex;
    protected int _mobBody;
    protected int _mobIntellegence;
    protected int _mobWisdom;
    protected float _mobHitPoints;
    protected float _mobManaPoints;
    protected float _mobMagicArmorClass;
}
