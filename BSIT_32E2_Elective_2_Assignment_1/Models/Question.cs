namespace BSIT_32E2_Elective_2_Assignment_1.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string QuestionText { get; set; } = "";
        public string OptionA { get; set; } = "";
        public string OptionB { get; set; } = "";
        public string OptionC { get; set; } = "";
        public string OptionD { get; set; } = "";
        public string CorrectAnswer { get; set; } = "";
        public string Explanation { get; set; } = "";
    }
}