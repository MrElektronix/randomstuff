using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float speed = 13f;

	
	// Update is called once per frame
	private void Update () {
        var x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, 0);
	}
}
