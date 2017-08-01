using UnityEngine;

public class Score : MonoBehaviour {
    public static int score = 0;
    public static int ScoreNumber = 40;
    //public Display_UI_Text display;

    public static void IncreaseScore(int number)
    {
        score += number;
    }

    void Update()
    {
        //display.TextToDisplay("Score: " + score.ToString());
    }
        



}
