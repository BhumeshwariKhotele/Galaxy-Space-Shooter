using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        if (Random.Range(0f, 100f) < 5)
        {
            //  Instantiate(enemy, transform.position + new Vector3(Random.Range(-2.3f, 2.3f), 5.0f, 0), Quaternion.identity);

            GameObject et = Pool.Instance.Get("Enemy");
            if (et != null)
            {
                et.transform.position = transform.position + new Vector3(Random.Range(-2.3f, 2.3f), 5.0f, 0);
                et.SetActive(true);
            }
        }
    }
}
