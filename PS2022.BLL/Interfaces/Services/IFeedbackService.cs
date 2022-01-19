using PS2022.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Interfaces.Services
{
    public interface IFeedbackService
    {
        public FeedbackDTO Create(FeedbackDTO dto);
        public FeedbackDTO GetById(int id);
        public List<FeedbackDTO> GetAll();
        public FeedbackDTO Update(FeedbackDTO dto);
        public void Delete(int id);
    }
}
