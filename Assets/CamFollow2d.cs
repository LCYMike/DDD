using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CamFollow2d : MonoBehaviour {

    public Transform target;
    private Vector3 targetPosition;

    public Vector2 offSet;

	void FixedUpdate () {
        targetPosition = new Vector3(target.position.x + offSet.x, target.position.y + offSet.y, transform.position.z);
        transform.position = targetPosition;
	}
}
