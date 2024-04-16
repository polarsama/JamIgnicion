using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;
public class GenerarEnemigos : MonoBehaviour
{

    public Transform yGeneratorUp;
    public Transform yGeneratorDown;

    public GameObject enemigos;
    public float TimeSpawn = 1;
    public float SpawnTime = 2.5f;

    // Start is called before the first frame update
    void Start()
    { 
        InvokeRepeating("Generar", TimeSpawn, SpawnTime);
    }

    void Generar()
    {
        Vector3 spawnPosition = new Vector3(1.15f, 0,0);

        spawnPosition = new Vector3(1.15f, Random.Range(yGeneratorUp.position.y, yGeneratorDown.position.y),0);

        Instantiate(enemigos, spawnPosition, gameObject.transform.rotation);
    }
}
