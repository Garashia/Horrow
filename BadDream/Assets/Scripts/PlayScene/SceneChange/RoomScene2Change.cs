using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomScene2Change : MonoBehaviour
{
    [SerializeField]
    private Fade fade;
    [SerializeField]
    private DoorOpen door;

    [SerializeField]
    private CupManager cupManager;

    [SerializeField]
    private DestroyFlag room1;

    // Update is called once per frame
    void Update()
    {
        if(door.GetFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("HallScene2"));
            door.SetFlag(false);        // �񓯊������̂ɁA�i����true�������
        }
        if(cupManager.IsExamie())
        {
            room1.isDead = false;
            fade.FadeIn(1f, () => SceneManager.LoadScene("RoomScene1"));
            cupManager.SetExamie(false);        // �񓯊������̂ɁA�i����true�������
        }
    }
}
