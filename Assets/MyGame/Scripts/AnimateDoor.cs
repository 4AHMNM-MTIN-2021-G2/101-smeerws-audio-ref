using UnityEngine;

public class AnimateDoor : MonoBehaviour
{
    public GameData myGameData;
    private Animator myAnimator;


    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void StartOpenDoorAnimation()
    {
        myAnimator.SetBool("openDoor", true);
        myGameData.isDoorOpened = true;
    }

    public void StartCloseDoorAnimation()
    {
        myAnimator.SetBool("openDoor", false);
        myGameData.isDoorOpened = false;
    }
}
