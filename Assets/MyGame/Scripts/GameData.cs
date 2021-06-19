using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : ScriptableObject, ISerializationCallbackReceiver 
{ 
    public void OnAfterDeserialize()
    {
       // Reset Data
    }

    public void OnBeforeSerialize(){}
}
