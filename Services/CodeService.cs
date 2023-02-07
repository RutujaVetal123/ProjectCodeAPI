using ProjectCode.Models;
using ProjectCode.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Services
{
    public class CodeService
    {
        public ICode _CodeRepository;

        public CodeService(ICode code)
        {
            _CodeRepository = code;
        }

        public string SaveCodeDetails(CodeDetails code)
        {
            return _CodeRepository.SaveCodeDetails(code);
        }
        public string DeleteCodeDetails(int CodeID)
        {
            return _CodeRepository.DeleteCodeDetails(CodeID);
        }
        public string UpdateCodeDetails(CodeDetails code)
        {
            return _CodeRepository.UpdateCodeDetails(CodeDetails);
        }
        public CodeService GetCodeDetailsByID(int CodeID)
        {
            return _CodeRepository.GetCodeDetailsByID(CodeID);
        }
        public List<CodeDetails> GetAllCodeDetails()
        {
            return _CodeRepository.GetAllCodeDetails();
        }
    }
}
