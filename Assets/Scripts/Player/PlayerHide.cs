using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHide : MonoBehaviour
{
    private SpriteRenderer _rend;

    private Obstacle[] _obstacles;

    private bool _isHiding = false;

    private void Awake()
    {
        _rend = GetComponent<SpriteRenderer>();
        _obstacles = FindObjectsOfType<Obstacle>();

        for (int i = 0; i < _obstacles.Length; i++)
        {
            _obstacles[i].playerHide += ToggleIsHiding;
        }
    }

    private void ToggleIsHiding(bool _hiding)
    {
        _isHiding = _hiding;
        Debug.Log(_hiding);
    }

    private void FixedUpdate()
    {
        var _alpha = _rend.color.a;
        if (_isHiding && _alpha > 0.5f)
        {
            _rend.color -= new Color(0f, 0f, 0f, 0.7f);
        }
        else if (!_isHiding && _alpha < 1)
        {
            _rend.color += new Color(0f, 0f, 0f, 1f);
        }
    }
}
