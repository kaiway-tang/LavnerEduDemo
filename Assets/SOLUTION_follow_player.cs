using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player_solution : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform Camera;
    void FixedUpdate() //This function runs 50 times per second!
    {
        //Lock onto player (BAD):
        //Camera.position = Player.position + new Vector3(0, 0, -10);



        //Get the X and Y differences between the Player and the camera
        float x_difference = Player.position.x - Camera.position.x;
        float y_difference = Player.position.y - Camera.position.y;

        //Multiply the X and Y differences by a ratio
        x_difference = x_difference * 0.1f;
        y_difference = y_difference * 0.1f;

        //Add the new difference to the camera's position
        Camera.position += new Vector3(x_difference, y_difference, 0);
    }
}
