using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update

    void Start()
    {
        
	}

	// Update is called once per frame
	
	void Update()

    {
        if (Input.GetMouseButtonDown(0))  //0,1,2�� ��,��,�� //ray xray���� ī�޶󿡼� ������ ��
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ray�� ��ž� ���콺�� Ŭ���� ��ġ��
            RaycastHit hitInfo;  // ���̰� �ε�����
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Destroy(hitInfo.collider.gameObject);
            }
        

    }
   
}
