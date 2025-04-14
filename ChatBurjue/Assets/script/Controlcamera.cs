using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlcamera : MonoBehaviour
{
    public GameObject player; //The offset of the camera to centrate the player in the X axis
    public float offsetX = -5; //The offset of the camera to centrate the player in the Z axis
    public float offsetZ = 0; //The maximum distance permited to the camera to be far from the player, its used to make a smooth movement
    public float offsetY = 20;
    public float maximumDistance = 2; //The velocity of your player, used to determine que speed of the camera
    public float playerVelocity = 10;

    private float movementX;
    private float movementZ;
    private float moveY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementX = ((player.transform.position.x + offsetX - this.transform.position.x)) / maximumDistance;
        movementZ = ((player.transform.position.z + offsetZ - this.transform.position.z)) / maximumDistance;
        moveY = ((Mathf.Round(player.transform.position.y) + offsetY - Mathf.Round(this.transform.position.y)));
        //Debug.Log(moveY);

        this.transform.position += new Vector3((movementX * playerVelocity * Time.deltaTime), (moveY * Time.deltaTime), (movementZ * playerVelocity * Time.deltaTime));
    }
}
