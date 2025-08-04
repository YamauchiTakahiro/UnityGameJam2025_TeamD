using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "createItem")]
public class Item : ScriptableObject
{
    public enum Type
    {
        Speed,//スピードアップアイテム
        Barrage,//弾増加アイテム
    }

    [SerializeField]
    public Type itemTipe = Type.Barrage;
    [SerializeField]
    public string ItemName = "";//アイテムの名前
    [SerializeField]
    public string infomation = "";//アイテムの情報
    [SerializeField]
    public int amount = 0;//アイテムの個数

    public Type GetItemType()
    {
        return itemTipe;
    }

    public string GetItemName()
    {
        return ItemName;
    }

    public string GetItemInfomation()
    {
        return infomation;
    }

    public int GetAmount()
    {
        return amount;
    }
}