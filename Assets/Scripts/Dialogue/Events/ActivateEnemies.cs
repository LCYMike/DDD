using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemies : TriggerEvent
{
    public EnemyAI[] enemies;

    public override void Run()
    {
        if(enemies != null)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] != null)
                {
                    enemies[i].Activate();
                }
                else
                {
                    Debug.LogError("There was an empty entry in the enemies list.");
                }
            }
        }
    }
}
