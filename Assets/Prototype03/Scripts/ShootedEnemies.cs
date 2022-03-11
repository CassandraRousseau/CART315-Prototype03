using UnityEngine;
using System.Collections;

public class ShootedEnemies : MonoBehaviour
{
	GameController gc;
	//The box's current health point total
	public int currentHealth = 3;

	void Start()
	{
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		gc.monsters++;

	}

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0)
		{
			//if health has fallen below zero, deactivate it 
			Destroy(gameObject);
			gc.monsters--;
		}

	
	}
}

