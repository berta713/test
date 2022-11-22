using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float xRange = 8.5f;
    private float zPos = -1.5f;
    public float yPos = 6f;
    public float barrelYPos = -2f;

    public GameObject barrelPrefab;
    public GameObject swordPrefab;
    public GameObject bombPrefab;
    public GameObject potionPrefab;

    private float minBarrelTime = 5f;
    private float maxBarrelTime = 10f;
    private float minSwordTime = 0.5f;
    private float maxSwordTime = 2f;
    private float minBombTime = 2f;
    private float maxBombTime = 4f;
    private float minPotionTime = 7f;
    private float maxPotionTime = 15f;

    void Start()
    {
        Invoke("SpawnBarrel", minBarrelTime);
        Invoke("SpawnSword", minSwordTime);
        Invoke("SpawnBomb", minBombTime);
        Invoke("SpawnPotion", minPotionTime);
    }

    void SpawnBarrel()
    {
        Vector3 spawnPos = new Vector3(xRange, barrelYPos, zPos);
        float randomTime = Random.Range(minBarrelTime, maxBarrelTime);
        Instantiate(barrelPrefab, spawnPos, barrelPrefab.transform.rotation);

        Invoke("SpawnBarrel", randomTime);
    }

    void SpawnSword()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, zPos);
        float randomTime = Random.Range(minSwordTime, maxSwordTime);
        Instantiate(swordPrefab, spawnPos, swordPrefab.transform.rotation);

        Invoke("SpawnSword", randomTime);
    }

    void SpawnBomb()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, zPos);
        float randomTime = Random.Range(minBombTime, maxBombTime);
        Instantiate(bombPrefab, spawnPos, bombPrefab.transform.rotation);

        Invoke("SpawnBomb", randomTime);
    }

    void SpawnPotion()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, zPos);
        float randomTime = Random.Range(minPotionTime, maxPotionTime);
        Instantiate(potionPrefab, spawnPos, potionPrefab.transform.rotation);

        Invoke("SpawnPotion", randomTime);
    }

    void Update()
    {
        
    }
}
