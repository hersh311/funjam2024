using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Update value (points)
            collision.GetComponent<PlayerMove>().points += 5;
            Debug.Log("Points = " + collision.GetComponent<PlayerMove>().points);
            //Delete
            Object.Destroy(this.transform.parent.transform.gameObject);
        }
    }
}
