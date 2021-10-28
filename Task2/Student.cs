namespace Task2
{
    public class Student
    {
        private int Id { get; set; }
        private string FullName { get; set; }
        public int[] Evaluations { get; } = new int[3];

        public Student(int id, string fullName, int[] evaluations)
        {
            Id = id;
            FullName = fullName;
            Evaluations = evaluations;
        }

        public override string ToString()
        {
            return $"№{Id}| {FullName} | Оценки: {Evaluations[0]}, {Evaluations[1]}, {Evaluations[2]}"; 
        }
    }
}
