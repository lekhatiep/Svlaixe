namespace SVLaixe.Models
{
    public class ExamSubmissionDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<int> QuestionIds { get; set; } = new List<int>();
        public Dictionary<int, int> Answers { get; set; } = new Dictionary<int, int>();
    }
}
