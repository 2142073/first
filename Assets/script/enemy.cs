using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public static enemy instance;
    private Rigidbody2D rb;
    private float speed = 30f;
    public int x=1;
    public int y=0;

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
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "UpWall")
        {
            Debug.Log("壁に当たった");
            x=0;
            y=0;
            UpMove();
        }
        if (collision.gameObject.tag == "RightWall")
        {
            Debug.Log("壁に当たった");
            x=0;
            y=0;
            RightMove();
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            Debug.Log("壁に当たった");
            x=0;
            y=0;
            LeftMove();
        }
        if (collision.gameObject.tag == "DownWall")
        {
            Debug.Log("壁に当たった");
            x=0;
            y=0;
            DownMove();
        }
    }

    public void RightMove()
    {
        Debug.Log("右");
        x=1;
        y=0;
    }
     public void LeftMove()
    {
        Debug.Log("左");
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