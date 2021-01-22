using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject winUI;
    public ItemBox[] ItemBoxes;

    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // using UnityEngine.SceneManagement;
            // 여기서 SceneManager 호출
            // SceneManager.LoadScene("Main");
            SceneManager.LoadScene(0);
        }

        if(isGameOver == true)
        {
            return;
        }

        int count = 0;
        for(int i = 0; i < 3; i++)
        {
            if(ItemBoxes[i].isOveraped)
            {
                count++;
            }
        }
        
        if(count >= 3)
        {
            Debug.Log("게임 승리!");
            isGameOver = true;
            winUI.SetActive(true);
        }
    }
}
