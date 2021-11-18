using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewSystem : MonoBehaviour
{
    private ScrollRect _scrollRect;

    [SerializeField] private ScrollButton _bottomButton;
    [SerializeField] private ScrollButton _topButton;

    [SerializeField] private float scrollSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        _scrollRect = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
    
         if(_bottomButton != null)
        {
            if(_bottomButton.isDown)
            {
                ScrollBottom();
            }
        }
         if(_topButton != null)
        {
            if(_topButton.isDown)
            {
                ScrollTop();
            }
        }
    }

    private void ScrollTop()
    {
        if(_scrollRect != null)
        {
            if(_scrollRect.verticalNormalizedPosition <=1f)
            {
                _scrollRect.verticalNormalizedPosition +=scrollSpeed;
            }
        }
    }

        private void ScrollBottom()
    {
        if(_scrollRect != null)
        {
            if(_scrollRect.verticalNormalizedPosition >=0f)
            {
                _scrollRect.verticalNormalizedPosition -=scrollSpeed;
            }
        }
    }
}
