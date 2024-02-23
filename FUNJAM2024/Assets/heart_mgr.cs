using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_mgr : MonoBehaviour
{
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (lives)
        {
            case 1:
                h1.SetActive(true);
                h2.SetActive(false);
                h3.SetActive(false);
                break;
            case 2:
                h1.SetActive(true);
                h2.SetActive(true);
                h3.SetActive(false);
                break;
            case 3:
                h1.SetActive(true);
                h2.SetActive(true);
                h3.SetActive(true);
                break;
        }
    }
}
