using Environment;
using Environment.Tasks;
using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Environment.Tasks
{
    [CreateAssetMenu(fileName = "Search_Task", menuName = "")]
    public class Search_Task : Task
    {
        [SerializeField] private TextAsset json_file;

        private Student_c[] employee;

        private static int BinarySearch(int[] array, int x)
        {
            int low = 0;
            int high = array.Length - 1;
            int median;

            while (low <= high)
            {
                median = low + (low + high) / 2;

                if(array[median] == x) { return median; }

                if(array[median] < x) { low = median + 1; }
                else { high = array[median] - 1; }

            }
            return -1;
        }

        public override void Execute()
        {
            foreach(Student_c employeee in employee) {

                int[] array = { employeee.lastExitFromEngineRoom.Length };
                int x = 3000;

                BinarySearch(array, x);

                Debug.Log("Name: " + employeee.name + ".\n" +
                    "Employee_ID:" + employeee.employeeId + ".\n" +
                    "Has engine room clearence:" + employeee.hasEngineRoomClearance + ".\n" +
                    "First Time visit:" + employeee.lastEntranceInEngineRoom + ".\n" +
                    "Lateset Time visit:" + employeee.lastExitFromEngineRoom + ".\n");
            }
        }
    }
}
