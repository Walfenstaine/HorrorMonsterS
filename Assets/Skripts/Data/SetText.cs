using UnityEngine;
using UnityEngine.UI;


public class SetText: MonoBehaviour
{
    public Data data;
    [SerializeField] private Language language;

    private void Start()
    {
        Text myText = GetComponent<Text>(); 
        if (data.language == "ru")
        {
            myText.text = language.ru;
        }
        else
        {
            if (data.language == "en") 
            {
                myText.text = language.en;
            }
            if (data.language == "tr")
            {
                myText.text = language.tr;
            }
            
        }
    }
    private void FixedUpdate()
    {
        Text myText = GetComponent<Text>();
        if (data.language == "ru")
        {
            myText.text = language.ru;
        }
        else
        {
            if (data.language == "en")
            {
                myText.text = language.en;
            }
            if (data.language == "tr")
            {
                myText.text = language.tr;
            }

        }
    }
}
