using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }
}
