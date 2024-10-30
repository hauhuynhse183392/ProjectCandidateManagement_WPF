using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
	public class JobPostingRepo : IJobPostingRepo
	{
		public JobPosting GetJobPostingById(string id) => JobPostingDAO.Instance.GetJobPostingByID(id);

		public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();
		public bool AddJobPosting(JobPosting job) => JobPostingDAO.Instance.AddJobPosting(job);
		public bool UpdateJobPosting(JobPosting job) => JobPostingDAO.Instance.UpdateJobPosting(job);
		public bool DeleteJobPostingByID(string id) => JobPostingDAO.Instance.DeleteJobPostingByID(id);
		public List<JobPosting> GetJobPostingByTitleOrPostDate(string? Title, DateTime? Date) => JobPostingDAO.Instance.GetJobPostingByTitleOrPostDate(Title, Date);
	}
}
