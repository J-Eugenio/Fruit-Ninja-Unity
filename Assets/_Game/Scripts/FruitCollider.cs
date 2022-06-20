using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollider : MonoBehaviour
{
    private Fruit fruit;
    // Start is called before the first frame update
    void Start()
    {
        fruit = this.gameObject.GetComponent<Fruit>();
    }

    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("Blade")){
            GameObject tempFluitSliced = Instantiate(fruit.fruitsSliced, transform.position, Quaternion.identity);
            tempFluitSliced.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().AddForce(-tempFluitSliced.transform.GetChild(0).transform.right * Random.Range(5f, 10f), ForceMode.Impulse);
            tempFluitSliced.transform.GetChild(1).gameObject.GetComponent<Rigidbody>().AddForce(tempFluitSliced.transform.GetChild(1).transform.right * Random.Range(5f, 10f), ForceMode.Impulse);

            if(tempFluitSliced.transform.childCount == 3 ){//Fruit Plum
                tempFluitSliced.transform.GetChild(2).gameObject.GetComponent<Rigidbody>().AddForce(tempFluitSliced.transform.GetChild(2).transform.up * Random.Range(5f, 10f), ForceMode.Impulse);
                tempFluitSliced.transform.GetChild(2).gameObject.GetComponent<Rigidbody>().AddForce(tempFluitSliced.transform.GetChild(2).transform.right * Random.Range(3f, 6f), ForceMode.Impulse);
            }

            Destroy(tempFluitSliced, 5f);
            Destroy(this.gameObject);
        }
    }
}
