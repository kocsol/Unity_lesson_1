using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    int health;
    int damage;
    float rotateSpeed = 90;
    public Text hpText;
    public Image hpBar;
    public GameObject enemy;//선언
    public GameObject bullet; //총알 선언
    public GameManager _enemyManager;//선언
    // Start is called before the first frame update
    void Start()
    {
        _enemyManager = GameObject.FindObjectOfType<GameManager>();        
        health = 100;
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //스크립트가 속해있는 게임오브젝트에 접근하여 그 게임오브젝트를 이동(전진)시킨다.
            this.gameObject.transform.Translate(0, 0, 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //스크립트가 속해있는 게임오브젝트에 접근하여 그 게임오브젝트를 이동(후진)시킨다.
            this.gameObject.transform.Translate(0, 0, - 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //스크립트가 속해있는 게임오브젝트에 접근하여 그 게임오브젝트를 좌회전시킨다.
            this.gameObject.transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //스크립트가 속해있는 게임오브젝트에 접근하여 그 게임오브젝트를 우회전시킨다.
            this.gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        //총을 쐇다.
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //총을 쏴서 총알이 나가는 스크립트
            //1. 총알이 생긴다
            //2. 총알의 위치를 발사하는 Enemy의 중심부로 놓는다.
            //3. Enemy가 보는 방향으로 총알을 돌린다.

            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = this.gameObject.transform.position;

            bulletClone.AddComponent<Rigidbody>();
            Rigidbody bulletRigidBody = bulletClone.GetComponent<Rigidbody>();
            //bulletRigidBody.AddForce(this.gameObject.transform.forward * 200);
            bulletClone.transform.forward = this.gameObject.transform.forward;
            bulletRigidBody.useGravity = false;

        }



        if (health <= 0)
        {
            Destroy(this.gameObject);//적은 없애고
            //새로운 적을 하나 더 만들어주세요.
            _enemyManager.enemyNum = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {            
            health = health - damage;
            hpText.text = "hp :" + health;
            float myHP = (float)(0.01f * health);
            hpBar.fillAmount = myHP;
            Destroy(other.gameObject);
        }
    }
}
