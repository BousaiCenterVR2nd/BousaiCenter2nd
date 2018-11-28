using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SCENES
{
    TITLE = 0,
    TUTORIAL,
    MAP1,
    GAMEOVER,
    CLEAR
    
}

static public class SceneManage
{

    static public void SceneMove(SCENES NextScene)
    {

        SceneManager.LoadScene((int)NextScene);

    }
}