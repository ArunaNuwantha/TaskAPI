using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TasksController : ControllerBase
	{
		[HttpGet]
		public IActionResult Tasks() { 
		   string [] t = {"Task 1", "Task 2", "Task 3" };
			return Ok(t);
		}

	}
}



