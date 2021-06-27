using UnityEngine;

public class InMazeTrigger : MonoBehaviour
{
    public GameData myGameData;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "BodyCollider")
        {
            myGameData.isPlayerInMaze = true;
        }
    }
}
