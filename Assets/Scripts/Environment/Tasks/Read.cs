using Environment;
using Environment.Tasks;
using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Environment.Tasks {
    [CreateAssetMenu(fileName = "Read Jason", menuName = "")]
    public class Read : Task {

        [SerializeField] private TextAsset jason_file;
        private Student_c[] employee;

        public override void Execute()
        {
            if(jason_file == null) { return; }

            employee = JsonUtility.FromJson<StudenArray_c>(jason_file.text)?.employees;

            if(employee == null || employee.Length <= 0) { return; }

            foreach(Student_c employeee in employee) {
                Array.Sort(employeee.lastEntranceInEngineRoom.ToIntArray());
                Debug.Log("Name: " + employeee.name + ".\n" +
                    "Employee_ID:" + employeee.employeeId + ".\n" +
                    "Has engine room clearence:" + employeee.hasEngineRoomClearance + ".\n" +
                    "First Time visit:" + employeee.lastEntranceInEngineRoom + ".\n" +
                    "Lateset Time visit:" + employeee.lastExitFromEngineRoom + ".\n");
            }
        }
    }
}
