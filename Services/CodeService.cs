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
            return _CodeRepository.SaveProduct(code);
        }
        public string DeleteProduct(int ProductId)
        {
            return _CodeRepository.DeleteProduct(ProductId);
        }
        public string UpdateProduct(Product Product)
        {
            return _CodeRepository.UpdateProduct(Product);
        }
        public CodeService GetCodeDetailsByID(int ProductId)
        {
            return _CodeRepository.GetCodeDetailsByID(ProductId);
        }
        public List<Product> GetAllProduct()
        {
            return _CodeRepository.GetAllProduct();
        }
    }
}
