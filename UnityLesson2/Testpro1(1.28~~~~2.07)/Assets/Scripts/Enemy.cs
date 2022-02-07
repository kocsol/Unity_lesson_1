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
    public GameObject bullet; //총알선언


    public GameManager _enemyManager; // 선언
    // Start is called before the first frame update
    void Start()
    {
        _enemyManager = FindObjectOfType<GameManager>();//사용
        health = 100;
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(0, 0, 10*Time.deltaTime); 
                //스크립트가 속해 있는 게임오브젝트에 접근하여 그 게임오브젝트를 이동(전진)시킨다.
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(0, 0, -10 * Time.deltaTime);
            //스크립트가 속해 있는 게임오브젝트에 접근하여 그 게임오브젝트를 이동(후)시킨다.
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
                //스크립트가 속해 있는 게임오브젝트에 접근하여 그 게임오브젝트를 좌회전시킨다.
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
            //스크립트가 속해 있는 게임오브젝트에 접근하여 그 게임오브젝트를 우회전시킨다.
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);//적은 없애고
            //새로운 적을 하나 더 만들어주세요.
            _enemyManager.enemyNum = 0;//사용
        }
        

        if (Input.GetKeyDown(KeyCode.LeftShift))//총을 쐈다.
        {
            //총을 쏴서 총알이 나가는 스크립트
            //1.총알이 생긴다. 
            //2. 총알의 위치를 발사하는 Enemy의 중심부로 놓는다.
            //3. Enemy가 보는 방향으로 총알을 돌린다. bullet 스크립트에 이미 넣어줬기때문에

            GameObject bulletClone = Instantiate(bullet);

            bulletClone.transform.position = this.gameObject.transform.position;
            
            bulletClone.AddComponent<Rigidbody>();
            Rigidbody bulletRigidBody = bulletClone.GetComponent<Rigidbody>();
            bulletClone.transform.forward = this.gameObject.transform.forward;
            bulletRigidBody.useGravity = false;
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
