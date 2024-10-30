using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
	public class JobPostingDAO
	{
		private GenericDAO<JobPosting> jobPostingDAO;
		private static JobPostingDAO instance = null;
		private CandidateManagementContext dbContext;
		public static JobPostingDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new JobPostingDAO();
				}
				return instance;
			}
		}
		public JobPostingDAO()
		{
			jobPostingDAO = new GenericDAO<JobPosting>(new CandidateManagementContext());
			dbContext = new CandidateManagementContext();
		}
		public JobPosting GetJobPostingByID(String id)
		{
			return jobPostingDAO.GetById(id);
		}
		public List<JobPosting> GetJobPostingByTitleOrPostDate(string? Title, DateTime? Day)
		{
			if (string.IsNullOrWhiteSpace(Title) && !Day.HasValue)
			{
				return dbContext.JobPostings.ToList();
			}
			if (!string.IsNullOrWhiteSpace(Title) && !Day.HasValue)
			{
				return dbContext.JobPostings.Where(m => m.JobPostingTitle.Contains(Title)).ToList();
			}
			if (string.IsNullOrWhiteSpace(Title) && Day.HasValue)
			{
				return dbContext.JobPostings.Where(m => m.PostedDate == Day.Value).ToList();
			}
			return dbContext.JobPostings.Where(m => m.JobPostingTitle.Contains(Title) && m.PostedDate.Value.Date == Day.Value.Date).ToList();
		}
		public List<JobPosting> GetJobPostings()
		{
			return jobPostingDAO.GetAll();
		}
		public bool AddJobPosting(JobPosting job)
		{
			if (GetJobPostingByID(job.PostingId) != null)
			{
				return false;
			}
			return jobPostingDAO.Add(job);
		}
		public bool DeleteJobPostingByID(string id)
		{
			return jobPostingDAO.Delete(id);
		}
		public bool UpdateJobPosting(JobPosting job)
		{
			if (GetJobPostingByID(job.PostingId) == null)
			{
				return false;
			}
			return jobPostingDAO.Update(job);
		}

	}
}
