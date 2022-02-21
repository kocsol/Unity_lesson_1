using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    int cubeNum; //선언
    int sceneNum;
    
    void Start()
    {
        cubeNum = 0;
        print(cubeNum);
        GameObject tt = GameObject.Find("Test1");
        if (tt != this.gameObject)
        {
            Destroy(GameObject.Find("Test1"));
        }
        DontDestroyOnLoad(this.gameObject);
	}

    private void OnEnable()
    {
        print(cubeNum);
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
                if (hitInfo.collider.tag == "Finish")
                {
                    Destroy(hitInfo.collider.gameObject);
                    cubeNum++; // 큐브가 사라질때마다 일씩 늘어나게 해주기
                }
            }
        }
        if (cubeNum == 5)
        {
            if (sceneNum ==0)
            {
                SceneManager.LoadScene(1);
                sceneNum = 1;
                cubeNum = 0;
            }
            else if (sceneNum == 1)
            {

                SceneManager.LoadScene(0);   
                sceneNum = 0;
                cubeNum = 0;
            }
            
            
        }



    }
}
