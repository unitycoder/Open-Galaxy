using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionBriefing : MonoBehaviour
{
    public AudioSource missionBriefingAudio;

    public void StartGame()
    {
        MissionBriefingFunctions.StartGame(this);
    }


}
