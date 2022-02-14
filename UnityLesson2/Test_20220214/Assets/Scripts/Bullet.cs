using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    float interval;//시간에 대한 변수
    // Start is called before the first frame update
    void Start()
    {
        //이 스크립트가 들어가 있는 게임오브젝트에게 물리적인 힘을 앞 방향으로 주어라.
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(this.gameObject.transform.forward * 500);
    }

    // Update is called once per frame
    void Update()
    {
        interval += Time.deltaTime;                
        if (interval > 5)//5초가 지났다면
        {
            Destroy(this.gameObject);
        }
    }
}
