using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class District
    {
        public int districtId ;
        public List<StudentMarks> districtStudents = new List<StudentMarks>();

        public District(int id, List<StudentMarks> s)
        {
            this.districtId = id;
            this.districtStudents = s;
        }
        public void SortQuick(List<StudentMarks>s)
        {
            
            if (districtStudents == null || districtStudents.Count <= 1)
                return;
            SortQuick(districtStudents, 0, districtStudents.Count-1);
        }
        public void SortQuick(List<StudentMarks>district, int left , int right)
        {
            
            if (left < right)
            {
                int pi = Partition(district, left, right);
                SortQuick(district, left, pi - 1);
                SortQuick(district, pi + 1, right);
            }
        }

        private int Partition(List<StudentMarks>d, int left, int right)
        {
            double pivot = d[right].GetMarks();
            int i = left - 1;

            for(int j = left; j < right; j++)
            {
                if (d[j].GetMarks() >= pivot)
                {
                    i++;
                    Swap(d, i, j);
                }
            }
            Swap(d, i + 1, right);
            return i + 1;
        }

        private static void Swap(List<StudentMarks> list, int i, int j)
        {
            StudentMarks temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public void Display()
        {
            foreach(StudentMarks i in districtStudents)
            {
                Console.WriteLine(i);
            }
        }
    }
}
