using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallScene1Change : MonoBehaviour
{

    [SerializeField] 
    private Fade fade;
    [SerializeField]
    private ExamineManager examine;
    [SerializeField]
    private DoorOpen door;

    [SerializeField]
    private FinalObjectManager finalObjectManager;

    [SerializeField]
    private DestroyFlag room1;


    // Update is called once per frame
    void Update()
    {
        if(examine.GetExaminedFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("HallScene2"));
            examine.SetExaminedFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
        else if(door.GetFlag())
        {
            room1.SetDestroyFlag(true);
            fade.FadeIn(1f, () => SceneManager.LoadScene("RoomScene1"));
            door.SetFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
        else if(finalObjectManager.GetClearFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("End"));
            finalObjectManager.SetClearFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
    }

}
