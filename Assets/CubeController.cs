using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    //�n�ʂ̈ʒu
    private float groundLevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Cube���n�ʂɐڐG����Ƃ��A���̓L���[�u���m���ςݏd�Ȃ鎞�Ɍ��ʉ�������
        if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
   
            //�n�ʂɐݒu���Ă��Ȃ��Ƃ��̓{�����[����0�ɂ���i�ǉ��j
            GetComponent<AudioSource>().Play();
    }
}
