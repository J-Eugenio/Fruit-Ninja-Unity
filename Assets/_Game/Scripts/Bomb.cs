using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate(){
        
        //Random.Range(0, speed)
        transform.Rotate(new Vector3(0, speed, 0f) * Time.deltaTime);
    }
}
