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
        Speed,//�X�s�[�h�A�b�v�A�C�e��
        Barrage,//�e�����A�C�e��
    }

    [SerializeField]
    public Type itemTipe = Type.Barrage;
    [SerializeField]
    public string ItemName = "";//�A�C�e���̖��O
    [SerializeField]
    public string infomation = "";//�A�C�e���̏��
    [SerializeField]
    public int amount = 0;//�A�C�e���̌�

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