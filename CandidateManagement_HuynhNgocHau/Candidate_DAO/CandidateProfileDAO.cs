using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
	public class CandidateProfileDAO
	{
		private GenericDAO<CandidateProfile> candidateProfileDAO;
		private static CandidateProfileDAO instance;
		private CandidateManagementContext dbContext;
		public CandidateProfileDAO()
		{
			candidateProfileDAO = new GenericDAO<CandidateProfile>(new CandidateManagementContext());
			dbContext = new CandidateManagementContext();
		}

		public static CandidateProfileDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CandidateProfileDAO();
				}
				return instance;
			}
		}
		public CandidateProfile GetCandidateProfileById(string id)
		{
			return candidateProfileDAO.GetById(id);
		}
		public List<CandidateProfile> GetCandidateProfiles()
		{
			return candidateProfileDAO.GetAll();
		}
		public List<CandidateProfile> GetCandidateProfileByNameOrDateTime(string? Name, DateTime? Birthday)
		{
			if (string.IsNullOrWhiteSpace(Name) && !Birthday.HasValue)
			{
				return dbContext.CandidateProfiles.ToList();
			}
			if (!string.IsNullOrWhiteSpace(Name) && !Birthday.HasValue)
			{
				return dbContext.CandidateProfiles.Where(m => m.Fullname.Contains(Name)).ToList();
			}
			if (string.IsNullOrWhiteSpace(Name) && Birthday.HasValue)
			{
				return dbContext.CandidateProfiles.Where(m => m.Birthday == Birthday.Value).ToList();
			}
			return dbContext.CandidateProfiles.Where(m => m.Fullname.Contains(Name) && m.Birthday.Value.Date == Birthday.Value.Date).ToList();
		}

		public bool AddCandidateProfile(CandidateProfile candidateProfile)
		{
			if (GetCandidateProfileById(candidateProfile.CandidateId) != null)
			{
				return false; 
			}
			return candidateProfileDAO.Add(candidateProfile);
		}
		public bool DeleteCandidateProfile(string id)
		{
			return candidateProfileDAO.Delete(id);
		}
		public bool UpdateCandidateProfile(CandidateProfile candidate)
		{
			if (GetCandidateProfileById(candidate.CandidateId) == null)
			{
				return false;
			}
			return candidateProfileDAO.Update(candidate);
		}
	}
}
