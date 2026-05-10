using System.Security.AccessControl;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classroom = new Classroom();
            classroom.AddStudent(50);
            classroom.AddStudent(60);
            classroom.AddStudent(80);
        }
    }
    class Classroom
    {
        private List<Student> _students = new List<Student>();

        public void AddStudent(int score)
        {
            var student = new Student { Score = score };
            _students.Add(student);
        }

        public List<Student> Getstudent()
        {
            // 在此先簡化,理論上應該要回傳一個新的List<Student>以避免外部修改內部的學生列表
            return _students;
        }

        public double GetAverageScore()
        {
            if (_students.Count == 0) return 0;
            int sum = 0;
            foreach (var item in _students)
            {
                sum += item.Score;
            }
            return (double)sum / _students.Count;
        }

        public string GetOverallPassStatus()
        {
            double average = GetAverageScore();
            return average >= 60
                ?"整體不及格"
                : "整體不及格";
        }

        public int GetHighestScore()
        {
            if (_students.Count == 0) return 0;
            int highest = _students[0].Score;
            foreach (var item in _students)
            {
                if (item.Score > highest)
                {
                    highest = item.Score;
                }
            }
            return highest;
        }

        public int GetLowestScore()
        {
            {
                if (_students.Count == 0) return 0;
                int lowest = _students[0].Score;
                foreach (var item in _students)
                {
                    if (item.Score < lowest)
                    {
                        lowest = item.Score;
                    }
                }
                return lowest;
            }
        }

        //計算不及格人數(<60)
        public int GetFailingCount()
        {
            int count = 0;
            foreach (var _item in _students)
            {
                if (_item.Score < 60)
                {
                    count++;
                }
            }
            return count;
        }
    }



    class Student
    {
        private int _score;
        public int Score
        {
            get => _score;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "分數只能介於0-100之間。");
                }
                _score = value;
            }
        }
    }

}