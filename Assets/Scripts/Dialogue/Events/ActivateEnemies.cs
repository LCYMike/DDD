using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemies : TriggerEvent
{
    [Header("Set to 0 to select all enemies")]
    public EnemyAI[] _enemies;

    private void Start()
    {
        if(_enemies == null)
        {
            _enemies = GetComponents<EnemyAI>();
        }
    }

    public override void Run()
    {
        if(_enemies != null)
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                if (_enemies[i] != null)
                {
                    _enemies[i].Activate();
                }
                else
                {
                    Debug.LogError("There was an empty entry in the _enemies list.");
                }
            }
        }
    }
}
