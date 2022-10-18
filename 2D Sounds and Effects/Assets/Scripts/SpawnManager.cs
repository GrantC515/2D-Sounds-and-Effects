using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 _spawnPos = new Vector3(15, -3.5f, 0);
    private float _startDelay = 2;
    private float _repeatRate = 3;

    private PlayerController _playerScript;

    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if(_playerScript.isGameOver == false)
        {
            Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
        }
       
    }
}
