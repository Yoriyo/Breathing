using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Variable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bird;
    public ThirdPersonCharacterControl script;

    public float Speed;

    public Text speedText;

    void Start()
    {
        bird = GameObject.Find("bird");
        script = bird.GetComponent<ThirdPersonCharacterControl>();
    }

    // Update is called once per frame
    void Update()
    {
        script.Speed = Speed;
        speedText.text = Speed.ToString();
    }
}
