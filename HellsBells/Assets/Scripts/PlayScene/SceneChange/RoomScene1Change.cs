using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomScene1Change : MonoBehaviour
{
    [SerializeField]
    private Fade fade;
    [SerializeField]
    private DoorOpen door;

    // Update is called once per frame
    void Update()
    {
        if (door.GetFlag())
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("HallScene1"));
            door.SetFlag(false);        // ñ¯úÌÉAiÌtrueðð¯é
        }

    }
}
