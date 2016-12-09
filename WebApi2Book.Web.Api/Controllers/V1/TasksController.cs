using System.Web.Http;

namespace WebApi2Book.Web.Api.Controllers.V1
{
    [RoutePrefixAttribute("api/employeeTasks")]
    public class TasksController : ApiController
    {
        [Route("{id:int:max(100)}")]
        public string GetTaskWithAMaxIdOf100(int id)
        {
            return "In the GetTaskWithAMaxIdOf100(int id) method, id = " + id;
        }
        [Route("{id:int:min(101)}")]
        [HttpGet]
        public string FindTaskWithAMinIdOf101(int id)
        {
            return "In the FindTaskWithAMinIdOf101(int id) method, id = " + id;
        }
        public string Get(string taskNum)
        {
            return "In the Get(string taskNum) method, taskNum = " + taskNum;
        }
    }
}
