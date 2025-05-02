using LeadManagement.Application.Leads.Commands;
using LeadManagement.Application.Leads.Queries;
using LeadManagement.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeadManagement.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{status}")]
        public async Task<IActionResult> GetLeads([FromRoute] LeadStatus status)
        {
            var query = new GetLeadsByStatusQuery(status);
            var leads = await _mediator.Send(query);
            return Ok(leads);
        }

        [HttpPut("accept/{id}")]
        public async Task<IActionResult> AcceptLead(int id)
        {
            var command = new AcceptLeadCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("decline/{id}")]
        public async Task<IActionResult> DeclineLead(int id)
        {
            var command = new DeclineLeadCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
