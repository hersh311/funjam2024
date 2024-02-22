using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    GameObject player;
    public bool inRange = false;
    public bool inPath = true;
    public bool square = false;
    public float speed = 5f;
    public Animator animator;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public float step;
    public float counter=0;
    public float timerange = 10;
    Vector3 p1_p;
    Vector3 p2_p;
    Vector3 p3_p;
    Vector3 p4_p;
    int ink=1;
    void Start()
    {
        
        animator = GetComponent<Animator>();
        p1_p = p1.transform.position;
        p2_p = p2.transform.position;
        p3_p = p3.transform.position;
        p4_p = p4.transform.position;
        transform.position = p1_p;
        player= GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        
        step = Time.deltaTime * speed;
        if (inPath)
        {
            if (!square)
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
            else
            {
                if (transform.position == p1_p)
                {
                    ink = 2;
                }
                else if (transform.position == p2_p)
                {
                    ink = 3;
                }
                else if (transform.position == p3_p)
                {
                    ink = 4;
                }
                else if (transform.position == p4_p)
                {
                    ink = 1;
                }
                switch (ink)
                {
                    case 1:
                        transform.position = Vector3.MoveTowards(transform.position, p1_p, step);
                        break;
                    case 2:
                        transform.position = Vector3.MoveTowards(transform.position, p2_p, step);
                        break;
                    case 3:
                        transform.position = Vector3.MoveTowards(transform.position, p3_p, step);
                        break;
                    case 4:
                        transform.position = Vector3.MoveTowards(transform.position, p4_p, step);
                        break;

                }
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
