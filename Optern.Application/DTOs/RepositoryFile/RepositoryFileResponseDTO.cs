﻿

namespace Optern.Application.DTOs.RepositoryFile
{
    public class RepositoryFileResponseDTO
    {
        public int Id { get; set; }
        public int RepositoryId { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PublicId { get; set; }
        public RepositoryFileResponseDTO()
        {
            Id = 0;
            RepositoryId=0;
            FilePath = string.Empty;
            Description = string.Empty;
            CreatedAt=DateTime.MinValue;
            PublicId= string.Empty;
        }
    }
}
