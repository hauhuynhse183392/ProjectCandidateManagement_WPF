using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
	public class HRAccountService : IHRAccountService
	{
		private IHRAccountRepo iAccountRepo;
		public HRAccountService()
		{
			iAccountRepo = new HRAccountRepo();
		}

        public bool AddHraccount(Hraccount newAccount) => iAccountRepo.AddHraccount(newAccount);

        public bool DeleteHraccount(string Email) => iAccountRepo.DeleteHraccount(Email);

        public Hraccount GetHraccountByEmail(string email)
		{
			return iAccountRepo.GetHraccountByEmail(email);
		}

		public List<Hraccount> GetHraccounts()
		{
			return iAccountRepo.GetHraccounts();
		}

        public List<Hraccount> GetHraccountsByNameOrRole(string? Name, int? Role) => iAccountRepo.GetHraccountsByNameOrRole(Name, Role);

        public bool UpdateHraccount(Hraccount account) => iAccountRepo.UpdateHraccount(account);
    }
}
