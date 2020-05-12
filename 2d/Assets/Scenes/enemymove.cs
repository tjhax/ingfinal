using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UIElements;

public class enemymove : MonoBehaviour { 

public float speed;
private bool MoveRight = true;

public Transform groundDetection;
    private bool isFacingRight;
    private object center;

    private void Update() { 

   
        
       
    
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        if(groundInfo.collider == false)
        {
            if(MoveRight == true)
            {
                //transform.Rotate(0, 180, 0);
                transform.localEulerAngles = new Vector3(0, 180, 0);
                MoveRight = false;
            } else
            {
                //transform.Rotate(0, 0, 0)
                transform.localEulerAngles = new Vector3(0, 0, 0);
                MoveRight = true;
            }
        }
    }
    
}
