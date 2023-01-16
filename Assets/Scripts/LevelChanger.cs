using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public int nextLevelID;
    private int levelToLoad;

    // Update is called once per frame
    void Update()   {
            if (Input.GetKeyDown(KeyCode.Space))    {
                FadeToLevel(nextLevelID);
            }
    }

    public void FadeToLevel (int levelIndex)    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()    {
        SceneManager.LoadScene(levelToLoad);
    }
}
