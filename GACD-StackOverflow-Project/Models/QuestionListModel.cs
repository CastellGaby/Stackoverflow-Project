﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GACD_StackOverflow_Project.Models
{
    public class QuestionListModel
    {
        [Required(ErrorMessage = "*Is required a title for your question")]
        public string Title { get; set; }
        [Required(ErrorMessage = "*Is required a description")]
        public string Description { get; set; }
        public string OwnerUsername { get; set; }
        [Required(ErrorMessage = "*Is required a description for your question")]
        [DataType(DataType.DateTime)]
        public DateTime CreationDateQuestion { get; set; }
        public int Votes { get; set; }
        public Guid QuestionId { get; set; }
        public Guid OwnerUserId { get; set; }
    }
}