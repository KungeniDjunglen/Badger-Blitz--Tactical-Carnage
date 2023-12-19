using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("SampleScene");
    }
        public void Level2()
    {
        SceneManager.LoadScene(2);
    }
        public void Level3()
    {
        SceneManager.LoadScene(3);
    }
}
