using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CamFollow2D : MonoBehaviour {

    public Transform target;
    private Vector3 targetPos;


    public Vector2 offSet;

    [Space]

    [SerializeField]
    private bool _UseRestrictions = false;
    [SerializeField]
    private Vector2 minXY;
    [SerializeField]
    private Vector2 maxXY;

    private void Start()
    {
        if (minXY.x > maxXY.x)
        {
            Debug.LogError("Min X is langer than Max X, Restrictions were turned off.");
            _UseRestrictions = false;
        }
        if (minXY.y > maxXY.y)
        {
            Debug.LogError("Min Y is langer than Max Y, Restrictions were turned off.");
            _UseRestrictions = false;
        }
    }

    void FixedUpdate () {

        targetPos = new Vector3(target.position.x + offSet.x, target.position.y + offSet.y, transform.position.z);

        //check if rescrictions should be used
        if(_UseRestrictions)
        {
            //check is restrictions are actually set
            if (maxXY.x != minXY.x)
            {
                //put camera inside restraints if left
                if (targetPos.x < minXY.x || transform.position.x < minXY.x) { targetPos.x = minXY.x; }
                if (targetPos.x > maxXY.x || transform.position.x > maxXY.x) { targetPos.x = maxXY.x; }
            }
            //check is restrictions are actually set
            if (maxXY.y != minXY.y)
            {
                //put camera inside restraints if left
                if (targetPos.y < minXY.y || transform.position.y < minXY.y) { targetPos.y = minXY.y; }
                if (targetPos.y > maxXY.y || transform.position.y > maxXY.y) { targetPos.y = maxXY.y; }
            }

        }

        transform.position = targetPos;

    }
}
