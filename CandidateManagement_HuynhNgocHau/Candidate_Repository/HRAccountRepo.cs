using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
	public class HRAccountRepo : IHRAccountRepo
	{
        public bool AddHraccount(Hraccount newAccount) => HRAccountDAO.Instance.AddHraccount(newAccount);

        public bool DeleteHraccount(string Email) => HRAccountDAO.Instance.DeleteHraccount(Email);

        public Hraccount GetHraccountByEmail(string email) => HRAccountDAO.Instance.GetHraccountByEmail(email);

		public List<Hraccount> GetHraccounts() => HRAccountDAO.Instance.GetHraccounts();
		public List<Hraccount> GetHraccountsByNameOrRole(string? Name, int? Role) => HRAccountDAO.Instance.GetHraccountsByNameOrRole(Name, Role);

        public bool UpdateHraccount(Hraccount account) => HRAccountDAO.Instance.UpdateHraccount(account);
    }
}
