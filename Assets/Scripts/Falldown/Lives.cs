using UnityEngine;

public class Lives : MonoBehaviour {

    public static int lives = 3;


    public static void DecreaseLives(int number)
    {
        lives -= number;
    }
}
