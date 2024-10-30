using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
	public interface IHRAccountService
	{
		public Hraccount GetHraccountByEmail(string email);
		public List<Hraccount> GetHraccounts();
		public List<Hraccount> GetHraccountsByNameOrRole(string? Name, int? Role);
        public bool AddHraccount(Hraccount newAccount);
        public bool DeleteHraccount(string Email);
        public bool UpdateHraccount(Hraccount account);
    }
}
