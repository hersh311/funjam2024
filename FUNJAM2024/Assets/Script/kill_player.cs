using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_player : MonoBehaviour
{
    public GameObject hearts;
    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.Find("hearts");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hearts.GetComponent<heart_mgr>().lives -= 1;
            collision.transform.position = new Vector3(-30, -40, -5);
        }
    }
}
