using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollider : MonoBehaviour
{
    private Fruit fruit;
    private GameController gameController;
    private UIController uIController;
    private AudioController audioController;
    // Start is called before the first frame update
    void Start()
    {
        fruit = this.gameObject.GetComponent<Fruit>();
        gameController = FindObjectOfType<GameController>();
        uIController = FindObjectOfType<UIController>();
        audioController = FindObjectOfType<AudioController>();
    }

    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("Blade")){
            target.gameObject.GetComponent<AudioSource>().clip = audioController.bladeAudio[Random.Range(0, audioController.bladeAudio.Length)];
            target.gameObject.GetComponent<AudioSource>().Play();
            GameObject tempFluitSliced = Instantiate(fruit.fruitsSliced, transform.position, Quaternion.identity);
            tempFluitSliced.gameObject.GetComponent<AudioSource>().clip = audioController.fruitSplashAudio[Random.Range(0, audioController.fruitSplashAudio.Length)];
            tempFluitSliced.gameObject.GetComponent<AudioSource>().Play();
            GameObject tempSplash = Instantiate(gameController.splash, tempFluitSliced.transform.position, Quaternion.identity);
            gameController.UpdateScore(this.gameObject.GetComponent<Fruit>().points);
            tempSplash.GetComponentInChildren<SpriteRenderer>().color = fruit.ChangeSplashColor(this.gameObject);
            tempFluitSliced.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().AddForce(-tempFluitSliced.transform.GetChild(0).transform.right * Random.Range(5f, 10f), ForceMode.Impulse);
            tempFluitSliced.transform.GetChild(1).gameObject.GetComponent<Rigidbody>().AddForce(tempFluitSliced.transform.GetChild(1).transform.right * Random.Range(5f, 10f), ForceMode.Impulse);

            if(tempFluitSliced.transform.childCount == 3 ){//Fruit Plum
                tempFluitSliced.transform.GetChild(2).gameObject.GetComponent<Rigidbody>().AddForce(tempFluitSliced.transform.GetChild(2).transform.up * Random.Range(5f, 10f), ForceMode.Impulse);
                tempFluitSliced.transform.GetChild(2).gameObject.GetComponent<Rigidbody>().AddForce(tempFluitSliced.transform.GetChild(2).transform.right * Random.Range(3f, 6f), ForceMode.Impulse);
            }

            Destroy(tempFluitSliced, 5f);
            Destroy(this.gameObject);
        } else if (target.gameObject.CompareTag("Destroyer")){
            gameController.fruitCount++;
            if(gameController.fruitCount <= 3){
                uIController.imgLives[gameController.fruitCount - 1].color = gameController.uiRedColor;
            }
            if(gameController.fruitCount >= 3){
                uIController.ShowPanelGameOver();
            }
        }
    }
}
