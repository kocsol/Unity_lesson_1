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
        if (Input.GetMouseButtonDown(0))  //0,1,2중 왼,오,휠 //ray xray생각 카메라에서 나가는 빛
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ray를 쏠거야 마우스가 클릭한 위치에
            RaycastHit hitInfo;  // 레이가 부딪힌곳
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Destroy(hitInfo.collider.gameObject);
            }
        

    }
   
}
