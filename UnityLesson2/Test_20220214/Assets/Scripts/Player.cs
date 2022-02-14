using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int moveSpeed;
    public int rotateSpeed = 90;
    bool isActive;
    private int a ;

    public GameObject bullet;
    private GameObject test;
    public GameObject intBullet2;
    int health;
    int damage = 30;

    bool isGround;

    public Text hpText;
    public Image hpBarImage;
    int maxHp = 100;

    private GameManager _gameManager;//선언

    public Animator _animator; //2/14

    public AudioSource audiosource; //2.14 

    public GameObject shootEffect;
    public Transform effectSpot;


    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindObjectOfType<GameManager>();
        health = 100;
        maxHp = 100;
    }

    // Update is called once per frame
    private void Update()
    {     
        Move();

        if (Input.GetKeyDown(KeyCode.RightShift))//방아쇠를 당긴다.
        {
            //총알을 발사한다.

            //            1.총알이라는 게임오브젝트를 만든다.
            //2.총알을 Prefab화 한다.
            //3.스크립트를 활용하여, 총알을 Hierarchy(Scene)에 생성한다
            GameObject insBullet = Instantiate(bullet);
            insBullet.transform.position = this.gameObject.transform.position;

            //총알의 앞 방향은 Player = 이 스크립트가 들어가있는 게임오브젝트의 앞 방향이다.
            insBullet.transform.forward = this.gameObject.transform.forward;

            //총알에게 물리적인 힘을 만들어주는 컴포넌트를 추가한다.
            Rigidbody rb = insBullet.AddComponent<Rigidbody>();
            rb.useGravity = false;

            PlayShootSound();

            GameObject se = Instantiate(shootEffect, effectSpot);
            se.transform.localPosition = Vector3.zero;
            se.transform.localRotation = Quaternion.identity;
        }


        HpUI();
    }

    void HpUI()
    {
        hpText.text = "HP : " + health;
        hpBarImage.fillAmount = (float)health / (float)maxHp;
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _animator.SetBool("isMove", true);
            this.gameObject.transform.Translate(0, 0, 10 * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("isMove", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _animator.SetBool("isBackMove", true);
            this.gameObject.transform.Translate(0, 0, -10 * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("isBackMove", false);
        }

        //만약에 왼쪽 방향키를 누르고 있다면 이 스크립트가 들어가 있는 게임오브젝트를 회전시켜라 왼쪽으로 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
        //만약에 오른쪽 방향키를 누르고 있다면 이 스크립트가 들어가 있는 게임오브젝트를 오른쪽으로 회전시켜라
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
        //만약에 왼쪽 컨트롤 키를 누르면
        //이 스크립트가 들어가 있는 게임 오브젝트의 물리적인 작용을 아래에서 위로 힘을 가한다.
        if(isGround == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                _animator.SetTrigger("jump");
                this.gameObject.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.up * 300);
                isGround = false;
            }
        }       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            print("장애물과 부딪힘");
        }

        if (other.gameObject.tag == "Enemy")
        {
            print("적과 부딪힘");
        }

        if(other.gameObject.tag == "EnemyBullet")
        {
            //총을 맞았다.
            //1. 체력이 닳았다.
            health = health - damage;
            Destroy(other.gameObject);
            CheckHealth();

        }
    }


    void CheckHealth()
    {
        //2. 만약에 체력이 0보다 적으면 죽는다.
        if (health < 0)
        {
            //죽는다
            _gameManager.playerNum = 0;
            Destroy(this.gameObject);
        }
    }

//1. 체력을 관리하는 변수
//2. 적의 총알을 맞았는걸 관리하는 코드
//3. 체력의 0보다 작아져서 사라지는걸 관리하는 코드

    void PlayShootSound()
    {
        audiosource.Play();
    }
}
