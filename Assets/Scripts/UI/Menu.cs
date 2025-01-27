using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MEnu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] PlayerControls playerControls;
    public InputAction openPauseMenu;

    

    private void Awake()
    {
        pauseMenu.SetActive(false);

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    
    void Update()
     {
        
     }


    // is called when P is press
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale=0;
    

    }
    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale=1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1;
    }





}

