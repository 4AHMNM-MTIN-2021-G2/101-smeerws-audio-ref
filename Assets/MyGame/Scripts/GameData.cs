using UnityEngine;

[CreateAssetMenu(menuName = "GameData")]
public class GameData : ScriptableObject, ISerializationCallbackReceiver 
{
    public bool isDoorOpened;
    public bool isPlayerInMaze;

    public void OnAfterDeserialize()
    {
        // Reset Data
        isDoorOpened = false;
        isPlayerInMaze = false;
    }

    public void OnBeforeSerialize(){}
}
