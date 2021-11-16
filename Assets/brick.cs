using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
 private Rigidbody _rigidbody;
 private BrickManager _brickManager;
   private bool sleep;
   private Vector3 lastSpeed;
    void Awake()
    {
        _brickManager = FindObjectOfType<BrickManager>();
        _rigidbody = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
    }

    public void Activated()
    {
        transform.tag = "BrickActive";
        _brickManager.add(this);
        _rigidbody.isKinematic = false;
       // Invoke("Sleep",3f);

    }

    public void Sleep()
    {
        if (!sleep)
        {
            lastSpeed = _rigidbody.velocity;
            _rigidbody.isKinematic = true;
            sleep = true;

        }
            

    }
    // Update is called once per frame
    void Update()
    {
        if (sleep)
        {

            if (transform.position.y > 0.5f)
            {
                transform.Translate(lastSpeed);
                
            }
            else
            {
                this.enabled = false;


            }
            
            
        }   
        
    }
}
