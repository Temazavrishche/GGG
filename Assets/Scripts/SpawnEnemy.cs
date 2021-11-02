using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject SkeletonPrefab;
    public float SpawnRate,countdown = 2, waveNumber = 1,NumberSkeleton = 1;
    private void Update()
    {
        if (countdown <= 0)
        {
            StartCoroutine(spawnWave());
            countdown = SpawnRate;
        }
        countdown -= Time.deltaTime;
    }

    IEnumerator spawnWave()
    {
        waveNumber++;
        for (int i = 0; i < waveNumber; i++)
        {
            spawn();
            yield return new WaitForSeconds(0.3f);
        }
    }
    private void spawn()
    {
        GameObject enemy =  Instantiate(SkeletonPrefab, new Vector3(Random.Range(-100, -135), 0, Random.Range(10, -53)), Quaternion.identity);
        enemy.name = "Enemy#" + NumberSkeleton;
        NumberSkeleton++;
    }
}
