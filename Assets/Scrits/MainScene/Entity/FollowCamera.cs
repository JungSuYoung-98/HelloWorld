using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetX;
    float offsetY;
    float MaxX = 80;
    float MaxY = 36;
    float MinX = -10;
    float MinY = -9;

    void Start()
    {
        if (target == null)
            return;

        offsetX = transform.position.x - target.position.x;
        offsetY = transform.position.y - target.position.y;


    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        pos.y = target.position.y + offsetY;
        if (pos.x > MaxX) pos.x = MaxX;
        if (pos.x < MinX) pos.x = MinX;
        if (pos.y > MaxY) pos.y = MaxY;
        if (pos.y < MinY) pos.y = MinY;

        transform.position = pos;
    }
}
