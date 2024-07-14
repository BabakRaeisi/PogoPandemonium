using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridManager : MonoBehaviour
{
    [SerializeField] Vector2Int gridSize;
    [SerializeField] int unityGridSize;
    public int UnityGridSize { get { return unityGridSize; } }

    Dictionary<Vector2Int, Node> grid = new Dictionary<Vector2Int, Node>();
    public Dictionary<Vector2Int, Node> Gride { get { return grid; } }

    private void Awake()
    {
       initializeGrid();
    }

    void initializeGrid()
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                Vector2Int cords = new Vector2Int(x, y);
                grid.Add(cords, new Node(cords));

            }
        }
    }
    public Node GetNode(Vector2Int pos) 
    {
        if (grid.ContainsKey(pos))
        {
            return grid[pos];
        }
        return null;
    }
  


}

    


