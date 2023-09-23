using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public static enemy instance;
    private Rigidbody2D rb;
    private float speed = 30f;
    int x=1;
    int y=0;

    public float enemyProglessTime;    

    void Awake() 
    {
        instance=this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        RightMove();
    }

    void FixedUpdate()
    {
                 //毎秒x軸に１ずつ移動する
    transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);

    enemyProglessTime += Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "UpWall")
        {
            x=0;
            y=0;
            UpMove();
        }
        if (collision.gameObject.tag == "RightWall")
        {
            x=0;
            y=0;
            RightMove();
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            x=0;
            y=0;
            LeftMove();
        }
        if (collision.gameObject.tag == "DownWall")
        {
            x=0;
            y=0;
            DownMove();
        }
    }

    public void RightMove()
    {
        x=1;
        y=0;
    }
     public void LeftMove()
    {
        x=-1;
        y=0;
    } public void UpMove()
    {
        x=0;
        y=1;
    } public void DownMove()
    {
        x=0;
        y=-1;
    }

}