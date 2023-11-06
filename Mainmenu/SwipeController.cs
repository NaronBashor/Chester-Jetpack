using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeController : MonoBehaviour, IEndDragHandler
{
        [SerializeField] int maxPage;
        [SerializeField] Vector3 pageSetup;
        [SerializeField] RectTransform levelPagesRect;
        [SerializeField] float tweenTime;
        [SerializeField] LeanTweenType tweenType;

        int currentPage;
        Vector3 targetPos;

        float dragThreshold;

        private void Awake()
        {
                currentPage = 1;
                targetPos = levelPagesRect.localPosition;
                dragThreshold = Screen.width / 2;
        }

        public void Next()
        {
                if (currentPage < maxPage)
                {
                        currentPage++;
                        targetPos += pageSetup;
                        MovePage();
                }
        }

        public void Previous()
        {
                if (currentPage > 1)
                {
                        currentPage--;
                        targetPos -= pageSetup;
                        MovePage();
                }
        }

        void MovePage()
        {
                levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
                if (Mathf.Abs(eventData.position.x - eventData.pressPosition.x) < dragThreshold)
                {
                        if (eventData.position.x > eventData.pressPosition.x)
                        {
                                Previous();
                        }
                        else
                        {
                                Next();
                        }
                }
                else
                {
                        MovePage();
                }
        }
}
