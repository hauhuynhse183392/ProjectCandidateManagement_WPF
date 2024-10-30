using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
	public interface ICandidateProfileService
	{
		public CandidateProfile GetCandidateProfileById(string id);
		public List<CandidateProfile> GetCandidateProfiles();
		public bool AddCandidateProfile(CandidateProfile candidateProfile);
		public bool DeleteCandidateProfile(string id);
		public bool UpdateCandidateProfile(CandidateProfile candidate);
		public List<CandidateProfile> GetCandidateProfileByNameOrDateTime(string? Name, DateTime? Birthday);
	}
}
