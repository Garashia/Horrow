using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //TimelineÇÃêßå‰Ç…ïKóv

public class ChangeAnimationManager : MonoBehaviour
{

    [SerializeField]
    private DestroyFlag room1;
    [SerializeField]
    private GameObject sleepPlayer;
    private PlayableDirector playableDirector;



    // Start is called before the first frame update
    void Start()
    {
        if (!room1.GetDestroyFlag())
            PlayTimeline();
        else
        { 
            GameObject playerObject = GameObject.FindWithTag("Player");
            playerObject.transform.position = new Vector3(12.6f, playerObject.transform.position.y, playerObject.transform.position.z);
            sleepPlayer.SetActive(false);
        }
    }

    private void PlayTimeline()
    {
        playableDirector = gameObject.GetComponent<PlayableDirector>();
        playableDirector.Play();
    }
}
