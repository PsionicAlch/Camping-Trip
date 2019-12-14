using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampFire : MonoBehaviour {
    public GameObject[] enemies;
    public GameObject stickPrefab;
    public Text score;

    [Space(3)]
    public float waitingForNextSpawn = 1;
    public float theCountdown = 1;

    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;

    private int stickCount = 0;
    private int numSticks = 0;

    void Update() {
        theCountdown -= Time.deltaTime;

        if(theCountdown <= 0) {
            SpawnEnemies();
            theCountdown = waitingForNextSpawn;
        }

        if(this.stickCount <= 25) {
            SpawnSticks();
            this.stickCount += 1;
            // Debug.Log("Spawned a stick: " + this.stickCount);
        }

        this.score.text = "Score: " + this.numSticks.ToString();
    }

    void SpawnEnemies() {
        Vector3 pos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), -1); 
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        Instantiate(enemyPrefab, pos, Quaternion.Euler(0, 0, 0));
    }

    void SpawnSticks() {
        Vector3 pos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), -1);
        Instantiate(stickPrefab, pos, Quaternion.Euler(0, 0, 0));
    }

    public void PickUpStick() {
        Debug.Log("Picked Up Stick!");
        this.stickCount -= 1;
        this.numSticks += 1;
    }
}
