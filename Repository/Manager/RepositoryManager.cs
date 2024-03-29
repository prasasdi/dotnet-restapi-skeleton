﻿using Contracts.Repository;
using Contracts.Repository.CompanyContext;
using Contracts.Repository.Manager;
using Repository.Models;
using Repository.Models.CompanyContext;
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

        private readonly Lazy<IPemesanRepository> _pemesanRepository;
        private readonly Lazy<IPesananRepository> _pesananRepository;
        private readonly Lazy<IKomentarProdukRepository> _komentarRepository;
        private readonly Lazy<IProdukRepository> _produkRepository;

        private readonly Lazy<IM_CompanyRepository> _M_CompanyRepository;
        private readonly Lazy<IM_DepartmentRepository> _M_DepartmentRepository;
        private readonly Lazy<IM_DivisionRepository> _MDivisionRepository;
        private readonly Lazy<ICompanyDepartmentsRepository> _companyDepartmentsRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _pemesanRepository = new Lazy<IPemesanRepository>(() => new PemesanRepository(repositoryContext));
            _pesananRepository = new Lazy<IPesananRepository>(() => new PesananRepository(repositoryContext));
            _produkRepository = new Lazy<IProdukRepository>(() => new ProdukRepository(repositoryContext));
            _komentarRepository = new Lazy<IKomentarProdukRepository>(() => new KomentarProdukRepository(repositoryContext));

            _M_CompanyRepository = new Lazy<IM_CompanyRepository>(() => new M_CompanyRepository(repositoryContext));
            _M_DepartmentRepository = new Lazy<IM_DepartmentRepository>(() => new M_DepartmentRepository(repositoryContext));
            _companyDepartmentsRepository = new Lazy<ICompanyDepartmentsRepository>(() => new CompanyDepartmentsRepository(repositoryContext));
            //_M_DivisionRepository = new Lazy<IM_DepartmentRepository>(() => new M_DivisionRepository(repositoryContext));
        }
        public IProdukRepository Produk => _produkRepository.Value;
        public IPesananRepository Pesanan => _pesananRepository.Value;
        public IPemesanRepository Pemesan => _pemesanRepository.Value;
        public IKomentarProdukRepository Komentar => _komentarRepository.Value;

        public IM_CompanyRepository Company => _M_CompanyRepository.Value;

        public IM_DepartmentRepository Department => _M_DepartmentRepository.Value;

        public IM_DivisionRepository Division => throw new NotImplementedException();

        public ICompanyDepartmentsRepository CompanyDepartments => _companyDepartmentsRepository.Value;

        //public IM_DivisionRepository Division => throw new NotImplementedException();

        public void Save() => _repositoryContext.SaveChanges();
    }
}
