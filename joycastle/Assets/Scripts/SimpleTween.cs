using System;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTween : MonoBehaviour
{
    private List<Tween> active = new List<Tween>();


    private void Update()
    {
        // Update active tweens
        for (int i = 0; i < active.Count; i++)
        {
            Tween tween = active[i];
            if (tween != null)
            {
                tween.UpdateTween(Time.deltaTime);
                if (tween.isComplete)
                {
                    active.RemoveAt(i);
                }
            }
        }
    }

    public Tween DoMove(Transform target, Vector3 endValue, float duration)
    {
        Tween tween = new Tween(target, endValue, duration, TweenType.Move);
        active.Add(tween);
        return tween;
    }

    public Tween DoScale(Transform target, Vector3 endValue, float duration)
    {
        Tween tween = new Tween(target, endValue, duration, TweenType.Scale);
        active.Add(tween);
        return tween;
    }

    public void KillTween(Tween tween)
    {
        if (tween != null && active.Contains(tween))
        {
            tween.Complete();
            active.Remove(tween);
        }
    }
}


