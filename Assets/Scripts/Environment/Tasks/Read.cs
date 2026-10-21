using Environment;
using Environment.Tasks;
using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Environment.Tasks {
    [CreateAssetMenu(fileName = "Read Jason", menuName = "")]
    public class Read : Task {

        [SerializeField] private TextAsset jason_file;
        private Student_c[] employees;

        public override void Execute()
        {
            if(jason_file == null) { return; }

            employees = JsonUtility.FromJson<StudenArray_c>(jason_file.text)?.employees;

            if(employees == null || employees.Length <= 0) { return; }

            foreach(Student_c student in employees) {
                Array.Sort(student.lastEntranceInEngineRoom.ToIntArray());
                Debug.Log("Name: " + student.name + ".\n" +
                    "Employee_ID:" + student.employeeId + ".\n" +
                    "Has engine room clearence:" + student.hasEngineRoomClearance + ".\n" +
                    "First Time visit:" + student.lastEntranceInEngineRoom + ".\n" +
                    "Lateset Time visit:" + student.lastExitFromEngineRoom + ".\n");
            }
        }
    }
}
