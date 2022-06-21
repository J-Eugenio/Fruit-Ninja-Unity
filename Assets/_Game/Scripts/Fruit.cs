using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Rigidbody2D myRB;
    [SerializeField] private float startForce;
    public GameObject fruitsSliced;
    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        myRB = this.gameObject.GetComponent<Rigidbody2D>();
        gameController = FindObjectOfType<GameController>();
        ApplyForce();
    }

    private void ApplyForce(){
        myRB.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }

    public Color32 ChangeSplashColor(GameObject GO){
        string cloneObjectName = GO.transform.name;
        Color32 defaultColot = new Color32(255, 255, 255, 255);

        switch (cloneObjectName)
        {
            case "Apple_G(Clone)":
                return gameController.apple_gColor;
            case "Apple_R(Clone)":
                return gameController.apple_rColor;
            case "Banana(Clone)":
                return gameController.bananaColor;
            case "Coconut(Clone)":
                return gameController.coconutColor;
            case "HoneydewMelon(Clone)":
                return gameController.honeydewMelonColor;
            case "Kiwi(Clone)":
                return gameController.kiwiColor;
            case "Lemon(Clone)":
                return gameController.lemonColor;
            case "Lime(Clone)":
                return gameController.limeColor;
            case "Orange(Clone)":
                return gameController.orangeColor;
            case "Pear(Clone)":
                return gameController.pearColor;
            case "Pepper_G(Clone)":
                return gameController.pepper_gColor;
            case "Pepper_Pointed(Clone)":
                return gameController.pepper_pointedColor;
            case "Pepper_R(Clone)":
                return gameController.pepper_rColor;
            case "Pepper_Y(Clone)":
                return gameController.pepper_yColor;
            case "Pineapple(Clone)":
                return gameController.pineapleColor;
            case "Plum(Clone)":
                return gameController.plumColor;
            case "Pomegranate(Clone)":
                return gameController.pomegranateColor;
            case "Strawberry(Clone)":
                return gameController.strawberryColor;
            case "Tomato(Clone)":
                return gameController.tomatoColor;
            case "Watermelon(Clone)":
                return gameController.watermelonColor;
            default:
            return defaultColot;
        }
    }
}
