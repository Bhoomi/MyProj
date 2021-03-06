﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.ViewModel.Plan
{
    public class PlanAddMountingInfoViewModel
    {
        public Guid PlanDetailsId { get; set; }
        public string BriefNo { get; set; }
        public int? PlanNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Region { get; set; }
        public Guid PlanCityId { get; set; }
        public string LocationId { get; set; }
        public decimal CityBudget { get; set; }
        public string LocationName { get; set; }
        public IEnumerable<PlanRegionViewModel> Regions { get; set; }
        public SelectList RegionsList
        {
            get
            {
                return new SelectList(Regions, "Region", "Region", Region);
            }
        }
        public IEnumerable<PlanSite> PlanSites { get; set; }
        public string MountingVendorId { get; set; }
        public string MountingVendorName { get; set; }
        public decimal MountingRate { get; set; }
        public decimal MountingClientRate { get; set; }
        public decimal MountingClientCost { get; set; }
    }
}