using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Interfaces;
using LeadManagement.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Infra.Data.Repositories
{
    public class LeadRepository : ILeadRepository
    {
        ApplicationDbContext _leadContext;

        public LeadRepository(ApplicationDbContext leadContext)
        {
            _leadContext = leadContext;
        }

        public async Task<Lead> GetByIdAsync(int id)
        {
            return await _leadContext.Leads.FindAsync(id);
        }

        public async Task<IEnumerable<Lead>> GetLeadsByStatusAsync(LeadStatus status)
        {
            return await _leadContext.Leads.Where(l => l.Status == status).ToListAsync();
        }

        public async Task<Lead> UpdateAsync(Lead lead)
        {
            _leadContext.Update(lead);
            await _leadContext.SaveChangesAsync();
            return lead;
        }


    }
}
