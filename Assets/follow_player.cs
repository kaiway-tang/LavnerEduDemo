using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform Camera;
    void FixedUpdate() //This function runs 50 times per second!
    {
        //Lock onto player (BAD):
        Camera.position = Player.position + new Vector3(0, 0, -10);



        //Get the X and Y differences between the Player and the camera


        //Divide the X and Y differences by 10
        

        //Add the new difference to the camera's position
        
    }
}
