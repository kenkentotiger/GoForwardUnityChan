using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //cubeのためのコンポーネントを入れる
    //public float cube;

    //Cubeのコンポーネントを入れる（追加）
    //Rigidbody2D rigid2D;

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //地面の位置
    private float groundLevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {

        //Rigidbody2Dのコンポ－ネントを取得する（追加）
        //this.rigid2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Cubeが地面に接触するとき、又はキューブ同士が積み重なる時に効果音をつける
        if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
   
            //地面に設置していないときはボリュームを0にする（追加）
            GetComponent<AudioSource>().Play();
    }
}
