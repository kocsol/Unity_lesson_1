using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    float interval;
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
        if (interval > 5)
        {
            Destroy(this.gameObject);
        }
    }
}
