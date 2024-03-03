using Contracts.Repository;
using Contracts.Repository.Manager;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Manager
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IClassGroupRepository> _classGroupRepository;
        private readonly Lazy<IClassMemberRepository> _classMemberRepository;

        private readonly Lazy<IPemesanRepository> _pemesanRepository;
        private readonly Lazy<IPesananRepository> _pesananRepository;
        private readonly Lazy<IKomentarProdukRepository> _komentarRepository;
        private readonly Lazy<IProdukRepository> _produkRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _classGroupRepository = new Lazy<IClassGroupRepository>(() => new ClassGroupRepository(repositoryContext));
            _classMemberRepository = new Lazy<IClassMemberRepository>(() => new ClassMemberRepository(repositoryContext));

            _pemesanRepository = new Lazy<IPemesanRepository>(() => new PemesanRepository(repositoryContext));
            _pesananRepository = new Lazy<IPesananRepository>(() => new PesananRepository(repositoryContext));
            _produkRepository = new Lazy<IProdukRepository>(() => new ProdukRepository(repositoryContext));
            _komentarRepository = new Lazy<IKomentarProdukRepository>(() => new KomentarProdukRepository(repositoryContext));
        }

        public IClassGroupRepository ClassGroup => _classGroupRepository.Value;
        public IClassMemberRepository ClassMember => _classMemberRepository.Value;
        public IProdukRepository Produk => _produkRepository.Value;
        public IPesananRepository Pesanan => _pesananRepository.Value;
        public IPemesanRepository Pemesan => _pemesanRepository.Value;
        public IKomentarProdukRepository Komentar => _komentarRepository.Value;
        public void Save() => _repositoryContext.SaveChanges();
    }
}
