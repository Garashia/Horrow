using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables; //TimelineÇÃêßå‰Ç…ïKóv

public class EndChange : MonoBehaviour
{
    //[SerializeField]
    //private GameObject space;

    [SerializeField]
    private Endingroll endingroll;

    private PlayableDirector playable;
    // Start is called before the first frame update
    void Start()
    {
        playable = gameObject.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(endingroll.GetAfterEnd())
        {
            //space.SetActive(true);
            playable.Play();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }

        
    }
}
