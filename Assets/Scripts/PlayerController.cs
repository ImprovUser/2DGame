using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /*
    public InputAction LeftAction;
    public InputAction RightAction;
    public InputAction UpAction;
    public InputAction DownAction;
    */
    public InputAction MoveAction;
    Rigidbody2D rigidbody2D;
    Vector2 move;
    void Start()
    {
        /*
        LeftAction.Enable();
        RightAction.Enable();
        UpAction.Enable();
        DownAction.Enable()
        */;

        MoveAction.Enable();
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {


        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        /*
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;
        */

        /*
         * 
        float horizontal = 0.0f;
        float vertical = 0.0f;
        if(LeftAction.IsPressed())
        {
            horizontal = -1.0f;
        }
        else if (RightAction.IsPressed())
        {
            horizontal = 1.0f;
        }

        if(UpAction.IsPressed())
        {
            vertical = 1.0f;
        }
        else if(DownAction.IsPressed())
        {
            vertical = -1.0f;
        }

        
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);

        if(Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1.0f;
        }
        else if(Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        
        Vector2 position = transform.position;
        position.x = position.x + 0.07f * horizontal;
        position.y = position.y + 0.07f * vertical;
        transform.position = position;
        */
    }
    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2D.position + move * 3.0f * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }
}


