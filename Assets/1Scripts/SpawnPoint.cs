using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemyFactory;

    float currentTime;
    public float createTime;

    float minT=0;
    float maxT=1;
    // Start is called before the first frame update
    void Start()
    {
        createTime = Random.Range(minT, maxT);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 1, 0);

        currentTime += Time.deltaTime;
        if(currentTime > createTime) {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.forward = transform.forward;
            enemy.transform.position = transform.position;
            createTime = Random.Range(minT, maxT);
            currentTime = 0;
        }
    }
}
