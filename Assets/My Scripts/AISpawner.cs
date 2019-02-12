using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace S1
{
    public class AISpawner : NetworkBehaviour
    {
        public GameObject spawnPrefab;
        public int numberToSpawn = 15;
        public int timeTillSpawn = 5;


        // Use this for initialization
        void Start()
        {
            if (isServer)
            {
                StartCoroutine(SpawnAfterSomeTime());
            }

        }

        IEnumerator SpawnAfterSomeTime()
        {
            yield return new WaitForSeconds(timeTillSpawn);

            for (int i = 0; i < numberToSpawn; i++)
            {
                GameObject spawnGO = (GameObject)Instantiate(spawnPrefab, transform.position, transform.rotation);
                NetworkServer.Spawn(spawnGO);

            }
        }
    }
}

