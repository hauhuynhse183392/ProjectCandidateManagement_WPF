using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
	public interface IJobPostingService
	{
		public JobPosting GetJobPostingById(String id);
		public List<JobPosting> GetJobPostings();
		public bool AddJobPosting(JobPosting job);
		public bool UpdateJobPosting(JobPosting job);
		public bool DeleteJobPostingByID(string id);
		public List<JobPosting> GetJobPostingByTitleOrPostDate(string? Title, DateTime? Date);
	}
}
