using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
	public interface IHRAccountRepo
	{
		public Hraccount GetHraccountByEmail(string email);
		public List<Hraccount> GetHraccounts();
		public List<Hraccount> GetHraccountsByNameOrRole(string? Name, int? Role);
		public bool AddHraccount(Hraccount newAccount);
		public bool DeleteHraccount(string Email);
		public bool UpdateHraccount(Hraccount account);

    }
}
