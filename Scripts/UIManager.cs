using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //[SerializeField] private Text levelText;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject menuButton;
    [SerializeField] private GameObject playButton;

    public string MyWorld { get; private set; }

    private void Awake()
    {
        //Assert.IsNotNull(levelText);
        Assert.IsNotNull(menu);
    }

    public void toggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }

    //Set the button available on the device's screen
    public void menubuttonClicked()
    {
        menuButton.SetActive(false);
    }

    public void TogglePause()
    {
        //Time.timeScale is to slow down the rate at which the frames are rendered
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
    }

    public void playbuttonClicked()
    {
        //Time.timescale value is set to 1, once the play button is clicked
        Time.timeScale = 1;
        menu.SetActive(false);
        menuButton.SetActive(true);
    }
}