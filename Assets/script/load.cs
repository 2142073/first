using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.D))
       {
        enemy.instance.right();
       } 
       if(Input.GetKeyDown(KeyCode.S))
       {
        enemy.instance.down();
       } 
       if(Input.GetKeyDown(KeyCode.A))
       {
        enemy.instance.right();
       } 
       if(Input.GetKeyDown(KeyCode.W))
       {
        enemy.instance.up();
       } 
       
    }
}
