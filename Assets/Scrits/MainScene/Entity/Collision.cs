using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D()
    {
        gameObject.SetActive(false);
    }

}
