using AutoMapper;
using LeadManagement.Application.DTOs;
using LeadManagement.Application.Leads.Queries;
using LeadManagement.Domain.Interfaces;
using MediatR;

namespace LeadManagement.Application.Leads.Handlers
{
    public class GetLeadsByStatusQueryHandler : IRequestHandler<GetLeadsByStatusQuery, IEnumerable<ReadLeadDto>>
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IMapper _mapper;
        
        public GetLeadsByStatusQueryHandler(ILeadRepository leadRepository, IMapper mapper)
        {
            _leadRepository = leadRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadLeadDto>> Handle(GetLeadsByStatusQuery request, CancellationToken cancellationToken)
        {
            var leads = await _leadRepository.GetLeadsByStatusAsync(request.Status);
            return _mapper.Map<IEnumerable<ReadLeadDto>>(leads);
        }
    }
}
