using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCandy : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    float hight;
    [SerializeField] GameObject[] _candy;

    private void Start()
    {
        hight=transform.position.y;
        InvokeRepeating("Spawn", 1, 2);
    }

    void Spawn()
    {
        Instantiate(_candy[Random.Range(0, 4)], new Vector2(Random.Range(min, max), hight), Quaternion.identity);
    }
}
