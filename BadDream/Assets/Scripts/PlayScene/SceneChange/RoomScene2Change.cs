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

    // Update is called once per frame
    void Update()
    {
        if(door.GetFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("HallScene2"));
            door.SetFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
        if(cupManager.IsExamie())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("RoomScene1"));
            cupManager.SetExamie(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
    }
}
