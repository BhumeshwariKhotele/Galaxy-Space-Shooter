using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed;
        move *= Time.deltaTime;
        transform.Translate(move, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(Bullet, transform.position, Quaternion.identity);
            GameObject bt = Pool.Instance.Get("Bullet");
            if (bt != null)
            {
                bt.transform.position = transform.position;
                bt.SetActive(true);
            }
        }
    }
}
