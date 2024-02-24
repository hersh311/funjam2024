using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //collision.GetComponent<PlayerMove>().points += 5;
            //Debug.Log("Points = " + collision.GetComponent<PlayerMove>().points);

            this.transform.parent.transform.parent.GetComponent<grocerymanager>().groceryScore += 5;
            this.transform.parent.transform.parent.GetComponent<grocerymanager>().groceryCount += 1;

            Object.Destroy(this.transform.parent.transform.gameObject);
        }
    }
}
