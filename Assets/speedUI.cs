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

    private Slider slider;

    void Start()
    {
        bird = GameObject.Find("/prefabs/bird");
        script = bird.GetComponent<ThirdPersonCharacterControl>();
        text = GetComponentInChildren<Text>();
        slider = GetComponentInChildren<Slider>();
    }
    void Update()
    {
        speed = script.Speed;
        text.text = "VALUE: " + speed.ToString(); 
        slider.value = speed;
        
        if (speed > 5);
        {
        // slider = Color.red;
        // var fill = (slider as UnityEngine.UI.Slider).GetComponentsInChildren<UnityEngine.UI.Image>().FirstOrDefault(t => t.name == "Fill");
        var fill = GameObject.Find("Fill").GetComponentInChildren<Image>();
        fill.color = Color.Lerp(Color.green, Color.red, slider.value /8);
        }
    
    }
    
}
