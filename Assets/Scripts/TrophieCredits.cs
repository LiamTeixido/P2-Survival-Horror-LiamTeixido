using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using GameJolt.API;
using UnityEngine.SceneManagement;

public class TrophieCredits : MonoBehaviour
{
    void Awake()
    {
        Trophies.TryUnlock(216235);
    }
    
}
