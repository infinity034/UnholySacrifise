using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //Est appeller quand le boutton pause est appuyer
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
    //
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1;
    }
    


}
