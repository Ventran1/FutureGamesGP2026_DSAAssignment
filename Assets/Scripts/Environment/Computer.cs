using NUnit.Framework;
using System;
using TMPro;
using UnityEngine;
using Utilies;

namespace Environment {

    [Serializable]
    public class Student_c
    {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;
    }

    [Serializable]
    public class StudenArray_c
    {
        public Student_c[] employees;
    }

    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField]
        private InQue<List> tasks = new InQue<List>(); // Put your stack/queue here :)
        [SerializeField]private TextAsset jason_file;
        private Student_c[] employees;

        private void Awake() {
            InQue<List> que = new InQue<List>();
            que.Enque(next_element: tasks.Peek());
            List value = que.Deque();
        }

        public void OnInteract() {

            if(jason_file == null) { return; }

            employees = JsonUtility.FromJson<StudenArray_c>(jason_file.text)?.employees;

            if(employees == null || employees.Length <= 0) { return; }

            foreach(Student_c student in employees)
            {
                Array.Sort(student.lastEntranceInEngineRoom.ToIntArray());
                Debug.Log("Name: " + student.name +".\n" +
                    "Employee_ID:" + student.employeeId + ".\n" +
                    "Has engine room clearence:" + student.hasEngineRoomClearance + ".\n" +
                    "First Time visit:" + student.lastEntranceInEngineRoom + ".\n" +
                    "Lateset Time visit:" + student.lastExitFromEngineRoom + ".\n");
            }
        }
    }
}
