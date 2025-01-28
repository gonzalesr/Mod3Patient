using PatientManagement.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Application.Evaluations.GetEvaluations
{
    public class PeriodicEvaluationDto
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public DateTime Date { get; private set; }
        public string EvaluationNotes { get; private set; }
        public decimal Weight { get; private set; }
        public decimal Height { get; private set; }
        public int Systolic { get; private set; }
        public int Diastolic { get; private set; }        
        public int HeartRate { get; private set; }
    }
}
