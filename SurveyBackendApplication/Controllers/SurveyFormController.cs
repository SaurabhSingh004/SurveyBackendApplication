using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBackendApplication.Model;

namespace SurveyBackendApplication.Controllers
{
    public class SurveyFormController : Controller
    {

        public IEnumerable<Survey> surveyList = new List<Survey>();
        public IEnumerable<SurveyResponses> surveyResponsesList = new List<SurveyResponses>();
        public IEnumerable<Response> responsesList = new List<Response>();
        

        // GET: SurveyFormController/Details/5 - Surveyid
        public ActionResult Details(int id)
        {

            SurveyResponses responsesOfSingleSurvey = surveyResponsesList.Where(xx => xx.surveyId == id).FirstOrDefault();

            return View(responsesOfSingleSurvey) ;
        }

        // GET: SurveyFormController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurveyFormController/Create
        [HttpPost]
        [Route("createSurvey")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromBody] SurveyPayload surveyPayload)
        {
            try
            {
                Survey survey = new Survey();
                survey.Questions = surveyPayload.Questions;
                survey.Id = surveyPayload.Id;
                survey.Description = surveyPayload.Description;
                surveyList.Append(survey);
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View("Error View.");
            }
        }


        // POST: SurveyFormController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserResponses([FromBody] SurveyResponses surveyResponses)
        {
            try
            {
                var  findSurvey = surveyList.Where(x=>x.Id == surveyResponses.surveyId).FirstOrDefault();

                if(findSurvey != null)
                {
                    surveyResponsesList.Append(surveyResponses);
                }

                return View("No Survey Found");
            }
            catch
            {
                return View("Error View");
            }
        }

        // GET: SurveyFormController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SurveyFormController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
