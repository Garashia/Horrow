using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallScene2Change : MonoBehaviour
{
    [SerializeField]
    private Fade fade;
    [SerializeField]
    private ExamineManager examine;
    [SerializeField]
    private DoorOpen door1;
    [SerializeField]
    private DoorOpen door2;

    // Update is called once per frame
    void Update()
    {
        if(examine.GetExaminedFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("HallScene1"));
            examine.SetExaminedFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
        else if(door1.GetFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("RoomScene2"));
            door1.SetFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
        else if (door2.GetFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("RoomScene3"));
            door2.SetFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }

    }
}
