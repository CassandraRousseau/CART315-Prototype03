using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal_movement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2.5f;
    private float originalX;
    // Start is called before the first frame update
    void Start()
    {
        originalX = transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3) + originalX, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndGame");
        }

    }

}
