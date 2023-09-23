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
        enemy.instance.RightMove();
       } 
       if(Input.GetKeyDown(KeyCode.S))
       {
        enemy.instance.DownMove();
       } 
       if(Input.GetKeyDown(KeyCode.A))
       {
        enemy.instance.LeftMove();
       } 
       if(Input.GetKeyDown(KeyCode.W))
       {
        enemy.instance.UpMove();
       } 
       
    }
}
