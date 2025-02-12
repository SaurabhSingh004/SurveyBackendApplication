namespace SurveyBackendApplication.Model
{
    public class Response
    {
        public int Id { get; set; }
        /*public string QuestionType { get; set; }*/
        public Question Question { get; set; }
        public string Answer { get; set; }
    }

}
