using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePannel : MonoBehaviour
    
{
    [SerializeField] GameObject SkillPannel;
    public void CreateGamePannel()
    {
        var skillPannelUI = Instantiate(SkillPannel, transform.position, transform.rotation);
        skillPannelUI.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
       // var abilities = GameObject.Find("Abilities");
       // Destroy(abilities);
    }
    public void DestroyThePannel()
    {
      
        Destroy(gameObject);
    }
}
