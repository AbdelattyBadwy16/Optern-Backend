﻿

namespace Optern.Application.DTOs.Sprint
{
    public class AddSprintDTO
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Goal { get; set; }
        public int WorkSpaceId { get; set; }

        public AddSprintDTO()
        {
            Title=string.Empty;
            Goal = string.Empty;
            StartDate = DateTime.Now;
            EndDate=DateTime.Now;
            WorkSpaceId=0;
        }

    }
}
