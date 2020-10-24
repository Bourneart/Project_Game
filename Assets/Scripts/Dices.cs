using System;
using UnityEngine;
using UnityEditor;

public class Dices
{
    public static int WhiteDice(uint seed)
    {
        Unity.Mathematics.Random WhiteDice = new Unity.Mathematics.Random();
        return WhiteDice.NextInt();
    }

    public static float WeaponDice(WeaponCard weapon)
    {
        Unity.Mathematics.Random WeaponDice = new Unity.Mathematics.Random();
        return WeaponDice.NextFloat(weapon.MinD, weapon.MaxD);
    }

    public static double GoldDice(IWeaponCard iweaponcard)
    {
        Unity.Mathematics.Random GoldDice = new Unity.Mathematics.Random();
        return GoldDice.NextDouble(iweaponcard.MinimalDamage, iweaponcard.MaximalDamage);
    }
}
  

