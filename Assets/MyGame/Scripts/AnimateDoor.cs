using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{

    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void StartOpenDoorAnimation()
    {
        myAnimator.SetBool("openDoor", true);
        //myGameData.isDoorOpened = true;
    }
}
