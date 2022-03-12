using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depth_movement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2.5f;
    private float originalZ;
    // Start is called before the first frame update
    void Start()
    {
        originalZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * speed, 15) + originalZ);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }
   
}
