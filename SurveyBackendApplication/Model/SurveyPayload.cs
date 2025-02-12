namespace SurveyBackendApplication.Model
{
    public class SurveyPayload
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
