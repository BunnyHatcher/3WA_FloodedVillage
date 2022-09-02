using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileTypes
{
    Sand,
    Water,
    Empty,
}

public class LevelGenerator : MonoBehaviour
{
    public TileTypes[,] LevelGrid;
    public GameObject SandPrefab;
    public GameObject WaterPrefab;
    public GameObject EmptyPrefab;

    private void Start()
    {
        LevelGrid = new TileTypes[5, 5];

        //first index corresponds to rows, the second to columns
        
        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[0, i] = TileTypes.Sand;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[0, i] = TileTypes.Sand;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[0, i] = TileTypes.Sand;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[0, i] = TileTypes.Sand;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[0, i] = TileTypes.Sand;
        }

        GeneratePrefabs();
    }

    private void GeneratePrefabs()
    {
        

        if(LevelGrid[0, 0] == TileTypes.Sand)
        {
            
        }

        if (LevelGrid[0, 0] == TileTypes.Water)
        {
            Instantiate(WaterPrefab, new Vector2(0, 0), Quaternion.identity, transform);
        }

        if (LevelGrid[0, 0] == TileTypes.Empty)
        {
            Instantiate(EmptyPrefab, new Vector2(0, 0), Quaternion.identity, transform);
        }

        //GameObject g = Instantiate(newInstance, transform);
        //g.transform.localPosition = new Vector2(0, 0);
    }
}
