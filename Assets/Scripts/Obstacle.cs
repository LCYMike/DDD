using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Obstacle : MonoBehaviour
{
    public KeyCode interactKey;
    public Action<bool> playerHide;

    private bool _isHiding = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(interactKey) && playerHide != null && collision.tag == "Player")
        {
            if (!_isHiding)
            {
                _isHiding = true;
                playerHide(true);
            }
            else
            {
                _isHiding = false;
                playerHide(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && _isHiding)
        {
            _isHiding = false;
            playerHide(false);
        }
    }
}
