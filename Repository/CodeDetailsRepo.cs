using Microsoft.EntityFrameworkCore;
using ProjectCode.Data;
using ProjectCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Repository
{
    public class CodeDetailsRepo : ICode
    {
        private ProjectCodeDbContext _projectCodeDb;

        public CodeDetailsRepo(ProjectCodeDbContext projectCodeDb)
        {
            _projectCodeDb = projectCodeDb;
        }
        public string DeleteCodeDetails(int codeID)
        {
            string msg = "";
            CodeDetails delete = _projectCodeDb.CodeDetails.Find(codeID);//storing the details of the Code in the obj 
            try
            {
                if (delete != null)
                {
                    _projectCodeDb.CodeDetails.Remove(delete);
                    _projectCodeDb.SaveChanges();
                    msg = "Deleted";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return msg;
        }

        public List<CodeDetails> GetAllCodeDetails()
        {
            List<CodeDetails> codeDetails = _projectCodeDb.CodeDetails.ToList();
            return codeDetails;
        }

        public CodeDetails GetCodeDetailsByID(int codeID)
        {
            try
            {
                CodeDetails code = _projectCodeDb.CodeDetails.Find(codeID);
                return code;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string SaveCodeDetails(CodeDetails codeDetails)
        {
            try
            {
                _projectCodeDb.CodeDetails.Add(codeDetails);
                _projectCodeDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return "Saved";
        }

        public string UpdateCodeDetails(CodeDetails codeDetails)
        {
            try
            {
                _projectCodeDb.Entry(codeDetails).State = EntityState.Modified;
                _projectCodeDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return "Updated";
        }
    }
}
