using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{

public GameObject[] spawnPrefab;


    // Start is called before the first frame update
    void Start()
    {
        float randXPos = Random.Range(-13.54f, 224.3f);
        float randYPos = Random.Range(0.64f, 12.11f);

        transform.position = new Vector2 (randXPos, randYPos);

        int randNum = Random.Range(0, spawnPrefab.Length);

        if (spawnPrefab[randNum] == null ) return;

        Instantiate(spawnPrefab[randNum], transform.position, transform.rotation);
    }

}
