using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcHeroParams : MonoBehaviour
{
    [SerializeField]
    Text _refInfo, _bodInfo,
         _intInfo, _wisInfo,
         _hitPointsInfo, _manaPointsInfo;

    public void CalcParams(IHeroCard iheroCard)
    {
        iheroCard.HitPoints = iheroCard.Body * 5;
        iheroCard.ManaPoints = iheroCard.Wisdom * 7;

        _refInfo.text = iheroCard.Reflex.ToString();
        _bodInfo.text = iheroCard.Body.ToString();
        _intInfo.text = iheroCard.Intellegence.ToString();
        _wisInfo.text = iheroCard.Wisdom.ToString();
        _hitPointsInfo.text = iheroCard.HitPoints.ToString();
        _manaPointsInfo.text = iheroCard.ManaPoints.ToString();
    }

    public void AddReflex(IHeroCard iheroCard)
    {
        iheroCard.Reflex++;
    }

    public void AddBody(IHeroCard iheroCard)
    {
        iheroCard.Body++;
    }

    public void AddIntellegence(IHeroCard iheroCard)
    {
        iheroCard.Intellegence++;
    }

    public void AddWisdom(IHeroCard iheroCard)
    {
        iheroCard.Wisdom++;
    }

}
