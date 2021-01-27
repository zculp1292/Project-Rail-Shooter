using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        Invoke("LoadFirstScene", 5f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
