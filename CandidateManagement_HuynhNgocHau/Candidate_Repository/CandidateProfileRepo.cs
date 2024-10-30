using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
	public class CandidateProfileRepo : ICandidateProfileRepo
	{
		public bool AddCandidateProfile(CandidateProfile candidateProfile) => CandidateProfileDAO.Instance.AddCandidateProfile(candidateProfile);

		public bool DeleteCandidateProfile(string id) => CandidateProfileDAO.Instance.DeleteCandidateProfile(id);

		public CandidateProfile GetCandidateProfileById(string id) => CandidateProfileDAO.Instance.GetCandidateProfileById(id);

		public List<CandidateProfile> GetCandidateProfiles() => CandidateProfileDAO.Instance.GetCandidateProfiles();

		public bool UpdateCandidateProfile(CandidateProfile candidate) => CandidateProfileDAO.Instance.UpdateCandidateProfile(candidate);

        public List<CandidateProfile> GetCandidateProfileByNameOrDateTime(string? Name, DateTime? Birthday) => CandidateProfileDAO.Instance.GetCandidateProfileByNameOrDateTime(Name, Birthday);
	}
}
