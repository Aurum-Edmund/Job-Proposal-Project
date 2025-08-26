using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionAtoB : MonoBehaviour
{
    Transform objectTransformCache;

    [SerializeField]
    Vector3 targetPosition = Vector3.zero;

    [SerializeField]
    float speed = 5f;

    Vector3 currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        objectTransformCache = transform;
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(currentPosition, targetPosition) > .1f)
        {
            currentPosition = Vector3.Lerp(currentPosition,
                targetPosition, Time.fixedDeltaTime * speed);
        }
        objectTransformCache.position = currentPosition;
    }
}
