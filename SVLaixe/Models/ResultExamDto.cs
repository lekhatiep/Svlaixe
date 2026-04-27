namespace SVLaixe.Models
{
    public class ResultExamDto
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public bool IsPassed { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<int> WrongQuestionIds { get; set; } = new List<int>();
        public List<int> QuestionIds { get; set; } = new List<int>();
        public List<int> CorrectQuestionIds { get; set; } = new List<int>();
        public DateTime ExamDate { get; set; }
        public int DurationSeconds { get; set; }
    }
}
