using MediatR;

namespace LeadManagement.Application.Leads.Commands
{
    public class AcceptLeadCommand : IRequest
    {
        public int Id { get; set; }
    }
}
