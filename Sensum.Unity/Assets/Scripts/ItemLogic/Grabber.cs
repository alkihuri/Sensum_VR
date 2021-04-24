using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(EventTrigger))]
public class Grabber : MonoBehaviour
{
    private Rigidbody rb;
    private EventTrigger _trigger;
    [SerializeField] private GameObject _Hologram;
    private bool isHaveCanvas;
    bool isTaken; //суета, чтобы нельзя было забирать колбу у другого человека.
    void Start()
    {
        try
        {
            _Hologram = GetComponentInChildren<TubeUIController>().gameObject;
            isHaveCanvas = true;
        }
        catch
        {
            Debug.Log("hologram not exist");
            isHaveCanvas = false;
        }
        _trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => OnClick());
        _trigger.triggers.Add(entry);


        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerUp;
        entry2.callback.AddListener((data) => OnExit());
        _trigger.triggers.Add(entry2);

        if (isHaveCanvas)
        {
            EventTrigger.Entry entry3 = new EventTrigger.Entry();
            entry3.eventID = EventTriggerType.PointerEnter;
            entry3.callback.AddListener((data) => OnHover());
            _trigger.triggers.Add(entry3);

            EventTrigger.Entry entry4 = new EventTrigger.Entry();
            entry4.eventID = EventTriggerType.PointerExit;
            entry4.callback.AddListener((data) => OnUp());
            _trigger.triggers.Add(entry4);
        }
        rb = GetComponent<Rigidbody>();
        GvrEventExecutor eventExecutor = GvrPointerInputModule.FindEventExecutor();
    }

    public void OnClick()
    {
        if (!isTaken)
        {
            transform.parent = Camera.main.transform;
            rb.isKinematic = true;
            isTaken = true;
        }
    }

    public void OnExit()
    {
        if (isTaken)
        {
            rb.isKinematic = false;
            transform.parent = null;
            isTaken = false;
        }
    }
    public void OnHover()
    {
        Debug.Log("on Hover");
        _Hologram.SetActive(true);
    }
    public void OnUp()
    {
        Debug.Log("on UP");
        _Hologram.SetActive(false);
    }
}