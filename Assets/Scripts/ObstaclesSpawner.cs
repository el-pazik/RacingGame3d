using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePref;
    [SerializeField] private Transform startPoint;
    [SerializeField] private float diff_x = 5;
    [SerializeField] private float diff_z = 10;

    private float counter_z = 0;

    

    private void Update()
    {
        if(transform.position.z >= startPoint.position.z + diff_z * counter_z)
        {
            SpawnObstacles();
            counter_z++;
        }
    }

    private void SpawnObstacles()
    {
        List<GameObject> obstacles = new List<GameObject>();
        for(int i = 0; i < Random.Range(1, 5); i++)
        {
            GameObject newObstacle = Instantiate(obstaclePref, startPoint);
            newObstacle.transform.position = new Vector3(Random.Range(startPoint.position.x - diff_x, startPoint.position.x + diff_x),
                0,
                Random.Range(startPoint.position.z + diff_z * (counter_z + 1), startPoint.position.z + diff_z * (counter_z + 2)));
        }
    }
}
