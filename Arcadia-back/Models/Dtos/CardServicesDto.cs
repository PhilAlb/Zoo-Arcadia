﻿using System.ComponentModel.DataAnnotations;

namespace Arcadia_back.models.Dtos
{
    public class CardServicesDto : CardDto
    {
        [Required]
        public string Schedules { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
