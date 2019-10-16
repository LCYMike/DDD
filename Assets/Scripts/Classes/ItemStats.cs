﻿using System;

[Serializable]
public class ItemStats
{
    public string name = "Item";
    public bool isUnlocked = false;
    public int lvl = 0;
    public float weight = 0;

    public ItemStats(string _name, bool _unlocked, float _weight, int _lvl) {
        name = _name;
        isUnlocked = _unlocked;
        weight = _weight;
        lvl = _lvl;
    }

    public ItemStats(string _name)
    {
        name = _name;
    }
}
