using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenLU : MonoBehaviour
{
    [SerializeField]
    private GameObject CarLSPrefab;

    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnCars()
    {
        while (true)
        {
            float spawnDelay = TimeSelecter();
            yield return new WaitForSeconds(spawnDelay);

            Instantiate(CarLSPrefab, transform.position, Quaternion.identity);
        }
    }

    private float TimeSelecter()
    {
        float RandTime = Random.Range(1f, 5f);
        return (RandTime);
    }
}
