using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public static SceneManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public class DisableUI : MonoBehaviour
    {

        [SerializeField] public GameObject objectToDisable;
        void Update()
        {
            // "if" to disable specific GameObject
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (objectToDisable != null)
                {
                    objectToDisable.SetActive(false);
                    Debug.Log(objectToDisable.name + " disabled.");
                }
            }
        }
    }
}
