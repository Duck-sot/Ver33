using UnityEngine;

public class shoooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos; 
    private bool canFier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = GameObject.FindAnyObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 Rotation = mousePos - transform.position; 
        float rotZ =  Mathf.Atan2(Rotation.y, Rotation.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotZ);

        //if
    }
}
