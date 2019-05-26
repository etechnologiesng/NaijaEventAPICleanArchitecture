using NaijaEvent.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.NEvents.Models
{
   public class GetListEventViewModel
    {
        public List<NEventDTO> NEvents { get; set; }
    }
}
