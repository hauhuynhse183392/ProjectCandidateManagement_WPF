using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
	public class CandidateProfileService : ICandidateProfileService
	{
		private ICandidateProfileRepo repo;
		public CandidateProfileService()
		{
			repo = new CandidateProfileRepo();
		}
		public bool AddCandidateProfile(CandidateProfile candidateProfile)
		{
			return repo.AddCandidateProfile(candidateProfile);
		}

		public bool DeleteCandidateProfile(string id)
		{
			return repo.DeleteCandidateProfile(id);
		}

		public CandidateProfile GetCandidateProfileById(string id)
		{
			return repo.GetCandidateProfileById(id);
		}

		public List<CandidateProfile> GetCandidateProfiles()
		{
			return repo.GetCandidateProfiles();
		}

		public bool UpdateCandidateProfile(CandidateProfile candidate)
		{
			return repo.UpdateCandidateProfile(candidate);
		}
		public List<CandidateProfile> GetCandidateProfileByNameOrDateTime(string? Name, DateTime? Birthday) => repo.GetCandidateProfileByNameOrDateTime(Name, Birthday);
	}
}
