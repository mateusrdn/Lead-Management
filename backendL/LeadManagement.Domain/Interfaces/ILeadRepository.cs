using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;

namespace LeadManagement.Domain.Interfaces
{
    public interface ILeadRepository
    {
        Task<Lead> GetByIdAsync(int id);
        Task<IEnumerable<Lead>> GetLeadsByStatusAsync(LeadStatus status);
        Task<Lead> UpdateAsync(Lead lead);

    }
}
