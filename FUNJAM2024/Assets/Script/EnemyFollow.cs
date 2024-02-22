using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    public bool inRange = false;
    public bool inPath = true;
    public bool square = false;
    public float speed = 5f;
    public Animator animator;
    public GameObject p1;
    public GameObject p2;
    public float step;
    public float counter=0;
    public float timerange = 10;
    Vector3 p1_p;
    Vector3 p2_p;
    void Start()
    {
        animator = GetComponent<Animator>();
        p1_p = p1.transform.position;
        p2_p = p2.transform.position;

    }
    
    void Update()
    {
        
        step = Time.deltaTime * speed;
        if (inPath && !square)
        {
            

            counter += Time.deltaTime;
            if (counter < timerange / 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, p2_p, step);
                

            }
            if (counter >= timerange / 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, p1_p, step);
            }
            if (counter >= timerange)
            {
                counter = 0;
            }
        }
       if(inRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);
            animator.SetBool("monster_mov", true);
            inPath = false;
        }
        else if(!inPath && !inRange)
        {
            animator.SetBool("monster_mov", false);
        }
    }
}
