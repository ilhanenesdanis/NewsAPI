using Core.Service;
using DTO.AddOrUpdateDto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface INewsService:IService<News>
    {
        void AddNews(AddNewsDTO addNews);
        List<News> GetAllNews();
    }
}
