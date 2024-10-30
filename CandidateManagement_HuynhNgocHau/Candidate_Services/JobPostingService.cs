using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
	public class JobPostingService : IJobPostingService
	{
		private readonly IJobPostingRepo IJobPostingrepo ;
		public JobPostingService()
		{
			IJobPostingrepo = new JobPostingRepo();
		}
		public JobPosting GetJobPostingById(string id)
		{
			return IJobPostingrepo.GetJobPostingById(id);
		}

		public List<JobPosting> GetJobPostings()
		{
			return IJobPostingrepo.GetJobPostings();
		}
		public bool AddJobPosting(JobPosting job) => IJobPostingrepo.AddJobPosting(job);
		public bool UpdateJobPosting(JobPosting job)=> IJobPostingrepo.UpdateJobPosting(job);
		public bool DeleteJobPostingByID(string id) => IJobPostingrepo.DeleteJobPostingByID(id);
		public List<JobPosting> GetJobPostingByTitleOrPostDate(string? Title, DateTime? Date) => IJobPostingrepo.GetJobPostingByTitleOrPostDate(Title, Date);
	}
}
