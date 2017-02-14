using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public GameObject enemy;
	List<GameObject> enemies;
	public int numEnemies;
	public float spawnTime;
	public static bool playerAlive;
	public static float score;
	public Button restartButton;
	public Text text;

	void Start () {
		score = 0;
		enemies = new List<GameObject>();
		for (int i = 0;i<numEnemies;i++){
			GameObject en = (GameObject)Instantiate(enemy);
			en.SetActive(false);
			enemies.Add(en);
		}
		playerAlive = true;
		InvokeRepeating("Spawn",spawnTime,spawnTime);
		restartButton.gameObject.SetActive(false);
	}

	void Update(){
		if(playerAlive){
			score+=Time.deltaTime;
		}
		if(!playerAlive){
			text.text = "You are dead! Your score is " + score.ToString("0") + ".";
			restartButton.gameObject.SetActive(true);
		}
		Debug.Log(Screen.height + " " + Screen.width);
	}
	
	void Spawn() {
		for (int i = 0;i<enemies.Count;i++){
			if(!enemies[i].activeInHierarchy){
				enemies[i].GetComponent<EnemyMove>().Reset();
				enemies[i].transform.position = new Vector2(Random.Range(-2,2),5);
				enemies[i].transform.rotation = transform.rotation;
				enemies[i].GetComponent<EnemyMove>().speed = Random.Range(5,20);
				enemies[i].SetActive(true);
				break;
			}
		}
	}

	public void restartGame(){
		SceneManager.LoadScene("pWings");

	}
}
