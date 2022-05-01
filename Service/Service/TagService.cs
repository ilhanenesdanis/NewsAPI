using AutoMapper;
using Core.Repository;
using Core.UnitOfWork;
using Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class TagService : Service<Tag>, ITagService
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;
        public TagService(IUnitOfWork unitOfWork, IRepository<Tag> repository, ITagRepository tagRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }
    }
}
