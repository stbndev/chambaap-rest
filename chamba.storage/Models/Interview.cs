﻿using System;
using System.Collections.Generic;

#nullable disable

namespace chambapp.storage.Models
{
    public partial class Interview
    {
        public int Id { get; set; }
        public int IdstatusCatalog { get; set; }
        public string EconomicExpectations { get; set; }
        public string EconomicExpectationsOffered { get; set; }
        public int? InterviewDate { get; set; }
        public int ShipDate { get; set; }
        public int? ReplyDate { get; set; }
        public string Provider { get; set; }
        public int Idrecruiter { get; set; }
        public int Idcompany { get; set; }
        public int Idcandidate { get; set; }

        public virtual User IdcandidateNavigation { get; set; }
        public virtual Company IdcompanyNavigation { get; set; }
        public virtual User IdrecruiterNavigation { get; set; }
    }
}
