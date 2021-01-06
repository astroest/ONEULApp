using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ONEULApp.Data
{
    public interface OneulRepository
    {
        Task Initialize();
        Task<List<OneulDB>> GetOneuls();
        Task AddorUpdateOneul(OneulDB oneuldb);
    }
}
