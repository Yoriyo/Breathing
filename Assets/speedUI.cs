using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedUI : MonoBehaviour
{
    private GameObject prefabs;
    public GameObject bird;
    public ThirdPersonCharacterControl script;

    public float speed;
    public Text text;

    void Start()
    {
        bird = GameObject.Find("/prefabs/bird");
        script = bird.GetComponent<ThirdPersonCharacterControl>();
        text = GetComponentInChildren<Text>();
    }
    void Update()
    {
        speed = script.Speed;
        text.text = "CODE : " + speed.ToString(); 
    }
}
