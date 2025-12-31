namespace quiz1.Models.Entity
{
    public class QuizQuestion
    {
        public int Id { get; set; }  
        public string QuestionText { get; set; } 
        public string OptionA { get; set; }  
        public string OptionB { get; set; }  
        public string OptionC { get; set; }  
        public string OptionD { get; set; }  
        public string CorrectOption { get; set; }  // Correct Option (A/B/C/D)
    }

}
