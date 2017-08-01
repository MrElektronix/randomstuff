using UnityEngine;

public class Timer : MonoBehaviour {

	public static int Timing = 0;

    private void Start()
    {
        InvokeRepeating("IncreaseTime", 1f, 1f);
    }

    private void IncreaseTime()
    {
        Timing += 1;
        if (Timing == 10)
        {
            Score.IncreaseScore(Score.ScoreNumber);
        }
    }

    private void Update()
    {
        
    }
}
