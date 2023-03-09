using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyReference;
    [SerializeField]
    private Transform rightPos;

    private GameObject spawnedEnemies;
    
    private int randomIndex;

    [HideInInspector]
    public static float count = 10f;

    /*private float dCount = ();*/ 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Update()
    {
        /*Debug.Log(dCount);*/
    }

    private void FixedUpdate()
    {
        if (ScoreCounter.scoreCountInInt % 100 == 0 && ScoreCounter.scoreCountInInt >= 100)
        {
            count += 0.15f;
            Debug.Log("Counter: " + ScoreCounter.scoreCountInInt);
            Debug.Log("count: " + count);
        }
    }

    IEnumerator SpawnEnemies()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.5f, 0.7f));

            randomIndex = Random.Range(0, enemyReference.Length);

            spawnedEnemies = Instantiate(enemyReference[randomIndex]);

            spawnedEnemies.transform.position = rightPos.position;
            spawnedEnemies.GetComponent<Enemy>().speed = -count/1.2f;
        }


    }





















}
