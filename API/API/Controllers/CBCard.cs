using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    public class CBCard : ApiBaseController
    {


        [HttpPost("DebitTransaction")]
        public async Task<IActionResult> DebitTransaction([FromForm] HoldMovieTicketRequestModel requestModel)
        {
            requestModel.User = User;
            var result = await _movieService.HoldMovieTicket(requestModel);
            return Ok(result);
        }

    }
}
