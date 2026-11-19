using Microsoft.AspNetCore.Mvc;
using BSIT_32E2_Elective_2_Assignment_1.Models;

namespace BSIT_32E2_Elective_2_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Number = 1,
                    QuestionText = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    OptionA = "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                    OptionB = "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                    OptionC = "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                    OptionD = "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server.",
                    CorrectAnswer = "B",
                    Explanation = "SSR generates HTML on the server, while a Web API generally provides data in JSON format."
                },

                new Question
                {
                    Number = 2,
                    QuestionText = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    OptionA = "ControllerBase supports Razor View rendering using View() and ViewData.",
                    OptionB = "ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering features.",
                    OptionC = "Controller is obsolete in .NET 8 and cannot handle HTTP POST requests.",
                    OptionD = "ControllerBase automatically creates SQLite database files on application startup.",
                    CorrectAnswer = "B",
                    Explanation = "ControllerBase provides the features needed for handling HTTP requests without the additional MVC view functionality."
                },

                new Question
                {
                    Number = 3,
                    QuestionText = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    OptionA = "[Route]",
                    OptionB = "[HttpGet]",
                    OptionC = "[ApiController]",
                    OptionD = "[FromQuery]",
                    CorrectAnswer = "C",
                    Explanation = "[ApiController] automatically checks model validation and returns HTTP 400 when the submitted data is invalid."
                },

                new Question
                {
                    Number = 4,
                    QuestionText = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    OptionA = "200 OK",
                    OptionB = "201 Created",
                    OptionC = "204 No Content",
                    OptionD = "404 Not Found",
                    CorrectAnswer = "B",
                    Explanation = "201 Created indicates that a new resource was successfully created."
                },

                new Question
                {
                    Number = 5,
                    QuestionText = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    OptionA = "200 OK",
                    OptionB = "201 Created",
                    OptionC = "204 No Content",
                    OptionD = "400 Bad Request",
                    CorrectAnswer = "C",
                    Explanation = "204 No Content means the request was successful and the server has no response body to return."
                },

                new Question
                {
                    Number = 6,
                    QuestionText = "Which endpoint URI follows RESTful resource-oriented naming best practices?",
                    OptionA = "GET /api/getAllCourses",
                    OptionB = "GET /api/courses",
                    OptionC = "POST /api/createNewCourseRecord",
                    OptionD = "POST /api/deleteCourseById?id=5",
                    CorrectAnswer = "B",
                    Explanation = "GET /api/courses uses a resource-oriented URL and the GET method to retrieve courses."
                },

                new Question
                {
                    Number = 7,
                    QuestionText = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    OptionA = "It connects the controller directly to an Entity Framework database context.",
                    OptionB = "It maps incoming URI request paths to the controller class using the class name token.",
                    OptionC = "It encrypts all incoming JSON payloads.",
                    OptionD = "It enables Cross-Origin Resource Sharing (CORS) for external React apps.",
                    CorrectAnswer = "B",
                    Explanation = "The [controller] token is replaced by the controller's name to create the route."
                },

                new Question
                {
                    Number = 8,
                    QuestionText = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    OptionA = "POST",
                    OptionB = "PUT",
                    OptionC = "GET",
                    OptionD = "DELETE",
                    CorrectAnswer = "C",
                    Explanation = "GET is used to retrieve information without changing the server's data."
                },

                new Question
                {
                    Number = 9,
                    QuestionText = "In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
                    OptionA = "Task",
                    OptionB = "ActionResult<T>",
                    OptionC = "IActionResult",
                    OptionD = "ViewResult",
                    CorrectAnswer = "ActionResult<T>",
                    Explanation = "ActionResult<T> supports returning either a strongly typed response or an HTTP action result."
                }
            };

            return View(questions);
        }
    }
}