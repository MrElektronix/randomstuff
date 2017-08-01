using UnityEngine;

public class CollisionDetection : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            if (Lives.lives > 0)
            {
                Lives.DecreaseLives(1);
            }
            else
            {
                Lives.lives = 0;
            }

        }
    }
}
