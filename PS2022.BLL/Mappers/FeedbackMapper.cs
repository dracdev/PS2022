using PS2022.BLL.Dto;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.BLL.Mappers
{
    internal static class FeedbackMapper
    {
       
        internal static FeedbackDTO ToDTO(this Feedback entity) 
        {
            FeedbackDTO dto = new FeedbackDTO
            {
                Id = entity.Id,
                IsAnonymous = entity.IsAnonymous,
                MarkValue = entity.MarkValue,
                PatientId = entity.PatientId,
                Patient = entity.Patient.ToDTO(),
                Comment = entity.Comment
            };

            return dto;
        }

        internal static Feedback ToEntity(this FeedbackDTO dto) 
        {
            Feedback entity = new Feedback
            {
                Id = dto.Id,
                IsAnonymous = dto.IsAnonymous,
                MarkValue = dto.MarkValue,
                PatientId = dto.PatientId,
                Patient = dto.Patient.ToEntity(),
                Comment = dto.Comment
            };

            return entity;
        }

        internal static IEnumerable<FeedbackDTO> ToDTOs(this IEnumerable<Feedback> entities) => entities.Select(e => e.ToDTO());
        internal static IEnumerable<Feedback> ToEntities(this IEnumerable<FeedbackDTO> dtos) => dtos.Select(e => e.ToEntity());
    }
}
