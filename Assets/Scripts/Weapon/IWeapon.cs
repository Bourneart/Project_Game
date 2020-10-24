using System;
using UnityEngine;

public interface IWeapon
{
    /*
     *    Weapon ID форматирование:
     *    строка представляет собой
     *    набор из трёх буквенных
     *    и трёх цифровых символов
     *    
     *    Пример:
     *    string IWeapon.WeaponID => "wfn100";
     *    где первый символ 
     *    (w) - weapon (маркировака "оружие")
     *    (f) - fire (принадлежность к стихии)
     *    (n) - запасной символ (для узких корректировок)
     */

    string WeaponID { get; }
    string WeaponName { get; }

    float MinD { get; }
    float MaxD { get; }
    float FirstGainFactor { get; }
    float SecondGainFactor { get; }
    float ThirdGainFactor { get; }

    void InputData(WeaponTable table);
    

    float Damage(WeaponCard weapon, HeroCard hero);

}
