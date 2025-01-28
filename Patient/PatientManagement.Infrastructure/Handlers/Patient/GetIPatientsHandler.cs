using PatientManagement.Application.Patients.GetPatients;
using PatientManagement.Infrastructure.StoredModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Infrastructure.Handlers.Patient;

internal class GetPatientHandler : IRequestHandler<GetPatientsQuery, IEnumerable<PatientDto>>
{
    private readonly StoredDbContext _dbContext;

    public GetPatientsHandler(StoredDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<PatientDto>> Handle(GetPatientsQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Patient.AsNoTracking().
            Select(i => new PatientDto()
            {
                Id = i.Id,
                ItemName = i.ItemName
            }).
            ToListAsync(cancellationToken);
    }
}
