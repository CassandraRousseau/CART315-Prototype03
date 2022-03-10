using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;
	int enemiesLeft= 0;
	bool killedEnemies = false;

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
			//if health has fallen below zero, deactivate it 
			gameObject.SetActive (false);
			enemiesLeft--;
			if (enemiesLeft == 0) {
				endGame();
			}
		}
	}
	void Start() {
		enemiesLeft = 10;
	
	}
	void Update() {
		/*GameObject[] enemies = GameObject.FindGameObjectWithTag("Enemy");*/
		/*enemiesLeft=enemies.Length;*/
	
	}
	void endGame()
    {
		killedEnemies = true;
		if (killedEnemies) {
			UnityEngine.SceneManagement.SceneManager.LoadScene("EndGame");

		}
    }
}
