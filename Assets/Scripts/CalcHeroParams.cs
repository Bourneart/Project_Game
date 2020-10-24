using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcHeroParams : MonoBehaviour
{
    [SerializeField]
    Text RCount, BCount, ICount, WCount, CPoints;

    internal int _rCount, _bCount, _iCount, _wCount, _CharPoints;

    public void AddChar(HeroCard hero)
    {
        hero.AddingCharacteristics(_rCount, _bCount, _iCount, _wCount);
        CalcParams(hero);
        Clear();
    }

    public void CalcParams(HeroCard heroCard)
    {
        heroCard._hitPoints = heroCard._body * 5f;
        heroCard._manaPoints = heroCard._wisdom * 7f;
        heroCard._magicalAC = heroCard._wisdom * 1.1f;
        heroCard._recoveryHP = heroCard._body * 0.15f;
        heroCard._recoveryMP = heroCard._wisdom * 0.2f;
    }

    public void AddReflex(HeroCard hero)
    {
        if (_CharPoints != 0)
        {
            hero._reflex++;
        }
    }

    public void AddBody(HeroCard hero)
    {
        if (_CharPoints != 0)
        {
            hero._body++;
        }
    }

    public void AddIntellegence(HeroCard hero)
    {
        if (_CharPoints != 0)
        {
            hero._intellegence++;
        }
    }

    public void AddWisdom(HeroCard hero)
    {
        if (_CharPoints != 0)
        {
            hero._wisdom++;
        }
    }

    public void AddReflex_alt()
    {
        if (_CharPoints != 0)
        {
            _rCount++;
            RCount.text = _rCount.ToString();
        }
    }

    public void AddBody_alt()
    {
        if (_CharPoints != 0)
        {
            _bCount++;
            BCount.text = _bCount.ToString();
        }
    }

    public void AddIntellegence_alt()
    {
        if (_CharPoints != 0)
        {
            _iCount++;
            ICount.text = _iCount.ToString();
        }
    }

    public void AddWisdom_alt()
    {
        if (_CharPoints != 0)
        {
            _wCount++;
            WCount.text = _wCount.ToString();
        }
    }

    private void Clear()
    {
        _rCount = 0;
        _bCount = 0;
        _iCount = 0;
        _wCount = 0;
    }
}

