using Environment.Tasks;
using System;
using UnityEngine;
using Utilies;

namespace Environment {

    [Serializable]
    public class Student_c
    {
        public string name;
        public int  employee_id;
        public bool engine_room_clearence;
        public DateTime first_engine_room_visit;
        public DateTime last_engine_room_visit;
    }

    [Serializable]
    public class StudenArray_c
    {
        public Student_c[] students;
    }

    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField]
        private Task testTask = null; // Put your stack/queue here :)
        private TextAsset jason_file;
        private Student_c[] students;

        private void Awake() {
            InQue<int> que = new InQue<int>();
            que.Enque(next_element: 1);
            int value = que.Deque();

        }

        public void OnInteract() {
            testTask.Execute();

            if(jason_file == null) { return; }

            Student_c[] strudents = JsonUtility.FromJson<StudenArray_c>(jason_file.text)?.students;

            if(students != null && students.Length <= 0) { return; }

            foreach(Student_c student in students)
            {
                Debug.Log("Name: " + student.name +".\n" +
                    "Employee_ID:" + student.employee_id + ".\n" +
                    "Has engine room clearence:" + student.engine_room_clearence + ".\n" +
                    "First Time visit:" + student.first_engine_room_visit + ".\n" +
                    "Lateset Time visit:" + student.last_engine_room_visit + ".\n");
            }
        }
    }
}
