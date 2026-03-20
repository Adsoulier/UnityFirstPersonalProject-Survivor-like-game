using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    
    // For later Use with a proper input method
    //public InputActionReference moveAction;
    
    private float speed = 10f;
    private Vector2 movement;
/*
    private void OnEnable()
    {
        moveAction.action.Enable();
    }
*/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //Vector2 moveInput = moveAction.action.ReadValue<Vector2>();
      movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));     
    }

    void FixedUpdate()
    {
        //rb.linearVelocity = movement * speed;
        transform.Translate(movement * speed * Time.deltaTime);
    }
    
/*
        private void OnDisable()
    {
        moveAction.action.Disable();
    }
*/
}
