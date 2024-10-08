using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    private string playerName; // Name of the player

    [SerializeField]
    private float speed = 5f; // Speed of the player, default value can be set here

    [SerializeField]
    private Color playerColor = Color.white; // Color associated with the player, default to white

    [SerializeField]
    private int points = 0; // Points the player has, default to 0


    [SerializeField]
    private float speedRotation = 5f; // Speed at which the player rotates   
   [SerializeField]
    private Vector2Int currentGridPosition; // Private field to store the current grid position

    // Public property to access and modify current grid position
    public Vector2Int CurrentGridPosition
    {
        get { return currentGridPosition; } // Getter to return the current value
        set { currentGridPosition = value; } // Setter to update the value
    }

    // Public properties to expose private fields
    public string PlayerName
    {
        get => playerName;
        private set => playerName = value; // Can set internally if needed
    }

    public float Speed
    {
        get => speed;
        private set => speed = value; // Can set internally if needed
    }

    public Color PlayerColor
    {
        get => playerColor;
        private set => playerColor = value; // Can set internally if needed
    }
  

    public int Points
    {
        get => points;
        private set => points = value; // Can set internally if needed
    }

 

    public float SpeedRotation
    {
        get => speedRotation;
        private set => speedRotation = value; // Can set internally if needed
    }

    // Method to add points
    public void AddPoints(int amount)
    {
        Points += amount;
    }

    // Method to reset points, if needed
    public void ResetPoints()
    {
        Points = 0;
    }

 
}
