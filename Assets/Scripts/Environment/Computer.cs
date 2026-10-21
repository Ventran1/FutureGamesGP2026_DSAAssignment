using Environment.Tasks;
using System;
using UnityEngine;
using Utilies;

namespace Environment {

    [Serializable]
    public class Student_c {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;
    }

    [Serializable]
    public class StudenArray_c {
        public Student_c[] employees;
    }

    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField]
        private InQue<Task> tasks = new InQue<Task>(); // Put your stack/queue here :)

        public void OnInteract()
        {
            tasks.Deque().Execute();
        }
    }
}
