using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int moveSpeed = 5;
    public int rotateSpeed = 90;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
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
