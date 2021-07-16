using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    

    void Start() 
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = _spawnPosition.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
