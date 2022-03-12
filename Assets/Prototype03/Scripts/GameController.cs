using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int monsters = 0;
    public bool killedAll = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (monsters <= 0)
        {
            killedAll = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        }
        else {
            killedAll = false;
            
        }
    }
}
