using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{

    public GameObject ColumnPrefab;
    public int ColumnPoolSize = 5;
    public float SpawnRate = 1f;
    public float ColumnMin = -1f;
    public float ColumnMax = 3.5f;

    private GameObject[] Columns;
    private Vector2 ObjectPoolPosition = new Vector2(-10f, -20f);
    private float TimeSinceLastSpawned;
    private float SpawnXPosition = 3f;
    private int CurrentColumn = 0;

    // Start is called before the first frame update
    void Start()
    {

        Columns = new GameObject[ColumnPoolSize];

        for (int i = 0; i < ColumnPoolSize; i++)
        {
            Columns[i] = (GameObject)Instantiate(ColumnPrefab, ObjectPoolPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

        TimeSinceLastSpawned += Time.deltaTime;

        if(GameControl.instance.GameOver == false && TimeSinceLastSpawned >= SpawnRate)
        {

            TimeSinceLastSpawned = 0;
            float SpawnYPosition = Random.Range(ColumnMin, ColumnMax);
            Columns[CurrentColumn].transform.position = new Vector2(SpawnXPosition, SpawnYPosition);
            CurrentColumn++;
            if (CurrentColumn >= ColumnPoolSize)
                CurrentColumn = 0;
        }

    }
}
