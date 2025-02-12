namespace SurveyBackendApplication.Model
{
    public class Survey
    {
        public Survey() { }
        public int Id { get; set; }
        public string Description { get; set; }

        public IEnumerable<Question> Questions { get; set; }
    }
}
