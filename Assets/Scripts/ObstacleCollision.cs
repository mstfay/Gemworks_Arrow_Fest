using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public ArrowMovement movement;

    private void OnCollisionEnter(Collision hitObstacle)
    {
        if(hitObstacle.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
