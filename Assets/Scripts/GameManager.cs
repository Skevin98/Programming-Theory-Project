using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Monster");
        if (enemies.Length == 0 && !gameOver)
        {
            gameOver = true;
            Debug.Log("You Win !");
        }
    }
}
