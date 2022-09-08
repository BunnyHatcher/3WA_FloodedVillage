using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    Sand = 2,
    Water = 1,
    Empty = 0
    //Enums cannot be transformed into Strings, only into numbers
}

public class LevelGenerator2 : MonoBehaviour
{
    public int width = 5;
    public int height = 5;

    public TileType[,] LevelGrid;
    public byte[,] myGrid; // necessary to create array according to our preferences

    public GameObject SandPrefab;
    public GameObject WaterPrefab;
    public GameObject EmptyPrefab;

    [SerializeField] private GameObject Level;





    // Start is called before the first frame update
    void Start()
    {

        myGrid = new byte[8, 8]
        {
            {1,2,2,2,2,2,0,2},
            {1,2,2,2,2,2,0,2},
            {1,2,2,0,0,2,0,2},
            {1,2,1,2,0,0,0,2},
            {1,1,1,2,0,2,2,2},
            {1,2,0,0,0,2,1,2},
            {1,2,2,2,2,2,2,2},
            {1,2,2,2,2,2,2,2}
        };

        GenerateGrid();

        Propagation();
        Debug.Log(myGrid[0, 6]);

        

    }
        
        public void GenerateGrid()
        {
        
        for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                var spawnedTile = Instantiate(SandPrefab, new Vector3(x, y, 0), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                
                }
            }
        
        }

    void Propagation() // needs to be revised
    {

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)

            {
                if (
                    myGrid[x, y] == 0
                    && (myGrid[x + 1, y] == 1 //put or conditions into brackets
                    || myGrid[x - 1, y] == 1
                    || myGrid[x, y + 1] == 1
                    || myGrid[x, y - 1] == 1)
                    )
                {
                    myGrid[x, y] = 1;
                    Debug.Log("Propagation");
                    /*Destroy(myGrid[x, y]);
                    Instantiate(WaterPrefab, myGrid[x, y].transform.position, Quaternion.identity);
                    */

                    Propagation();
                }

            }
        }
    }

    

}
