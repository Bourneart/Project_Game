using System;
using UnityEngine;

public class HeroCard : MonoBehaviour, IHeroCard
{
    string IHeroCard.PlayerID => _playerID;

    string IHeroCard.HeroName => _heroName;

    int IHeroCard.Reflex { get => _reflex; set => throw new NotImplementedException(); }
    int IHeroCard.Body { get => _body; set => throw new NotImplementedException(); }
    int IHeroCard.Intellegence { get => _intellegence; set => throw new NotImplementedException(); }
    int IHeroCard.Wisdom { get => _wisdom; set => throw new NotImplementedException(); }
    int IHeroCard.Level { get => _level; set => throw new NotImplementedException(); }
    int IHeroCard.Money { get => _money; set => throw new NotImplementedException(); }

    float IHeroCard.Expirience { get => _expirience; set => throw new NotImplementedException(); }
    float IHeroCard.HitPoints { get => _hitPoints; set => throw new NotImplementedException(); }
    float IHeroCard.ManaPoints { get => _manaPoints; set => throw new NotImplementedException(); }
    float IHeroCard.MagicalArmorClass { get => _magicalAC; set => throw new NotImplementedException(); }
    float IHeroCard.RecoveryHitPoints { get => _recoveryHP; set => throw new NotImplementedException(); }
    float IHeroCard.RecoveryManaPoints { get => _recoveryMP; set => throw new NotImplementedException(); }

    private readonly string _playerID;

    internal string _heroName;

    protected int _reflex;
    protected int _body;
    protected int _intellegence;
    protected int _wisdom;
    protected int _level;
    protected int _money;

    protected float _expirience;
    protected float _hitPoints;
    protected float _manaPoints;
    protected float _magicalAC;
    protected float _recoveryHP;
    protected float _recoveryMP;

}
