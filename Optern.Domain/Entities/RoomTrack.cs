﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optern.Domain.Entities
{
    public class RoomTrack
    {
        public int Id { get; set; }

        // Foreign Keys
        public int TrackId { get; set; }
        public string RoomId { get; set; }

        // Navigation Properties
        public virtual Track Track { get; set; }
        public virtual Room Room { get; set; }
    }
}
