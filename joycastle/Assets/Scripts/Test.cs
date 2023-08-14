using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private SimpleTween simple;
    private Transform origin;
    private Vector3 oriScale;
    private Tween move;
    private Tween scale;

    void Start()
    {
        origin = this.transform;
        simple = SimpleTween.Instance;
        oriScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.Linear);
            scale.SetEase(EaseType.Linear);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.EaseInSine);
            scale.SetEase(EaseType.EaseInSine);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.EaseOutSine);
            scale.SetEase(EaseType.EaseOutSine);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.EaseInOutSine);
            scale.SetEase(EaseType.EaseInOutSine);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.EaseInBack);
            scale.SetEase(EaseType.EaseInBack);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.EaseOutBack);
            scale.SetEase(EaseType.EaseOutBack);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            this.transform.position = Vector3.zero;
            this.transform.localScale = oriScale;
            move = simple.DoMove(origin, new Vector3(3f, 0f, 3f), 3f);
            scale = simple.DoScale(origin, new Vector3(1f, 2f, 2f), 3f);
            move.SetEase(EaseType.EaseInOutBack);
            scale.SetEase(EaseType.EaseInOutBack);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            simple.KillTween(scale);
            Debug.Log("Stop Scaling");
        }
        else if(Input.GetKeyDown(KeyCode.M)) 
        {
            simple.KillTween(move);
            Debug.Log("Stop Moving");
        }
    }
}
