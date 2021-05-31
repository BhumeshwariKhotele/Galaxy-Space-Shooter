using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   public float PlayerSpeed;
    public Player localPlayer;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizantal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizantal, vertical)*PlayerSpeed;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, localPlayer.xMin, localPlayer.xMax), Mathf.Clamp(rb.position.y, localPlayer.yMin, localPlayer.yMax));
    }
}

[System.Serializable]
public class Player
{
    public float xMin, xMax, yMin, yMax;
}
