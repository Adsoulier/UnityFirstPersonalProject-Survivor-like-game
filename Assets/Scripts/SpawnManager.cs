using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int numberOfEnemiesOnScreen = 20 ;
    public GameObject[] enemiesPrefab;

    private Transform playerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length < numberOfEnemiesOnScreen)
            SpawnEnemyAroundPlayer();
    }

    // actually spawns enemies through the whole screen, needs some tweaking and maybe to set it up in a InvokeRepeating
    private void SpawnEnemyAroundPlayer()
    {
        //float minDistance = 3.0f;
        float yBoundaries = 8.5f;
        float xBoundaries = 12.6f;
       // float xDistance = Random.Range(playerTransform.position.x - minDistance,playerTransform.position.x + minDistance);
       // float yDistance = Random.Range(playerTransform.position.y - minDistance,playerTransform.position.y + minDistance);
        float xDistance = Random.Range(-xBoundaries, xBoundaries);
        float yDistance = Random.Range(-yBoundaries, yBoundaries);
        int enemyType = Random.Range(0,enemiesPrefab.Length);
        Instantiate(enemiesPrefab[enemyType], new Vector3(xDistance, yDistance, 0), enemiesPrefab[enemyType].transform.rotation);
    }
}
