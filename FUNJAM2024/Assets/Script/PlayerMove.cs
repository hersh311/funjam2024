using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float inputH = 0;
    private float inputV = 0;
    public float speed = 10;
    public Rigidbody2D rb;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        if(inputH==0 && inputV == 0)
        {
            animator.SetBool("is_moving",false);
        }
        else
        {
            animator.SetBool("is_moving", true);
        }
        rb.velocity = new Vector2(speed * inputH, speed * inputV);

    }
}
