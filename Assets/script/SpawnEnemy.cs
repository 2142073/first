using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    float proglessTime;
     int random;
    // Start is called before the first frame update
    void Start()
    {
         random = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
       proglessTime += Time.deltaTime;
         if(proglessTime>random)
         {
            random = Random.Range(1, 5);
              proglessTime=0;
              Spawn();
         } 
    }

    void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
