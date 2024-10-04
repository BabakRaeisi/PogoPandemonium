using System;
using UnityEngine;

[Serializable]
public class Node
{
    public Vector2Int Coordinates { get; private set; }
    public Tile Tile { get; private set; }

    // Occupied status
    public bool IsOccupied { get { return isOccupied; } set { isOccupied = value; } }

    private PlayerData owner;  // Private field to store the owner

    public PlayerData Owner
    {
        get { return owner; }   // Getter returns the current owner
        set
        {
            owner = value;
            NodeColor = owner.PlayerColor;  // Update node color when the owner is set
        }
    }

    // Node color updates the tile when changed
    private Color nodeColor;
    private bool isOccupied;

    public Color NodeColor
    {
        get { return nodeColor; }
        set
        {
            nodeColor = value;
            Tile.SetColor(nodeColor); // Automatically update tile appearance
        }
    }

    public Node(Vector2Int coordinates, Tile tile)
    {
        Coordinates = coordinates;
        Tile = tile;
        NodeColor = Color.white;  // Default color is white
        isOccupied = false;
        owner = null;  // No owner at initialization
    }

    // Set the owner and automatically update the color based on the owner's PlayerColor
    public void SetOwner(PlayerData player)
    {
        Owner = player;  // This will automatically update the node color
    }
}
