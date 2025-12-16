using NUnit.Framework.Constraints;
using UnityEngine;

public class Sniper : MonoBehaviour, IGun
{
    private int ammoCount = 3; 
    private float delay = 1.25f;
    private float reloadT = 2.5f;
    private float timerR; 
    private float timerF;
    private bool canFier = true; 
    public GameObject BulletS;
    public Transform bulletTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!canFier)
        {
            timerF += Time.deltaTime;
            if(timerF > delay)
            {
                canFier = true;
            }
        }
    }

    public void Reload()
    {
        if(ammoCount == 0 || Input.GetKey(KeyCode.R))
        {
            timerR += Time.deltaTime;
            if(timerR > reloadT)
            {
               ammoCount = 3;  
            }
        }
    }
    public void Shoot()
    {
        if (canFier && ammoCount > 0)
        {
            Instantiate(BulletS,bulletTransform.position,Quaternion.identity);
            ammoCount--;
            canFier = false; 
        }
    }
}
