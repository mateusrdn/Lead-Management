using MediatR;

namespace LeadManagement.Application.Leads.Commands
{
    public class DeclineLeadCommand : IRequest
    {
        public int Id { get; set; }
    }
}
