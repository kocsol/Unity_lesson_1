using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int moveSpeed = 5;
    public int rotateSpeed = 90;
    bool isActive;
    int a;
    public GameObject bullet; // 유니티에서 수정 할 수 있게 public 으로 그래서 prefab을 bullet에 넣어주면 됨
    int health;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.LeftShift))    //방아쇠를 당긴다.
        {
            //총알을 발사한다.

            //1. 총알이라는 게임오브젝트를 만든다. --> 게임오브젝트 변수를 하나 새로 만들어준다.

            //2.총알을 Prefab화한다.
            //3. 스크립트를 활용하여. 총알을 Hierarchy(Scene)에 생성한다.
            GameObject insBullet = Instantiate(bullet);    //꼭 알아두기 지역변수로 사용한 이유는 여기서만 사용해서 메모리 누수를 막기위해서
            //4. 총알의 위치는 3차원 player 의 위치
            insBullet.transform.position = this.gameObject.transform.position;
            //초알의 앞 방향은 Player = 이 스크립트가 들어가 있는 게임오프브젝틔의 앞 방향이다.
            insBullet.transform.forward = this.gameObject.transform.forward;

            //총알에게 물리적인 힘을 만들어주는 컴포넌트를 추가한다. 그리고 중력때문에 떨어지니 빼줘야한다. 
            Rigidbody rb = insBullet.AddComponent<Rigidbody>();
            rb.useGravity = false;
        }
    }
        void Move()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.gameObject.transform.Translate(0, 0, moveSpeed * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.gameObject.transform.Translate(0, 0, -moveSpeed * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.gameObject.transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);

            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

            }
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.up * 300); // 나의 기준으로 누워서 up은 y축이 아님
                this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);   // 절대방향 이건 무조건 y축

            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                //this.gameObject.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

        }
        public void OnButtonClick()
        {
            print("버튼 클릭");
        }
        private void OnCollisionEnter(Collision collision)   //충동했다면
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Obstacle")    //other라는 콜라디어가 들어가 있는 오브젝트의 태그가 Obstacle이라면
            {
                print("장애물과 부딛힘");
            }
            if (other.gameObject.tag == "Enemy")    //other라는 콜라디어가 들어가 있는 오브젝트의 태그가 Obstacle이라면
            {
                print("적과 부딛힘");
            }

        }


}
