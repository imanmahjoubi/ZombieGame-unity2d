using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour
{
    public float objectSpeed = 0f;

    void Update()
    {
        transform.Translate(0, objectSpeed, 0);
    }
}