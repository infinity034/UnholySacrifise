using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public InputActionReference pauseGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        pauseGame.action.started += OpenPauseMenu;
        Debug.Log("Done");
    }

    void OnDisable()
    {
        pauseGame.action.started -= OpenPauseMenu;
    }

    
    //Est appeller quand la touche ESC est press ( en temps normal...)
    private void OpenPauseMenu(InputAction.CallbackContext context)
    {
        Debug.Log("TABARNAK");
    }






}
