using LeadManagement.Application.Leads.Commands;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Interfaces;
using MediatR;

namespace LeadManagement.Application.Leads.Handlers
{
    public class DeclineLeadCommandHandler : IRequestHandler<DeclineLeadCommand>
    {
        private readonly ILeadRepository _leadRepository;

        public DeclineLeadCommandHandler(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }

        public async Task Handle(DeclineLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = await _leadRepository.GetByIdAsync(request.Id);
            if (lead == null) throw new Exception("Lead not found");

            lead.Status = LeadStatus.decline;
            await _leadRepository.UpdateAsync(lead);
        }
    }
}
