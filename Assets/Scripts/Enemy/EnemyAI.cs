using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private float _spotRange = 2f;
    private float _visibleRange = 3f;
    private float _followRange = 5f;
    private float maxFollowTime = 3f; // max time and Enemy will follow a player outside of it's visible range
    private float followTime;

    private bool _isChasing = false;
    private bool _seePlayer = false;

    public EnemyIdleState idleBehaviour;
    public EnemyFollowState followBehaviour;

    private States _state;

    private Transform _player;

    private Obstacle[] _obstacles;

    private BoxCollider2D _col;


    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _obstacles = FindObjectsOfType<Obstacle>();
        _col = GetComponent<BoxCollider2D>();

        for (int i = 0; i < _obstacles.Length; i++)
        {
            _obstacles[i].playerHide += SetVisibility;
        }
    }


    private void FixedUpdate()
    {
        if (_player == null) { idleBehaviour.Run(); return; }
        float _range = GetRange();

        if (_range <= _spotRange && !_isChasing && gameObject.tag == "Enemy")
        {
            _isChasing = true;
            followTime = maxFollowTime;
        }

        if (_isChasing) {
            if (followTime <= 0)
            {
                _isChasing = false;
            }
            else if (followTime <= 0 && gameObject.tag != "Enemy")
            {
                _isChasing = false;
            }

            if (_range > _visibleRange)
            {
                _seePlayer = false;
            }
            else
            {
                _seePlayer = true;
            }



            if (_range > _followRange || gameObject.tag != "Enemy") {
                followTime -= Time.deltaTime;
            }
            else if (followTime != maxFollowTime)
            {
                followTime = maxFollowTime;
            }
        }
        else if (_seePlayer)
        {
            _seePlayer = false;
        }

        Debug.Log(followTime);

        SetBehaviour();
    }

    private void SetBehaviour()
    {
        if (_isChasing)
        {
            followBehaviour.SetVisible(_seePlayer);
            followBehaviour.Run();
        }
        else
        {
            idleBehaviour.Run();
        }
    }

    private void SetVisibility(bool _isVisible)
    {
        if (!_seePlayer && _isVisible) {
            gameObject.tag = "Untagged";
        }
        else
        {
            gameObject.tag = "Enemy";
        }
    }

    private float GetRange()
    {
        return Vector3.Distance(transform.position, _player.transform.position);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _spotRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _visibleRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _followRange);
    }
}
