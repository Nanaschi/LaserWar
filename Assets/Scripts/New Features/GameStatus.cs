using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(0, 10)] [SerializeField] float gameSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SettingTheGamePace();
    }

    private void SettingTheGamePace() 
    {
        Time.timeScale = gameSpeed;
        if (Input.GetButtonDown("Cancel") && gameSpeed == 1f)
        {
            gameSpeed = 0;
            FindObjectOfType<GamePannel>().CreateGamePannel();
            var escUI = GameObject.Find("Abilities");
            Destroy(escUI);
            return;
        } 
       if (Input.GetButtonDown("Cancel") && gameSpeed == 0f)
        {
            gameSpeed = 1;
            FindObjectOfType<GamePannel>().DestroyThePannel();
            return;
        } 
    }
    
}
