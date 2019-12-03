using UnityEngine;
using UnityEngine.UI;

public class AddPlayer : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button firstButton;
    public Button secondButton;
    public Button thirdButton;
    public Button fourthButton;
    public Button fifthButton;
    public Button sixthButton;
    public GameObject KingInfo;
    public GameObject GigazaurInfo;
    public GameObject CyberBunnyInfo;
    public GameObject AlienoidInfo;
    public GameObject KrakenInfo;
    public GameObject MekaDragonInfo;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        //firstButton.onClick.AddListener(TaskOnClick);
        //firstButton.onClick.AddListener(delegate { TaskWithParameters("Hello #1"); });
        firstButton.onClick.AddListener(() => ButtonClicked(1));
        //firstButton.onClick.AddListener(buttonOneDestroy(firstButton));

        //secondButton.onClick.AddListener(TaskOnClick);
        //secondButton.onClick.AddListener(delegate { TaskWithParameters("Hello #2"); });
        secondButton.onClick.AddListener(() => ButtonClicked(2));

        //thirdButton.onClick.AddListener(TaskOnClick);
        //thirdButton.onClick.AddListener(delegate { TaskWithParameters("Hello #3"); });
        thirdButton.onClick.AddListener(() => ButtonClicked(3));

        //fourthButton.onClick.AddListener(TaskOnClick);
        //fourthButton.onClick.AddListener(delegate { TaskWithParameters("Hello #4"); });
        fourthButton.onClick.AddListener(() => ButtonClicked(4));

        //fifthButton.onClick.AddListener(TaskOnClick);
        //fifthButton.onClick.AddListener(delegate { TaskWithParameters("Hello #5"); });
        fifthButton.onClick.AddListener(() => ButtonClicked(5));

        //sixthButton.onClick.AddListener(TaskOnClick);
        //sixthButton.onClick.AddListener(delegate { TaskWithParameters("Hello #6"); });
        sixthButton.onClick.AddListener(() => ButtonClicked(6));
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }

    void TaskWithParameters(string message)
    {
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        Debug.Log("Button clicked = " + buttonNo);
    }

    public void buttonOneDestroy()
    {
        firstButton.gameObject.SetActive(false);
    }

    public void buttonTwoDestroy()
    {
        secondButton.gameObject.SetActive(false);
    }

    public void buttonThreeDestroy()
    {
        thirdButton.gameObject.SetActive(false);
    }

    public void buttonFourDestroy()
    {
        fourthButton.gameObject.SetActive(false);
    }

    public void buttonFiveDestroy()
    {
        fifthButton.gameObject.SetActive(false);
    }

    public void buttonSixDestroy()
    {
        sixthButton.gameObject.SetActive(false);
    }
}