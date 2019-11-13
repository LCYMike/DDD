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
    public bool _isActive = true;
    private bool _freezeEnemy = false;
    public EnemyIdleState idleBehaviour;
    public EnemyFollowState followBehaviour;

    private SetDialogueTxt _dialogue;

    private States _state;

    private GameObject _player;
    private BoxCollider2D _col;

    public void Activate()
    {
        _isActive = true;
    }

    private void Start()
    {
        _dialogue = FindObjectOfType<SetDialogueTxt>();
        _dialogue.isActive += FreezeEnemy;
        _player = GameObject.FindGameObjectWithTag("Player");
        _col = GetComponent<BoxCollider2D>();
    }

    private void FreezeEnemy(bool _active)
    {
        _freezeEnemy = _active;
    }

    private void FixedUpdate()
    {
        if (_player == null) { idleBehaviour.Run(); return; }
        float _range = GetRange();

        if (_range <= _spotRange && !_isChasing)
        {
            _isChasing = true;
            followTime = maxFollowTime;
        }

        if (_isChasing) {
            if (followTime <= 0)
            {
                _isChasing = false;
            }
            else if (followTime <= 0)
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



            if (_range > _followRange) {
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

        if (_isActive && !_freezeEnemy)
        {
            SetBehaviour();
        }
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

    private float GetRange()
    {
        return Vector3.Distance(gameObject.transform.position, _player.transform.position);
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
