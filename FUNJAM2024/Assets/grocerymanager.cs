using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class grocerymanager : MonoBehaviour
{
    public int groceryScore = 0;
    public int groceryCount = 0;
    public int req_groceries = 10;


    void Start()
    {
        groceryScore = 0;
        groceryCount = 0;
    }


    void Update()
    {
        if (req_groceries == groceryCount)
        {
            SceneManager.LoadScene(3);
        }
    }
}
