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
        if (Input.GetKeyDown(KeyCode.D))
        {
            enemy.instance.RightMove();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            enemy.instance.DownMove();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            enemy.instance.RightMove();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            enemy.instance.UpMove();
        }

    }
}
