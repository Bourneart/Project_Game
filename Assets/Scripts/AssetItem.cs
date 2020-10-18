using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Item")]
class AssetItem : ScriptableObject, IItem
{
    public string Name => throw new System.NotImplementedException();
    public Sprite UIIcon => throw new System.NotImplementedException();

    [SerializeField] private string _name;
    [SerializeField] private Sprite _uiIcon;
}
