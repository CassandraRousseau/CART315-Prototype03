using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical_movement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2.5f;
    private float originalY;

    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, 3) + originalY,  transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }
}
