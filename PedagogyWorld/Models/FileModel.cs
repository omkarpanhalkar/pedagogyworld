﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PedagogyWorld.Models
{
    public class FileModel
    {
        public string Description { get; set; }

        public DateTime TeachingDate { get; set; }

        public Guid Id { get; set; }

        public IEnumerable<SelectListItem> FileTypes { get; set; }

        public HttpPostedFileBase UploadFile { get; set; }

        public int[] FileIds { get; set; }
    }
}