using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float speed, startForce;
    [SerializeField] private GameObject beamLight;
    private Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = this.gameObject.GetComponent<Rigidbody2D>();
        ApplyForce();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void ApplyForce(){
        myRB.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }
    private void Rotate(){
        //Random.Range(0, speed)
        transform.Rotate(new Vector3(Random.Range(0, speed), speed, 0f) * Time.deltaTime);
    }

    public void BombGameOver(){
        speed = 0f;
        myRB.bodyType = RigidbodyType2D.Kinematic;
        myRB.simulated = false;
        CircleCollider2D myCollider = this.gameObject.GetComponent<CircleCollider2D>();
        myCollider.enabled = false;
        GameObject tempBeamLight = Instantiate(beamLight, this.transform.position, Quaternion.identity) as GameObject;
    }
}
