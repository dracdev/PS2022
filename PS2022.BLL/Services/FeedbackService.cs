using PS2022.BLL.Dto;
using PS2022.BLL.Interfaces.Services;
using PS2022.BLL.Mappers;
using PS2022.DAL.Interfaces.Repository;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private IGenericRepository<Feedback> _repository;

        public FeedbackService(IGenericRepository<Feedback> repository)
        {
            _repository = repository;
        }

        public FeedbackDTO Create(FeedbackDTO dto)
        {
            throw new NotImplementedException();
        }

        public List<FeedbackDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public FeedbackDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public FeedbackDTO Update(FeedbackDTO dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
