using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
	public class HRAccountDAO
	{
		private GenericDAO<Hraccount> hrAccountDAO;
		private static HRAccountDAO instance = null;
        private CandidateManagementContext dbContext;
		public static HRAccountDAO Instance
		{
			get
			{
				//singleton design pattern
				if (instance == null)
				{
					instance = new HRAccountDAO();
				}
				return instance;
			}
		}
		public HRAccountDAO()
		{
			hrAccountDAO = new GenericDAO<Hraccount>(new CandidateManagementContext());
            dbContext = new CandidateManagementContext();
		}
		public Hraccount GetHraccountByEmail(string email)
		{
			return hrAccountDAO.GetById(email);
		}

		public List<Hraccount> GetHraccounts()
		{
			return hrAccountDAO.GetAll();
		}
        public List<Hraccount> GetHraccountsByNameOrRole(string? Name, int? Role)
        {
            if (string.IsNullOrWhiteSpace(Name) && Role==null)
            {
                return dbContext.Hraccounts.ToList();
            }
            if (!string.IsNullOrWhiteSpace(Name) && Role == null)
            {
                return dbContext.Hraccounts.Where(m => m.FullName.Contains(Name)).ToList();
            }
            if (string.IsNullOrWhiteSpace(Name) && Role != null)
            {
                return dbContext.Hraccounts.Where(m => m.MemberRole.Equals(Role)).ToList();
            }
            return dbContext.Hraccounts.Where(m => m.FullName.Contains(Name) && m.MemberRole.Equals(Role)).ToList();
        }

        public bool AddHraccount(Hraccount newAccount)
        {
            if (GetHraccountByEmail(newAccount.Email) != null)
            {
                return false;
            }
            return hrAccountDAO.Add(newAccount);
        }
        public bool DeleteHraccount(string Email)
        {
            return hrAccountDAO.Delete(Email);
        }
        public bool UpdateHraccount(Hraccount account)
        {
            if (GetHraccountByEmail(account.Email) == null)
            {
                return false;
            }
            return hrAccountDAO.Update(account);
        }
    }
}
