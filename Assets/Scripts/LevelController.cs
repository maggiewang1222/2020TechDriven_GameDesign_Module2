using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    
    [SerializeField]string _nextLevelName;

    Nut[] _monsters;

    void OnEnable()
    {
        _monsters = FindObjectsOfType<Nut>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MonstersAreAllDead())
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

     bool MonstersAreAllDead()
    {
       foreach(var monster in _monsters)
        {
            if (monster.gameObject.activeSelf)
                return false;
        }

        return true;
    }
}
