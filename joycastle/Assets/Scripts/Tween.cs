using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TweenType
{
    Move,
    Scale
}

public enum EaseType
{
    Linear,
    EaseInSine,
    EaseOutSine,
    EaseInOutSine,
    EaseInBack,
    EaseOutBack,
    EaseInOutBack
}
public class Tween
{
    private Transform target;
    private Vector3 start;
    private Vector3 end;
    private float duration;
    private float elapsedTime;
    private EaseType easeType;
    private TweenType tweenType;
    public bool isComplete = false;

    public Tween(Transform target, Vector3 end, float duration, TweenType tweenType)
    {
        this.target = target;
        if (tweenType == TweenType.Move) this.start = target.position;
        if (tweenType == TweenType.Scale) this.start = target.localScale;
            this.end = end;
        this.duration = duration;
        this.elapsedTime = 0f;
        this.easeType = EaseType.Linear;
        this.tweenType = tweenType;
    }

    public void SetEase(EaseType easeType)
    {
        this.easeType = easeType;
    }

    public void UpdateTween(float deltaTime)
    {
        if (isComplete)
            return;

        elapsedTime += deltaTime;

        if (elapsedTime >= duration)
        {
            isComplete = true;
            return;
        }

        float t = elapsedTime / duration;
        float easedT = Ease(t);
        
        if(tweenType == TweenType.Move) target.position = Vector3.Lerp(start, end, easedT);
        if(tweenType == TweenType.Scale) target.localScale = Vector3.Lerp(start, end,easedT);

    }

    public void Complete()
    {
        isComplete = true;
    }

    private float Ease(float t)
    {
        switch (easeType)
        {
            case EaseType.Linear:
                return t;
            case EaseType.EaseInSine:
                return Mathf.Sin((t * Mathf.PI) / 2);
            case EaseType.EaseOutSine:
                return 1f - Mathf.Cos((t * Mathf.PI) / 2);
            case EaseType.EaseInOutSine:
                return -(Mathf.Cos(Mathf.PI * t) - 1) / 2;
            case EaseType.EaseInBack:
                float s = 1.70158f;
                return t * t * ((s + 1) * t - s);
            case EaseType.EaseOutBack:
                s = 1.70158f;
                t = t - 1;
                return t * t * ((s + 1) * t + s) + 1;
            case EaseType.EaseInOutBack:
                s = 1.70158f * 1.525f;
                t /= 0.5f;
                if (t < 1)
                {
                    return 0.5f * (t * t * ((s + 1) * t - s));
                }
                else
                {
                    t -= 2;
                    return 0.5f * (t * t * ((s + 1) * t + s) + 2);
                }
            default:
                return t;
        }
    }
}