using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed; //public variable uses Pascal casing
    float move;  //private variable

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal"); //x - axis

        //use rigidbody2d to move left and right (x-axis)
        rb2d.linearVelocity = new Vector2(move * Speed, rb2d.linearVelocity.y);
    }
}
