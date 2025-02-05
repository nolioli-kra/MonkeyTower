using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaSpawner : MonoBehaviour
{
    public GameObject bananaPrefab;
    public GameObject bombPrefab;
    public float bombChance;
    public List<Transform> windowSlots;
    private bool bananaTriggered = false;

    public void OnTriggerEnter(Collider other)
    {
        //SpawnItem();
        if (other.CompareTag("window"))
        {
            SpawnItem();
            bananaTriggered = true;
        }
    }

    private void SpawnItem()
    {
        int randomIndex = Random.Range(0, windowSlots.Count);
        Transform spawnPosition = windowSlots[randomIndex];
        
        if (Random.value < bombChance)
        {
            Instantiate(bombPrefab, spawnPosition.position, Quaternion.identity);
        }
        else
        {
            Instantiate(bananaPrefab, spawnPosition.position, Quaternion.identity);
        }
    }
}