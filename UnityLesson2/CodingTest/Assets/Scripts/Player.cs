using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    int cubeNum; //����
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
        if (Input.GetMouseButtonDown(0))  //0,1,2�� ��,��,�� //ray xray���� ī�޶󿡼� ������ ��
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ray�� ��ž� ���콺�� Ŭ���� ��ġ��
            RaycastHit hitInfo;  // ���̰� �ε�����
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                if (hitInfo.collider.tag == "Finish")
                {
                    Destroy(hitInfo.collider.gameObject);
                    cubeNum++; // ť�갡 ����������� �Ͼ� �þ�� ���ֱ�
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
