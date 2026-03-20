using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector3 viewDistance = new Vector3(0,0, -5);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = player.transform.position + viewDistance; 
    }
}
