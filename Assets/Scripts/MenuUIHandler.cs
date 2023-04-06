using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    //static MenuUIHandler Instance;

    //private void Awake()
    //{

    //    if (MenuUIHandler.Instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }
    //    Instance = this;
    //    DontDestroyOnLoad(gameObject);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.gameOver = false;
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
