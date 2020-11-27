using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    
    [SerializeField]string _nextLevelName;

    Nut[] nutsOnLevel;

    void OnEnable()
    {
        nutsOnLevel = FindObjectsOfType<Nut>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AreAllNutsCollected())
        {
          GoToNextLevel();
        }
    }

     void GoToNextLevel()
    {
        if (string.IsNullOrEmpty(_nextLevelName))
            Application.Quit();
        
        SceneManager.LoadScene(_nextLevelName);
    }

     bool AreAllNutsCollected()
    {
       foreach(var monster in nutsOnLevel)
        {
            if (monster.gameObject.activeSelf)
                return false;
        }

        return true;
    }
}
