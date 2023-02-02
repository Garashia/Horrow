using System;
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
    private GameObject obake;

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
            door.SetFlag(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
        if(cupManager.IsExamie())
        {
            room1.SetDestroyFlag(false);
            obake.SetActive(true);
            StartCoroutine(Scale());
            fade.FadeIn(2f, () => SceneManager.LoadScene("RoomScene1"));
            cupManager.SetExamie(false);        // ”ñ“¯Šúˆ—ŒÌ‚ÉA‰i‰“‚Ìtrue‚ğ”ğ‚¯‚é
        }
    }


    IEnumerator Scale()
    {
        for(int i = 0; i < 300; i++)
        {
            obake.transform.localScale += new Vector3(0.3f, 0.3f, 0.0f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
