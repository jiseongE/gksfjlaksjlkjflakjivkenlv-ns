using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager s_Instance;
    public static GameManager Instance { get { Init(); return s_Instance; } }
    
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void Init()
    {
        GameObject go = GameObject.Find("@GameManager");
        if (go == null)
        {
            go = new GameObject { name = "@GameManager"};
            go.AddComponent<GameManager>();
        }

        DontDestroyOnLoad(go);
        s_Instance = go.GetComponent<GameManager>();
    }
}
