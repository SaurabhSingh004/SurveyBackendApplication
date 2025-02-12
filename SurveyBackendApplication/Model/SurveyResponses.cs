namespace SurveyBackendApplication.Model
{
    public class SurveyResponses
    {
        public int surveyId { get; set; }
        public IEnumerable<Response> responses { get; set; }
    }
}
