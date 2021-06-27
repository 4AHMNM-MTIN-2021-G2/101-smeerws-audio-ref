using UnityEngine;

public class MazeController : MonoBehaviour
{
    public GameData myGameData;
    public GameObject entrance;

    private AnimateDoor entranceAnim;

    // Start is called before the first frame update
    void Start()
    {
        entranceAnim = entrance.GetComponent<AnimateDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myGameData.isDoorOpened && myGameData.isPlayerInMaze)
        {
            entranceAnim.StartCloseDoorAnimation();
        }
    }
}
