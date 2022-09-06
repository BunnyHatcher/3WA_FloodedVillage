using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator2 : MonoBehaviour
{
    int SizeX = 5;
    int SizeY = 5;

    public GameObject SandPrefab;
    [SerializeField] private GameObject Level;

    

    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < SizeX; x++)
        {
            for (int y = 0; y < SizeY; y++)
            {
                var spawnedTile = Instantiate(SandPrefab, new Vector3(x, y, 0), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                
            }
        }
    }

    
}
