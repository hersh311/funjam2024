using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class grocery_update : MonoBehaviour
{
    public TMP_Text groc_count;
    int groc_collected;
    int req_groc;
    GameObject grocery_mgr;
    // Start is called before the first frame update
    void Start()
    {
        grocery_mgr= GameObject.Find("GroceryCollector");
        req_groc = grocery_mgr.GetComponent<grocerymanager>().req_groceries;
    }

    // Update is called once per frame
    void Update()
    {groc_collected=grocery_mgr.GetComponent<grocerymanager>().groceryCount;
        groc_count.SetText(groc_collected.ToString()+"/"+req_groc.ToString());
        
    }
}
