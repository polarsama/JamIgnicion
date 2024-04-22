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
    public Transform xGeneratorLeft;
    public Transform xGeneratorRight;

    public GameObject enemigos;
    public float TimeSpawn = 3;
    public float SpawnTime = 5f;
    public float IncrementoSpawn;
    public float LapsoNivel;
    public float IncrementoLapso;

    // Start is called before the first frame update
    void Start()
    { 
        InvokeRepeating("Generar", TimeSpawn, SpawnTime);
    }

    void Generar()
    {
        Vector3 spawnPosition = new Vector3(0, 0,0);

        spawnPosition = new Vector3(Random.Range(xGeneratorLeft.position.x, xGeneratorRight.position.x), Random.Range(yGeneratorUp.position.y, yGeneratorDown.position.y),0);

        Instantiate(enemigos, spawnPosition, gameObject.transform.rotation);
    }

    private void Update()
    {
        if(Time.time > LapsoNivel)
        {
            SpawnTime -= Random.Range(IncrementoSpawn, -0.1f);
            TimeSpawn -= Random.Range(IncrementoSpawn, -0.1f);
            LapsoNivel += IncrementoLapso;
        }
    }
}
