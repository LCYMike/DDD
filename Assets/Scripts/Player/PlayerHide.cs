using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHide : MonoBehaviour
{
    private SpriteRenderer _rend;

    private GameObject[] _enemies;

    [SerializeField]
    private bool _isHiding = false;
    private bool _isNearObstacle = false;

    private void Awake()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void FixedUpdate()
    {
        if (_isNearObstacle)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
            _rend = GetComponent<SpriteRenderer>();
                Debug.Log("E");


                if (!_isHiding)
                {
                    _rend.color = new Color(0f, 0f, 0f, 0.6f);
                    _isHiding = true;
                    
                    for (int i = 0; i < _enemies.Length; i++)
                    {
                        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), _enemies[i].GetComponent<Collider2D>(), _isHiding);
                    }
                }
                else if (_isHiding)
                {
                    _rend.color = new Color(0f, 0f, 0f, 1f);
                    _isHiding = false;

                    for (int i = 0; i < _enemies.Length; i++)
                    {
                        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), _enemies[i].GetComponent<Collider2D>(), _isHiding);
                    }
                }

            }
        }
        else if (_isHiding)
        {
            _rend.color += new Color(0f, 0f, 0f, 1f);
            _isHiding = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            _isNearObstacle = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            _isNearObstacle = false;
        }
    }


}
