using UnityEngine;
using UnityEngine.SceneManagement;
public class WIn_Detection : MonoBehaviour
{
    public int overall_Score = 0;
    public Scoring_Balls top_l;
    public Scoring_Balls top_m;
    public Scoring_Balls top_r;
    
    public Scoring_Balls bot_l;
    public Scoring_Balls bot_m;
    public Scoring_Balls bot_r;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( overall_Score >= 15 )//Checking if all balls had been potted
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Reload scene code from https://discussions.unity.com/t/how-to-restart-the-game-174448/174448
        }
        overall_Score = top_l.score + top_m.score + top_r.score + bot_l.score + bot_m.score + bot_r.score;//Checking all pockets for their score and adding together
    }

   }
