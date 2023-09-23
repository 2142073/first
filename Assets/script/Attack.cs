using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject ballPrefab; // プレハブとして設定するボールのゲームオブジェクト
    public float ballSpeed = 10f; // ボールの速度

    float proglessTime;

    void Update()
    {
        proglessTime += Time.deltaTime;//time.daletimeで毎フレームの時間を取得
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            // 敵の向きに向く
            transform.rotation = Quaternion.LookRotation(Vector3.forward, -other.transform.position - transform.position);

            if(proglessTime>1.5f)//前の行動から3秒以上経っていたらボールを発射
            {
                 LaunchBall();
                 proglessTime=0;        
            }
        }
    }

    void LaunchBall()
    {
        // ボールのインスタンスを作成
        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        // ボールの Rigidbody2D コンポーネントを取得
        Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // オブジェクトの向いている方向にボールを発射
            Vector2 direction = new Vector2(-this.gameObject.transform.up.x, -this.gameObject.transform.up.y);
             rb.velocity = direction * ballSpeed;
        }
    }

}
