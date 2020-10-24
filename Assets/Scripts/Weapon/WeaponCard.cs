using System;
using UnityEngine;

public class WeaponCard :  IWeapon
{
    public delegate float Dice(WeaponCard weapon);
    Dice dice;

    string IWeapon.WeaponID => _weaponID;

    string IWeapon.WeaponName => _weaponName;

    public float MinD => _minD;
    public float MaxD => _maxD;
    public float FirstGainFactor => _fgf;
    public float SecondGainFactor => _sgf;
    public float ThirdGainFactor => _tgf;

    private string _weaponID;
    public string _weaponName;

    protected float _minD;
    protected float _maxD;
    protected float _fgf;
    protected float _sgf;
    protected float _tgf;

    public void InputData(WeaponTable table)
    {
        throw new NotImplementedException();
    }

    public float Damage(WeaponCard weaponCard, HeroCard hero)
    {
        dice = Dices.WeaponDice;
        return dice(weaponCard) + hero._intellegence * weaponCard._fgf;
    }

}
