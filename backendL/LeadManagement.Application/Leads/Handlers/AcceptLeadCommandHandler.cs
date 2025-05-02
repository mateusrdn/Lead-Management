using LeadManagement.Application.Interfaces;
using LeadManagement.Application.Leads.Commands;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Interfaces;
using MediatR;

namespace LeadManagement.Application.Leads.Handlers
{
    public class AcceptLeadCommandHandler : IRequestHandler<AcceptLeadCommand>
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IEmailService _emailService;

        public AcceptLeadCommandHandler(ILeadRepository leadRepository, IEmailService emailService)
        {
            _leadRepository = leadRepository;
            _emailService = emailService;
        }

        public async Task Handle(AcceptLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = await _leadRepository.GetByIdAsync(request.Id);
            if (lead == null) throw new Exception("Lead not found");

            if (lead.Price > 500)
            {
                lead.Price = lead.Price * 0.9m;
            }

            lead.Status = LeadStatus.accepted;
            await _leadRepository.UpdateAsync(lead);

            await _emailService.SendEmailAsync("vendas@test.com",
                "Novo Lead Aceito", $"Lead {lead.Id} Foi aceito");
        }
    }
}
