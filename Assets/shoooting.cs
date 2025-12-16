using Unity.Mathematics;
using UnityEngine;

public class shoooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos; 
    private bool canFier = true;
    public GameObject  BulletS; 
    public Transform bulletTransform;
    private float timer; 
    public float delay;
    
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

        if (!canFier)
        {
            timer+= Time.deltaTime;
            if (timer > delay)
            {
                canFier = true;
                timer = 0f; 
            }
        }

        if (Input.GetMouseButton(0)&& canFier)
        {
            canFier = false;
            Instantiate(BulletS, bulletTransform.position, quaternion.identity);
        }
    }
}
