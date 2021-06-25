using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }

    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
        //  Destroy(gameObject);
    }
  
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            collision.gameObject.SetActive(false);
            
        }
    }


}
