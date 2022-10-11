using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Create a public reference to the player - we will assign this using the Unity editor
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Change our position relative to theb players position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
