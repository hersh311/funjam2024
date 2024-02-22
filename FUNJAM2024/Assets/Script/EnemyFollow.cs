using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    public bool inRange = false;
    public float speed = 5f;

    
    void Update()
    {
        if(inRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);
        }
    }
}
