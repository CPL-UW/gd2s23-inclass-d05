using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    public Tilemap backgroundTilemap;
    public TileBase roadTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (null == Camera.main) return;
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var cellPosition = backgroundTilemap.WorldToCell(mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            backgroundTilemap.SetTile(cellPosition, roadTile);
        }
    }
}
