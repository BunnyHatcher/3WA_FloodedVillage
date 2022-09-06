using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public enum TileTypes
{
    Sand,
    Water,
    Empty,
}
*/

public class LevelGenerator : MonoBehaviour
{
    public TileTypes[,] LevelGrid;
    public GameObject SandPrefab;
    public GameObject WaterPrefab;
    public GameObject EmptyPrefab;

    private void Start()
    {
       //------------------Create the data that will be filled in-----------------------
        
        LevelGrid = new TileTypes[5, 5];

        //first index corresponds to rows, the second to columns
        
        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[0, i] = TileTypes.Water;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[1, i] = TileTypes.Water;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[2, i] = TileTypes.Water;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[3, i] = TileTypes.Water;
        }

        for (int i = 0; i < 5; i++) // using for loop to create rows faster
        {
            LevelGrid[4, i] = TileTypes.Water;
        }

        
        
        

      for (int i = 0; i < 5; i++)
      { GeneratePrefabs(); }
    }


    //------------------Generating the prefabs-----------------------

    private void GeneratePrefabs()
    {

        // Empty by default
        GameObject newInstance = EmptyPrefab;
                 
        if (LevelGrid[0, 0] == TileTypes.Sand)
        {
            newInstance = SandPrefab;
        }

        if (LevelGrid[0, 0] == TileTypes.Water)
        {
            newInstance = WaterPrefab;
        }

        if (LevelGrid[0, 0] == TileTypes.Empty)
        {
            newInstance = EmptyPrefab;
        }

        GameObject g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(0, 0);



        //-----------2nd Tile------------------------

        //we reinitialize the variable newInstance
           
        if (LevelGrid[0, 1] == TileTypes.Sand)
        {
            newInstance = SandPrefab;
        }

        if (LevelGrid[0, 1] == TileTypes.Water)
        {
            newInstance = WaterPrefab;
        }

        if (LevelGrid[0, 1] == TileTypes.Empty)
        {
            newInstance = EmptyPrefab;
        }

        //we reinitialize g
        g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(1, 0);

        
        //-----------3nd Tile------------------------

        //we reinitialize the variable newInstance

        if (LevelGrid[0, 2] == TileTypes.Sand)
        {
            newInstance = SandPrefab;
        }

        if (LevelGrid[0, 2] == TileTypes.Water)
        {
            newInstance = WaterPrefab;
        }

        if (LevelGrid[0, 2] == TileTypes.Empty)
        {
            newInstance = EmptyPrefab;
        }

        //we reinitialize g
        g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(2, 0);

        //-----------4th Tile------------------------

        //we reinitialize the variable newInstance

        if (LevelGrid[0, 2] == TileTypes.Sand)
        {
            newInstance = SandPrefab;
        }

        if (LevelGrid[0, 2] == TileTypes.Water)
        {
            newInstance = WaterPrefab;
        }

        if (LevelGrid[0, 2] == TileTypes.Empty)
        {
            newInstance = EmptyPrefab;
        }

        //we reinitialize g
        g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(3, 0);

        //-----------5th Tile------------------------

        //we reinitialize the variable newInstance

        if (LevelGrid[0, 2] == TileTypes.Sand)
        {
            newInstance = SandPrefab;
        }

        if (LevelGrid[0, 2] == TileTypes.Water)
        {
            newInstance = WaterPrefab;
        }

        if (LevelGrid[0, 2] == TileTypes.Empty)
        {
            newInstance = EmptyPrefab;
        }

        //we reinitialize g
        g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(4, 0);




    }
}
