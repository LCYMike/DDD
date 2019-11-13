using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour {

    public ItemStats stats;

    private PlayerStats _playerStats;

    private void Start()
    {
        _playerStats = FindObjectOfType<PlayerStats>();
        _playerStats.AddItem += DestroyItem;
    }

    private void DestroyItem(ItemStats _item)
    {
        if(stats == _item)
        {
            gameObject.GetComponent<ParticleSystem>().Stop();
        }
    }
}
