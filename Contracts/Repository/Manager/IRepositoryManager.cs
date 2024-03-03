using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository.Manager
{
    public interface IRepositoryManager
    {
        IClassGroupRepository ClassGroup { get; }
        IClassMemberRepository ClassMember { get; }
        IProdukRepository Produk { get; }
        IPemesanRepository Pemesan { get; }
        IPesananRepository Pesanan { get; }
        IKomentarProdukRepository Komentar { get; }
        void Save();
    }
}
