using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryButton : MonoBehaviour
{
    public Button ContinueButton;
    public Button OptionsButton;
    public Button StorySettingsButton;
    public Button NewGameButton;

    public bool isToggled = false;

    void Start ()
    {
        isToggled = false;

        StorySettingsButton.gameObject.SetActive(false);
        NewGameButton.gameObject.SetActive(false);
	}
	
	void Update ()
    {
		
	}

    public void ClickContinueButton()
    {
        SceneManager.LoadScene("LaunchScene", LoadSceneMode.Single);
        Debug.Log("Continue Clicked");
    }

    public void ClickOptionsButton()
    {
        if (isToggled)
        {
            isToggled = false;

            StorySettingsButton.gameObject.SetActive(false);
            NewGameButton.gameObject.SetActive(false);
        }

        else if (!isToggled)
        {
            isToggled = true;

            StorySettingsButton.gameObject.SetActive(true);
            NewGameButton.gameObject.SetActive(true);
        }
    }

    public void ClickStorySettingsButton()
    {
        Debug.Log("Story Settings Clicked");
    }

    public void ClickNewGameButton()
    {
        Debug.Log("New Game Clicked");
    }
}
