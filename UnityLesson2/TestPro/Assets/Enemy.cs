using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health;
    int damage;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)    
        {
            Destroy(this.gameObject);
        }
    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")//내가 부딪힌 것이 총알이라면
        {
            health = health - damage;
            print("내 현재 체력은" + health + "입니다.");
        }   
    }
}
