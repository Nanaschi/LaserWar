using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectingSkills : MonoBehaviour
{
    [Range (1, 10)][SerializeField] int increasingAmount = 1;
    [Range(1, 10)] [SerializeField] int decreasingAmount1 = 1;
    [Range(1, 10)] [SerializeField] int decreasingAmount2 = 2;
    [Range(1, 10)] [SerializeField] int decreasingAmount3 = 3;
    [SerializeField] GameObject skillPannel;
    public int SkillCost ()
    {
        return decreasingAmount1;
    }
    public void IncreasingTheScore()
    {
        
        
            FindObjectOfType<GameSession>().AddToScore(increasingAmount);
        
        
    }
    public void DecreasingAmount1()
    {
        var hello = decreasingAmount1;
        if (FindObjectOfType<GameSession>().GetScore() > 0)
        {
          FindObjectOfType<GameSession>().ReduceTheScore(decreasingAmount1);
          
            
        }
       

    }
    public void DecreasingAmount2()
    {
        if (FindObjectOfType<GameSession>().GetScore() > 1)
            FindObjectOfType<GameSession>().ReduceTheScore(decreasingAmount2);
     
    }
    public void DecreasingAmount3()
    {
        if (FindObjectOfType<GameSession>().GetScore() > 2)
            FindObjectOfType<GameSession>().ReduceTheScore(decreasingAmount3);
   

    }

    public void HoverOn1()
    {
       FindObjectOfType<SkillCost>().UpdateDisplay(decreasingAmount1);
       // Debug.Log("Hovered");
    }
    public void HoverOn2()
    {
        FindObjectOfType<SkillCost>().UpdateDisplay(decreasingAmount2);
       // Debug.Log("Hovered");
    }
    public void HoverOn3()
    {
        FindObjectOfType<SkillCost>().UpdateDisplay(decreasingAmount3);
       // Debug.Log("Hovered");
    }
    public void HoverOff()
    {
        FindObjectOfType<SkillCost>().UpdateDisplay(0);
        Debug.Log("Dehovered");
    }

}
