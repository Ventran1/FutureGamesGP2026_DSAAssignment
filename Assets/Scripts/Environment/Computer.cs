using Environment.Tasks;
using UnityEngine;
using Utilies;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable
    {
        [SerializeField]
        private Task testTask = null; // Put your stack/queue here :)

        private void Awake()
        {
            InQue<int> que = new InQue<int> ();
            que.Enque(next_element: 1);
            int value = que.Deque();

        }

        public void OnInteract() {
            testTask.Execute();
        }
    }
}
