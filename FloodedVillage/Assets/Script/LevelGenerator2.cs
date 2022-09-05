using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator2 : MonoBehaviour
{
    int SizeX = 5;
    int SizeY = 5;

    public GameObject SandPrefab;

    

    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<SizeX; i++)
        {
            for (int j = 0; j<SizeY; j++)
            {
                Instantiate(SandPrefab, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }

    
}
