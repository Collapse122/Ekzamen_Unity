using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour
{
    public void LoadLevelScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void LoadMenuLevelScene()
    {
        SceneManager.LoadScene("MenuLevelScene");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1Scene");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2Scene");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3Scene");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4Scene");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level5Scene");
    }

    public void LoadLevel6()
    {
        SceneManager.LoadScene("Level6Scene");
    }
}
