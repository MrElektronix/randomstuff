using UnityEngine;
using UnityEngine.UI;

public class Display_UI_Text : MonoBehaviour {
    public Text[] textToDisplay;

    /*
    public void TextToDisplay(string displaytext)
    {
        for (int i = 0; i < text.Length; i++)
        {
            text[i].text = displaytext;
        } 
    }
    */

    float oldScore = 100, oldLives = 50, oldTime = 100;


    void Update()
    {
        if (Score.score != oldScore || Lives.lives != oldLives || Timer.Timing != oldTime)
        {
            for (int i = 0; i < textToDisplay.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        textToDisplay[i].text = "Score: " + Score.score.ToString();
                        break;
                    case 1:
                        textToDisplay[i].text = "Lives: " + Lives.lives.ToString();
                        break;
                    case 2:
                        textToDisplay[i].text = "Time: " + Timer.Timing.ToString();
                        break;
                    default:
                        break;
                }
            }
            oldScore = Score.score;
            oldLives = Lives.lives;
            oldTime = Timer.Timing;
        }
    }
        
}
