using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDirection : MonoBehaviour
{

    private PlayerMovement2D _mov;

    public SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        _mov = GetComponent<PlayerMovement2D>();
        _mov.playerDir += SetX;
    }


    void SetX(float _dir)
    {
        if(_dir < 0)
        {
            rend.flipX = true;
        }
        else if(_dir > 0)
        {
            rend.flipX = false;
        }
    }
}
