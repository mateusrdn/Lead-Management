using LeadManagement.Application.DTOs;
using LeadManagement.Domain.Enums;
using MediatR;

namespace LeadManagement.Application.Leads.Queries
{
    public class GetLeadsByStatusQuery : IRequest<IEnumerable<ReadLeadDto>>
    {
        public LeadStatus Status { get; set; }
        
        public GetLeadsByStatusQuery(LeadStatus status)
        {
            Status = status;
        }
    }
}
