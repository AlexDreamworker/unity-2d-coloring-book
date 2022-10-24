using ChildPaint.Model.Definition;
using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Navigation
{
    [RequireComponent(typeof(Animator))]
    public class NavigationSystem : MonoBehaviour
    {
        [SerializeField] private Animator _anim;
        [SerializeField] [Range(0, 20)] private int _maxTransitionNumber = 10;
        [SerializeField] private UnityEvent _onTransitionOut;

        private int _currentFrame;

        private readonly int CurrentFrameKey = Animator.StringToHash("currentFrame");
        private readonly int IsNextKey = Animator.StringToHash("isNext");
        private readonly int FirstAnswerKey = Animator.StringToHash("firstAnswer");
        private readonly int SecondAnswerKey = Animator.StringToHash("secondAnswer");

        void Start()
        {
            _currentFrame = 0;
            _anim.SetBool(IsNextKey, true);
            DefsFacade.I.Color.Set(Color.white);
        }

        public void NextFrame() 
        {
            if (_currentFrame >= _maxTransitionNumber) 
                _onTransitionOut?.Invoke();
            else 
                _currentFrame++;

            _anim.SetInteger(CurrentFrameKey, _currentFrame);
            _anim.SetBool(IsNextKey, true);
        }

        public void PreviousFrame() 
        {
            if (_currentFrame <= 0) 
                _onTransitionOut?.Invoke();
            else 
                _currentFrame--;

            _anim.SetInteger(CurrentFrameKey, _currentFrame);
            _anim.SetBool(IsNextKey, false);
        }

        public void SetAnimIsFirstAnswer() => _anim.SetTrigger(FirstAnswerKey);

        public void SetAnimIsSecondAnswer() => _anim.SetTrigger(SecondAnswerKey);
    }
}

