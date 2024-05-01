using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string SceneName;

    public GameObject CanvasMenuScreen;

    public GameObject CanvasControlsScreen;

    // Start is called before the first frame update
    void Start()
    {
        CanvasMenuScreen.SetActive(true);
        CanvasControlsScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ChangeToControlsScreen()
    {
        CanvasControlsScreen.SetActive(true);

        CanvasMenuScreen.SetActive(false);
    }

    public void ChangeToMenuScreen()
    {
        CanvasMenuScreen.SetActive(true);

        CanvasControlsScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
