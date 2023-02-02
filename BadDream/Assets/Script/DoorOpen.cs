using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //TimelineÇÃêßå‰Ç…ïKóv

public class DoorOpen : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag destroyFlag;
    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

    [SerializeField]
    private Animator animator = null;
    private GameObject playerObject;
    [SerializeField]
    private float sizeNorth;
    [SerializeField]
    private float sizeSouth;
    [SerializeField]
    private float sizeEast;
    [SerializeField]
    private float sizeWest;
    private bool flag;
    [SerializeField]
    private PlayableDirector playableDirector;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        playerObject = GameObject.FindWithTag("Player");
        flag = false;
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject.transform.position.x - sizeEast < transform.position.x &&
            playerObject.transform.position.x + sizeWest > transform.position.x &&
            playerObject.transform.position.y - sizeSouth < transform.position.y &&
            playerObject.transform.position.y + sizeNorth > transform.position.y)
        {
            if (IsActive)
                message.SetActive(true);
            else
                message.SetActive(false);
            if (Input.GetKey(KeyCode.Space))
            {
                message.SetActive(false);
                IsActive = false;
                //animator.SetTrigger("door");
                PlayTimeline();
                //flag = true;
            }
        }
        else
        {
            message.SetActive(false);
        }
    }
    //void OnPlayableDirectorStopped(PlayableDirector aDirector)
    //{
    //    if (playableDirector == aDirector)
    //        Debug.Log("PlayableDirector named " + aDirector.name + " is now stopped.");
    //}
    private void PlayTimeline()
    {
        destroyFlag.SetDestroyFlag(true);
        playableDirector.Play();
    }
    void OnEnable()
    {
        playableDirector.stopped += IsDone;
    }
    void OnDisable()
    {
        playableDirector.stopped -= IsDone;
    }
    private void IsDone(PlayableDirector aDirector)
    {
        if (playableDirector == aDirector)
            flag = true;
        else flag = false;
        //
    }
    public bool GetFlag()
    {
        return flag;
    }
    public void SetFlag(bool mFlag)
    {
        flag = mFlag;
    }
}
