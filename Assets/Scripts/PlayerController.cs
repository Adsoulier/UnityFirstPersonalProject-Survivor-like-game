using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rigiBody;
    
    private float speed = 8.0f;
    private Vector2 movement;

    public GameObject projectilePrefab;

    public Transform visuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigiBody = GetComponent<Rigidbody2D>();
        visuals = transform.Find("Visuals");
    }

    // Update is called once per frame, getting the input infos
    void Update()
    {
    TrackPlayerMouse();
    movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));     
    if(Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(projectilePrefab,visuals.position, visuals.rotation);
    }
}

    // FixedUpdate to avoid micro stutter and such
    void FixedUpdate()
    {
        rigiBody.linearVelocity = movement * speed ;
    }

    // Made with IA, will Implement my own way when I get a deeper understanding of angles and getting the user's mouse
    //It doesn't work as intended but is here just for a proof of GamePlay
    private void TrackPlayerMouse()
    {
    Vector3 mousePos =
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

    Vector2 direction = mousePos - visuals.position;

    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

    visuals.rotation = Quaternion.Euler(0f, 0f, angle);    
    }
    
}
