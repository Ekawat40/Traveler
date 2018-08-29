using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tilePrefabs;

    public float TileSize
    {
       get { return tilePrefabs[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
    }


    // Use this for initialization
    void Start()
    {
        CreateLevel();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void CreateLevel()
    {

        string[] mapData = new string[]
        {
             "0000","1111","2222","3333"
        };

        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
        for (int y = 0; y < 10; y++)  //grass row y
        {
            for (int x = 0; x < 10; x++)   //grass row x

            {
                PlaceTile("1",x,y,worldStart);
              
            }

        }
    }
    private void PlaceTile(string tileType, int x, int y, Vector3 worldStart)  //worldStart = topleftCorner in camera
    {
        int tileIndex = int.Parse(tileType);  //Change "1" = 1


        GameObject newTile = Instantiate(tilePrefabs[tileIndex]);
        newTile.transform.position = new Vector3(worldStart.x + (TileSize * x) , worldStart.y - (TileSize * y), 0);

    }
}
