using UnityEngine;

public class follow_player : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}