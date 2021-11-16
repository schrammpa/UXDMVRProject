using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public List<brick> _Bricks = new List<brick>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add(brick brick)
    {

        if (_Bricks.Count > 10)
        {
            _Bricks[0].Sleep();
            _Bricks.Remove(_Bricks[0]);
            
            if (!_Bricks.Contains(brick))
            {
                _Bricks.Add(brick);     
            }  
        }
        else
        {
            if (!_Bricks.Contains(brick))
            {
                _Bricks.Add(brick);     
            }  
            
        }


        
       
    }
}
